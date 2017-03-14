using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LuckyMasale.DAL.DataTables;
using LuckyMasale.Shared;


namespace LuckyMasale.DAL
{
    public interface IDataSource : IDisposable
    {
        #region Methods

        /// <summary>
        /// Executes a stored procedure that does not return any results.
        /// </summary>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The task.</returns>
        Task<int> ExecuteNonQuery(string procedureName, params SqlParameter[] parameters);       

        /// <summary>
        /// Gets a single result from the database.
        /// </summary>
        /// <typeparam name="T">The type of result to return.</typeparam>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The result.</returns>
        Task<T> GetResult<T>(string procedureName, params SqlParameter[] parameters);

        /// <summary>
        /// Gets a list of results from the database.
        /// </summary>
        /// <typeparam name="T">The type of result to return.</typeparam>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The results.</returns>
        Task<List<T>> GetResults<T>(string procedureName, params SqlParameter[] parameters);

        /// <summary>
        /// Gets a list of dynamic objects from the database.
        /// </summary>
        /// <param name="procedureName">The procedure name.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The list of dynamics.</returns>
        Task<List<dynamic>> GetDynamicResults(string procedureName, params SqlParameter[] parameters);

        /// <summary>
        /// Gets the data reader for the specified stored procedure.
        /// </summary>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The <see cref="SqlDataReader"/>.</returns>
        Task<SqlDataReader> GetDataReader(string procedureName, params SqlParameter[] parameters);

        /// <summary>
        /// Gets the data reader for the specified stored procedure.
        /// </summary>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The <see cref="SqlDataReader"/>.</returns>
        SqlDataReader GetDataReaderSync(string procedureName, params SqlParameter[] parameters);

        /// <summary>
        /// Creates a parameter for calling a stored procedure.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="parameterValue">The value of the parameter.</param>
        /// <param name="sqlDbType">The SQL database type.</param>
        /// <returns>The created SQL Parameter.</returns>
        SqlParameter CreateParameter(string parameterName, object parameterValue, SqlDbType? sqlDbType = null);

        /// <summary>
        /// Creates a parameter for calling a stored procedure.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="dataTable">The <see cref="BaseDataTable"/>.</param>        
        /// <returns>The created SQL Parameter.</returns>
        SqlParameter CreateParameter(string parameterName, BaseDataTable dataTable);

        /// <summary>
        /// Maps the results from the reader to a list of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of objects being returned from the stored procedure.</typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns>The mapped list.</returns>
        List<T> MapResults<T>(SqlDataReader reader);

        /// <summary>
        /// Maps the results from the reader to a list of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of objects being returned from the stored procedure.</typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns>The mapped list.</returns>
        T MapResult<T>(SqlDataReader reader);

        /// <summary>
        /// Maps the results from the reader to a list of dynamic type.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The mapped list.</returns>
        List<dynamic> MapDynamicResults(SqlDataReader reader);

        #endregion
    }
    public sealed class DataSource : DbContext, IDataSource
    {
        #region Fields

        /// <summary>
        /// The logger.
        /// </summary>
        private ILog logger;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource"/> class.
        /// </summary>
        public DataSource()
                : base("LuckyMasale.Conn")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;

            this.Database.CommandTimeout = 120;

            this.Database.Connection.Open();

            XmlConfigurator.Configure();

            this.logger = LogManager.GetLogger("DataSource");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes a stored procedure that does not return any results.
        /// </summary>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The task.</returns>
        public async Task<int> ExecuteNonQuery(string procedureName, params SqlParameter[] parameters)
        {
            procedureName = this.ConcatProcedureName(procedureName, parameters);

            try
            {
                this.logger.DebugFormat("{0} - Starting call", procedureName);
                var result = await this.Database.ExecuteSqlCommandAsync(procedureName, parameters);
                this.logger.DebugFormat("{0} - Finished call - {1} rows affected", procedureName, result);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.Error(string.Format("{0} - Error during call", procedureName), ex);

                throw;
            }
        }

        /// <summary>
        /// Gets a single result from the database.
        /// </summary>
        /// <typeparam name="T">The type of result to return.</typeparam>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The result.</returns>
        public async Task<T> GetResult<T>(string procedureName, params SqlParameter[] parameters)
        {
            procedureName = this.ConcatProcedureName(procedureName, parameters);

            try
            {
                this.logger.DebugFormat("{0} - Starting call", procedureName);
                var result = await this.Database.SqlQuery<T>(procedureName, parameters).FirstOrDefaultAsync();
                this.logger.DebugFormat("{0} - Finished call - record was {1}", procedureName, result == null ? "null" : "found");

                return result;
            }
            catch (Exception ex)
            {
                // Let the caller throw the error, they may be retrying when an APPLOCK can't be acquired.
                this.logger.DebugFormat(string.Format("{0} - Error during call", procedureName), ex);
                throw;
            }
        }


