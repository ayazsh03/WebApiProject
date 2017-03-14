using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.DAL.DataTables
{
    /// <summary>
    /// Represents a table of strings.
    /// </summary>
    [Serializable]
    public class IdNamePairsDataTable : BaseDataTable
    {
        #region Constructors

        /// <summary>            
        /// Initializes a new instance of the <see cref="IdNamePairsDataTable"/> class.
        /// </summary>
        public IdNamePairsDataTable()
        {
            this.Columns.Add(new DataColumn("Id", typeof(string))
            {
                AllowDBNull = false
            });

            this.Columns.Add(new DataColumn("Name", typeof(string))
            {
                AllowDBNull = false
            });
        }

        #endregion

        #region Protected Properties

        /// <summary>
        /// Gets the type name of the data table.
        /// </summary>
        protected override string TypeName
        {
            get { return "dbo.IdNamePairs"; }
        }

        #endregion

        #region Public Methods

        ///// <summary>
        ///// Adds the list of values to the data table.
        ///// </summary>
        ///// <param name="dictionary">The dictionary of values.</param>
        //public void Add(MultiValuedDictionary<string, string> dictionary)
        //{
        //    if (dictionary != null)
        //    {
        //        foreach (var pair in dictionary)
        //        {
        //            this.Add(pair.Key, pair.Value);
        //        }
        //    }
        //}

        /// <summary>
        /// Adds the specified id name pair to the data table.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="names">The values.</param>
        //public void Add(string id, List<string> names)
        //{
        //    if (names != null)
        //    {
        //        foreach (var value in names)
        //        {
        //            this.Add(id, value);
        //        }
        //    }
        //}

        /// <summary>
        /// Adds the specified key value pair to the data table.
        /// </summary>
        /// <param name="id">The key.</param>
        /// <param name="name">The value.</param>
        public void Add(string id, string name)
        {
            var row = this.NewRow();

            row["Id"] = id;
            row["Name"] = name;

            this.Rows.Add(row);
        }

        #endregion
    }

}
