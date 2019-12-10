using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMailLibrary
{
    class DataValidation
    {

        public bool CheckForData(DataSet ds)
        {
            bool dataFound = false;
            if (ds != null && ds.Tables.Count > 0)
            {
                // Check the row count for each table to see if any one table has data.
                foreach (System.Data.DataTable table in ds.Tables)
                {
                    if (table.Rows.Count > 0)
                    {
                        //we have data
                        dataFound = true;
                        break;
                    }
                }
            }
            if (dataFound)
            {
                Console.WriteLine("YES we have data");
                return true;
            }
            else
            {
                Console.WriteLine("we have NO NO NO NO NO data");
                return false;
            }
        }

    }
}
