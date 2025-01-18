using Newtonsoft.Json;
using Megapix.Exceptions;
using Megapix.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Megapix.Helpers
{
    public static class HttpResponseHelper<T>
    {
        public static async Task<T?> GetResponse(HttpResponseMessage response, bool catchError = true)
        {
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            else if (catchError)
            {
                string error;
                try
                {
                    var result = JsonConvert.DeserializeObject<BaseErrorResponse>(await response.Content.ReadAsStringAsync());
                    if (result != null && !string.IsNullOrEmpty(result.Message))
                    {
                        error = result.Message;
                    }
                    else
                    {
                        var resultValidation = JsonConvert.DeserializeObject<BaseErrorResponseValidation>(await response.Content.ReadAsStringAsync());
                        if (resultValidation != null && resultValidation.errors != null)
                        {
                            error = resultValidation.ToString();
                        }
                        else
                        {
                            error = "Error desconocido";
                        }
                    }
                }
                catch (Exception e)
                {
                    error = await response.Content.ReadAsStringAsync();
                }

                throw new CustomException(response.StatusCode, error);
            }
            else
            {
                return default;
            }
        }
    }
}
