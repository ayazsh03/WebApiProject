using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataTables
{
    /// <summary>
    /// Contains all logic to be shared among all data tables in the DAL.
    /// </summary>    
    [Serializable]
    public abstract class BaseDataTable : DataTable
    {
        #region Protected Properties

        /// <summary>
        /// Gets the type name of the data table.
        /// </summary>
        protected abstract string TypeName { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Converts the data table into a <see cref="SqlParameter"/>.
        /// </summary>
        /// <param name="parameterName">The parameter name.</param>
        /// <returns>The <see cref="SqlParameter"/>.</returns>
        public SqlParameter ToSqlParameter(string parameterName)
        {
            return new SqlParameter(parameterName, SqlDbType.Structured) { Value = this, TypeName = this.TypeName };
        }

        #endregion
    }
}
