using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL
{
    /// <summary>
    /// Interface for the <see cref="DataSourceFactory"/> class.
    /// </summary>
    public interface IDataSourceFactory
    {
        /// <summary>
        /// Creates a new data source.
        /// </summary>
        /// <returns>The data source.</returns>
        IDataSource CreateDataSource();
    }

    /// <summary>
    /// Contains all logic for creating new data sources.
    /// </summary>
    public class DataSourceFactory : IDataSourceFactory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceFactory"/> class.
        /// </summary>
        public DataSourceFactory()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a new data source.
        /// </summary>
        /// <returns>The data source.</returns>
        public IDataSource CreateDataSource()
        {
            return new DataSource();
        }

        #endregion
    }
}
