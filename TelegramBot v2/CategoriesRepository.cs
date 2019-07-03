using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TelegramBot_v2
{
    static class CategoriesRepository
    {
        private static readonly string FilePath = "chanels.json";
        public static void Create(string nameChanel)
        {
            var chanels = Read();
            chanels.Add(new Category(nameChanel));
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(chanels));

        }
        public static void Create(string nameChanel, Category chanel)
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
