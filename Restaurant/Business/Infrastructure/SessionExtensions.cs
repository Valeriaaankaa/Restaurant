using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;

namespace Business.Infrastructure
{
    public static class SessionExtensions
    {
        static JsonSerializerSettings serializerSettings = new() { PreserveReferencesHandling = PreserveReferencesHandling.Objects };
        public static void SetJson(this ISession session, string key, object value)
            => session.SetString(key, JsonConvert.SerializeObject(value, serializerSettings));

        public static T? GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData, serializerSettings);
        }
    }
}
