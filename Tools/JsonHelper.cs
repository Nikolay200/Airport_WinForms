using Newtonsoft.Json;

namespace Tools
{
    public static class JsonHelper
    {
        public static string SerializeObject<T>(this T toSerialize)
        {
            if (toSerialize == null) return null;
            JsonSerializer jsonSerializer = new JsonSerializer();

            using (StringWriter textWriter = new StringWriter())
            {
                jsonSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static object DeSerializeObject(string s, Type t)
        {
            if (s == null || t == null) return null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (TextReader reader = new StringReader(s))
            {
                return jsonSerializer.Deserialize(reader, t);
            }
        }
    }
}