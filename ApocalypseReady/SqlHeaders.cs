using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApocalypseReady
{
    public class SqlHeaders
    {
        public const string Select = " SELECT ";
        public const string Top = " TOP ";
        public const string Distinct = " DISTINCT ";
        public const string Star = " * ";
        public const string From = " FROM ";
        public const string Inner = " INNER ";
        public const string Join = " JOIN ";
        public const string InnerJoin = " INNER JOIN ";
        public const string Left = " LEFT ";
        public const string Where = " WHERE ";
        public const string EqualsSign = " = ";
        //...
        public const string OrderBy = " ORDER BY ";
        public const string Asc = " ASC ";
        public const string Desc = " DESC ";

        public class Numbers
        {
            public const string Zero = " 0 ";
            public const string One = " 1 ";
        }

    }

    public class SqlTables
    {
        public const string Products = " Products ";
    }

    public class SqlColumns
    {
        public class Products
        {
            public const string IsActive = " IsActive ";
        }
    }


    public class SqlQueries
    {
        public const string SelectActiveProducts =
          SqlHeaders.Select +
          SqlHeaders.Star +
          SqlHeaders.From +
          SqlTables.Products +
          SqlHeaders.Where +
          SqlColumns.Products.IsActive +
          SqlHeaders.EqualsSign +
          SqlHeaders.Numbers.One;

        //...
    }



}
