using Newtonsoft.Json;

namespace MvcNetCoreSession.Helpers
{
    public class HelperJsonSession
    {
        //VAMOS A UTILIZAR EL METODO GetString() COMO HERRAMIENTA
        //ALMACENAREMOS OBJETOS CON Serialize de JSON { nombre: "aa", raza: ""}
        public static string SerializeObject<T>(T data)
        {
            //CONVERTIMOS EL OBJETO A STRING MEDIANTE Newton
            string json = JsonConvert.SerializeObject(data);
            return json;
        }

        //RECIBIREMOS UN string Y LO CONVERTIMOS A CUALQUIER OBJETO T
        public static T DeserializeObject<T>(string data)
        {
            //DESERIALIZAMOS EL STRING A CUALQUIER OBJETO
            T objeto = JsonConvert.DeserializeObject<T>(data);
            return objeto;
        }
    }
}
