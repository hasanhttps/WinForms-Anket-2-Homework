using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinForms_Anket_2_Homework.models {
    public static class JsonHandling {

        //public static string path = "C:\\Users\\Public\\Downloads\\";

        public static void WriteData<T>(T? list, string filename) {
            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;

            File.WriteAllText(filename, JsonSerializer.Serialize(list, op));
        }

        public static T? ReadData<T>(string filename) where T : new() {
            T? readData = new T();
            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;
            using FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            if (fs.Length != 0) readData = JsonSerializer.Deserialize<T>(fs, op);

            return readData;
        }
    }
}
