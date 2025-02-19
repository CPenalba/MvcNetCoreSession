using MvcNetCoreSession.Helpers;
using Newtonsoft.Json;

namespace MvcNetCoreSession.Extensions
{
    public static class SessionExtension
    {
        //CREAMOS UN METODO PARA RECUPERAR CUALQUIER OBJETO
        public static T GetObject<T>(this ISession session, string key)
        {
            //YA ESTAREMOS TRABAJANDO CON HttpContext.Session
            //DEBEMOS RECUPERAR LO QUE TENEMOS ALMACENADO DENTRO DE Session
            string json = session.GetString(key);
            //QUE SUCEDE SI RECUPERAMOS ALGO DE SESSION QUE NO EXISTE???
            //SI NO TENEMOS NADA ALMACENADO, DEBEMOS DEVOLVER EL VALOR POR DEFECTO
            if (json == null)
            {
                return default(T);
            }
            else
            {
                //RECUPERAMOS EL OBJETO QUE TENEMOS ALMACENADO DENTRO DE NUESTRA KEY
                T data = JsonConvert.DeserializeObject<T>(json);
                return data;
            }
        }

        public static void SetObject(this ISession session, string key, object value)
        {
            string data = JsonConvert.SerializeObject(value);
            //ALMACENAMOS EL JSON DENTRO DE SESSION
            session.SetString(key, data);
        }
    }
}