        /// <summary>
        /// Gets a list of results from the database.
        /// </summary>
        /// <typeparam name="T">The type of result to return.</typeparam>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The results.</returns>
        public async Task<List<T>> GetResults<T>(string procedureName, params SqlParameter[] parameters)
        {
            procedureName = this.ConcatProcedureName(procedureName, parameters);

            try
            {
                this.logger.DebugFormat("{0} - Starting call", procedureName);
                var results = await this.Database.SqlQuery<T>(procedureName, parameters).ToListAsync();
                this.logger.DebugFormat("{0} - Finished call - {1} results", procedureName, results.Count);

                return results;
            }
            catch (Exception ex)
            {
                // Let the caller throw the error, they may be retrying when an APPLOCK can't be acquired.
                this.logger.DebugFormat(string.Format("{0} - First-chance exception during call", procedureName), ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of dynamic objects from the database.
        /// </summary>
        /// <param name="procedureName">The procedure name.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The list of dynamics.</returns>
        public async Task<List<dynamic>> GetDynamicResults(string procedureName, params SqlParameter[] parameters)
        {
            using (var reader = await this.GetDataReader(procedureName, parameters))
            {
                return this.FillListFromReader(reader);
            }
        }

        /// <summary>
        /// Gets the data reader for the specified stored procedure.
        /// </summary>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The <see cref="SqlDataReader"/>.</returns>
        [ExcludeFromCodeCoverage]
        public async Task<SqlDataReader> GetDataReader(string procedureName, params SqlParameter[] parameters)
        {
            try
            {
                using (var cmd = (SqlCommand)this.Database.Connection.CreateCommand())
                {
                    if (this.Database.CommandTimeout.HasValue)
                    {
                        cmd.CommandTimeout = this.Database.CommandTimeout.Value;
                    }

                    cmd.CommandText = procedureName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);

                    this.logger.DebugFormat("{0} - Starting call", procedureName);
                    var result = await cmd.ExecuteReaderAsync();
                    this.logger.DebugFormat("{0} - Finished call", procedureName);

                    return result;
                }
            }
            catch (Exception ex)
            {
                this.logger.Error(string.Format("{0} - Error during call", procedureName), ex);

                throw;
            }
        }

        /// <summary>
        /// Gets the data reader for the specified stored procedure.
        /// </summary>
        /// <param name="procedureName">The stored procedure name.</param>
        /// <param name="parameters">The parameters to the procedure.</param>
        /// <returns>The <see cref="SqlDataReader"/>.</returns>
        [ExcludeFromCodeCoverage]
        public SqlDataReader GetDataReaderSync(string procedureName, params SqlParameter[] parameters)
        {
            try
            {
                using (var cmd = (SqlCommand)this.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = procedureName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);

                    this.logger.DebugFormat("{0} - Starting call", procedureName);
                    var reader = cmd.ExecuteReader();
                    this.logger.DebugFormat("{0} - Finished call", procedureName);

                    return reader;
                }
            }
            catch (Exception ex)
            {
                this.logger.Error(string.Format("{0} - Error during call", procedureName), ex);

                throw;
            }
        }

        /// <summary>
        /// Creates a parameter for calling a stored procedure.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="parameterValue">The value of the parameter.</param>
        /// <param name="sqlDbType">The SQL database type.</param>
        /// <returns>The created SQL Parameter.</returns>
        public SqlParameter CreateParameter(string parameterName, object parameterValue, SqlDbType? sqlDbType = null)
        {
            var param = new SqlParameter(parameterName, parameterValue ?? DBNull.Value);

            if (sqlDbType.HasValue)
            {
                param.SqlDbType = sqlDbType.Value;
            }

            return param;
        }        

        /// <summary>
        /// Creates a parameter for calling a stored procedure.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="dataTable">The <see cref="BaseDataTable"/>.</param>        
        /// <returns>The created SQL Parameter.</returns>
        public SqlParameter CreateParameter(string parameterName, BaseDataTable dataTable)
        {   
            return dataTable.ToSqlParameter(parameterName);
        }


        /// <summary>
        /// Maps the results from the reader to a list of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of objects being returned from the stored procedure.</typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns>The mapped list.</returns>
        public List<T> MapResults<T>(SqlDataReader reader)
        {
            var adapter = (IObjectContextAdapter)this;

            var results = adapter.ObjectContext.Translate<T>(reader).ToList();

            reader.NextResult();

            return results;
        }

        /// <summary>
        /// Maps the results from the reader to a list of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of objects being returned from the stored procedure.</typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns>The mapped list.</returns>
        public T MapResult<T>(SqlDataReader reader)
        {
            var adapter = (IObjectContextAdapter)this;

            var results = adapter.ObjectContext.Translate<T>(reader).FirstOrDefault();

            reader.NextResult();

            return results;
        }

        /// <summary>
        /// Maps the results from the reader to a list of dynamic type.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The mapped list.</returns>
        public List<dynamic> MapDynamicResults(SqlDataReader reader)
        {
            return this.FillListFromReader(reader);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Disposes of the object.
        /// </summary>
        /// <param name="disposing">
        /// True to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            this.logger = null;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Concatenates the procedure name and the parameter names.
        /// </summary>
        /// <param name="procedureName">The procedure name.</param>
        /// <param name="parameters">The SQL Parameters.</param>
        /// <returns>The concatenated procedure name.</returns>
        private string ConcatProcedureName(string procedureName, IEnumerable<SqlParameter> parameters)
        {
            return string.Format("{0} {1}", procedureName, string.Join(", ", parameters.Select(t => "@" + t.ParameterName)));
        }

        /// <summary>
        /// Gets all column names from the data reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The list of columns names.</returns>
        private List<string> GetColumnNamesFromReader(SqlDataReader reader)
        {
            var list = new List<string>();
            var schemaTable = reader.GetSchemaTable();

            for (int i = 0; i <= schemaTable.Rows.Count - 1; i++)
            {
                var dataRow = schemaTable.Rows[i];
                list.Add(dataRow["ColumnName"].ToString());
            }

            return list;
        }

        /// <summary>
        /// Fills a list of dynamics from the data reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The list of objects.</returns>
        private List<dynamic> FillListFromReader(SqlDataReader reader)
        {
            var columns = this.GetColumnNamesFromReader(reader);
            var list = new List<dynamic>();

            while (reader.Read())
            {
                IDictionary<string, object> dynamicObject = new ExpandoObject();

                for (var i = 0; i < columns.Count; ++i)
                {
                    dynamicObject[columns[i]] = reader.GetValue(i);
                }

                list.Add(dynamicObject);
            }

            return list;
        }

        #endregion
    }
}
