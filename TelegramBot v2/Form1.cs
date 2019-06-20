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

namespace TelegramBot_v2
{
    public partial class Form1 : Form
    {
        public static string id;
        public static long ids;
        string mesage;
        public static TelegramBotClient botClient;
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "Бот успешно запущен." + Environment.NewLine;
            botClient = new TelegramBotClient("794414690:AAG2dr2Nv-SrlJkuG929U2wv4Vc-rE4kxx0");
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();

        }
        public int messagechat;
        public string message;
        public static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text == "/start")
            {
                botClient.SendTextMessageAsync(e.Message.Chat.Id, "Bot started.Hello.");
                ids = e.Message.Chat.Id;
                UserRepository.UserIds(ids);
            }
            // 508813007 - айди андрея
            // 310811454 - айди стёпы
        }
        private void button1_Click(object sender, EventArgs e)
        {
            message = textBox1.Text;
            botClient.SendTextMessageAsync(id, message);
            textBox1.Text = null;
            textBox2.Text = "Сообщение успешно отправлено.";

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string FileDirectory = openFileDialog1.FileName; 

            botClient.SendPhotoAsync(id, FileDirectory, "Image.", Telegram.Bot.Types.Enums.ParseMode.Html).Wait(5000);

            MessageBox.Show("Картинка отправлена");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string url;
        private void button3_Click(object sender, EventArgs e)
        {
            botClient.SendPhotoAsync(id, url, "Image.", Telegram.Bot.Types.Enums.ParseMode.Html);
            textBox2.Text = "Картинка успешно отправлена.";
            textBox3.Text = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            url = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            id = textBox4.Text;
        }
    }
}