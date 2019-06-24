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
using System.Drawing;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Enums;

namespace TelegramBot_v2
{
    class Category
    {
        string Name;
        
        List<Chanel> Chanels = new List<Chanel>();
        public Category()
        {

        }
        public Category(string name)
        {

        }
    }
}
