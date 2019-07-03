using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace TelegramBot_v2
{

    static class ChanelsRepository
    {
        private static readonly string FilePath = "categoryes.json";
        public static void Create(string nameCategory)
        {
            var categories = Read();
            categories.Add(new Category(nameCategory));
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(categories));

        }
        public static void Create(string nameCategory, Chanel chanel)
        {

        }
        public static List<Category> Read()
        {          
            return JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText(FilePath)) ?? new List<Category>();
        }
        public static List<Chanel> Read(string nameCategory)
        {
            return new List<Chanel>();
        }
        public static void Update(string newNameCategory, string currentNameCategory)
        {

        }
        public static void Update(string nameCategory, Chanel chanel)
        {

        }


    }
}
