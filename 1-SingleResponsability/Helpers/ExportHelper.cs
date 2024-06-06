using System.Collections;
using System.Text;

namespace SingleResponsibility.Helpers
{
    internal static class ExportHelper
    {
        public static void ExportCSV<T>(string name, IEnumerable<T> items)
        {
            if (items.Count() == 0)
            {
                return;
            }

            StringBuilder csv = new();
            var properties = typeof(T).GetProperties();

            string header = String.Join(";", properties.Select(prop => prop.Name));
            csv.AppendLine(header);

            foreach (var item in items)
            {
                List<string> itemValues = new List<string>();
                foreach (var property in properties)
                {
                    var value = property.GetValue(item, null);
                    if (value is not string && value is IEnumerable ArrayValues) {
                        var values = ArrayValues.Cast<object>().Select(v => v);
                        itemValues.Add(String.Join("|", values));
                    }
                    else
                    {
                        string stringifyValue = value?.ToString() ?? "";
                        itemValues.Add(stringifyValue);
                    }
                }

                csv.AppendLine(String.Join(";", itemValues));
            }

            File.WriteAllText(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{name}.csv"),
                csv.ToString(),
                Encoding.Unicode
            );
        }
    }
}
