using Newtonsoft.Json;
using System.IO;

namespace TableGame.Model
{
    class FileOperation
    {

        private static void isFileExists(string fileName)
        {
            if (!File.Exists(fileName + ".json"))
            {
                File.Create(fileName + ".json");
            }
        }

        public static JsonTextReader CreateJsonTextReader(string fileName)
        {
            isFileExists(fileName);
            JsonTextReader jsonTextReader = new JsonTextReader(new StreamReader(fileName + ".json"));
            return jsonTextReader;
        }

        public static JsonTextWriter CreateJsonTextWriter(string fileName)
        {
            isFileExists(fileName);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(new StreamWriter(fileName + ".json"));
            return jsonTextWriter;
        }
    }
}
