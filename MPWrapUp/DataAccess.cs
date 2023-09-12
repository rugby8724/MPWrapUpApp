using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPWrapUp
{
    public static class DataAccess
    {
        public static void SavetoCSV<T>(this List<T> items, string filePath) where T: new()
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();

            string row = "";

            foreach ( var col in cols )
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach ( var item in items ) 
            {
                row = "";

                foreach (var col in cols)
                {
                    row += $",{col.GetValue(item, null)}";
                }
                row = row.Substring(1);
                rows.Add(row);
            }

            File.WriteAllLines(filePath, rows);
        }
    }
}
