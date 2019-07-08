using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace TelegramBot_v2
{
    class UserRepository
    {
        public static void UserIds(long userid)
        {

            if (File.Exists("usersid.json"))
            {
                var s = JsonConvert.DeserializeObject<List<long>>(File.ReadAllText("usersid.json")) ?? new List<long>();
                if (!s.Contains(userid))
                {
                    s.Add(userid);
                }
                File.WriteAllText("usersid.json", JsonConvert.SerializeObject(s));
            }
            else
            {
                File.Create("usersid.json");
                var s = JsonConvert.DeserializeObject<List<long>>(File.ReadAllText("usersid.json")) ?? new List<long>();
                if (!s.Contains(userid))
                {
                    s.Add(userid);
                }
                File.WriteAllText("usersid.json", JsonConvert.SerializeObject(s));
            }
        }
    }
}
