using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Megapix.Helpers
{
    public static class ConvertToQueryParamHelper<T>
    {
        public static async Task<string> ConvertAsync(T obj)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            PropertyInfo[] props = obj.GetType().GetProperties();

            foreach (PropertyInfo prop in props)
            {
                if (prop.GetValue(obj) != null)
                {
                    string propertyName = prop.Name;
                    string porpertyValue = prop.GetValue(obj).ToString();

                    dictionary.Add(propertyName, porpertyValue);
                }

            }
            var dictFormUrlEncoded = new FormUrlEncodedContent(dictionary);
            return await dictFormUrlEncoded.ReadAsStringAsync();
        }
    }
}
