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
            textBox1.Text = null;

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
        private InputOnlineFile img;
        private async void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string FileUrl = openFileDialog1.FileName; 
            MessageBox.Show("Картинка открыта");
            // Image img = Image.FromFile(openFileDialog1.FileName);
            using (var stream = File.Open(FileUrl, FileMode.Open))
            {
                var rep = await botClient.SendPhotoAsync(508813007, stream);
            }
            //botClient.SendPhotoAsync(508813007, "https://cdn.pixabay.com/photo/2015/04/19/08/32/rose-729509_960_720.jpg", "dfd", Telegram.Bot.Types.Enums.ParseMode.Html).Wait(5000);
            //int i = 5;
        }
    }
}