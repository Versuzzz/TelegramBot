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
    public partial class Form1 : Form
    {
        public static long ids;
        string mesage;
        public static TelegramBotClient botClient;
        public Form1()
        {
            InitializeComponent();
            botClient = new TelegramBotClient("794414690:AAG2dr2Nv-SrlJkuG929U2wv4Vc-rE4kxx0");
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();

        }
        public int messagechat;
        public string message;
        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text == "/start")
            {
                ids = e.Message.Chat.Id;
                UserRepository.UserIds(ids);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            message = textBox1.Text;
            botClient.SendTextMessageAsync(508813007, message);
            
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = textBox1.Text;
        }
    }
}


