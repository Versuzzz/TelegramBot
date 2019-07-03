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
    public partial class Form1 : Form
    {
        public static long id = 508813007;
        public static long UserId;
        string mesage;
        public static TelegramBotClient botClient;
        public string message;
        public string ImageUrl;
        public string ImageMessage;
        public string Url;
        public string MessageWithUrl;
        List<Category> categories = new List<Category>();
        List<Chanel> chanels = new List<Chanel>();
        public Form1()
        {
            InitializeComponent();
            UpdatePanel();
            //UpdateChannelsPanel();
            botClient = new TelegramBotClient("794414690:AAG2dr2Nv-SrlJkuG929U2wv4Vc-rE4kxx0");
            ConsoleRichTextBox.AppendText($"Бот успешно запущен.\n");
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();

        }
        public void UpdatePanel()
        {
            controlPanel.Controls.Clear();
            categories = ChanelsRepository.Read();
            foreach (var category in categories)
            {
                controlPanel.Controls.Add(new Button { Text = category.Name, Size = new Size(225, 40) });
            }
            controlPanel.Controls.Add(new AddButton(this));
        }
        //public void UpdateChannelsPanel()
        //{
        //    chanellsPanel.Controls.Clear();
        //    chanels = CategoriesRepository.Read();
        //    foreach (var chanel in chanels)
        //    {
        //        chanellsPanel.Controls.Add(new Button { Text = chanel., Size = new Size(225, 40) });
        //    }
        //    chanellsPanel.Controls.Add(new AddButton(this));
        //}
        public static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text == "/start")
            {
                botClient.SendTextMessageAsync(e.Message.Chat.Id, "Привет!");
                UserId = e.Message.Chat.Id;
                UserRepository.UserIds(UserId);
            }
            
        }
        
        private void SendTextButton_Click(object sender, EventArgs e)
        {

            botClient.SendTextMessageAsync(id, message, Telegram.Bot.Types.Enums.ParseMode.Markdown);
            textBox1.Text = null;
            ConsoleRichTextBox.AppendText($"Сообщение успешно отправлено.\n");
        }

        private void SendImageButton_Click(object sender, EventArgs e)
        {
            ImageUrl = textBox3.Text;
            ImageMessage = textBox2.Text;
            botClient.SendPhotoAsync(id, ImageUrl, $"{ImageMessage}", Telegram.Bot.Types.Enums.ParseMode.Markdown);
            ConsoleRichTextBox.AppendText($"Картинка успешно отправлена.\n");
            textBox3.Text = null;
            textBox2.Text = null;
        }
        private void CodeFormatTextButton_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(textBox1.Text);
            s.Insert(textBox1.SelectionStart, '`');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength + 1, '`');
            textBox1.Text = s.ToString();
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"Выделенный текст успешно изменен на code.\n");
        }
        private void BoldFormatTextButton_Click(object sender, EventArgs e)
        {

            StringBuilder s = new StringBuilder(textBox1.Text);                 
            s.Insert(textBox1.SelectionStart, '*');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength +1 , '*');
            textBox1.Text = s.ToString();   
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"Выделенный текст успешно изменен на жирный.\n");
        }
        private void ItalicFormatTextButton_Click(object sender, EventArgs e)
        {

            StringBuilder s = new StringBuilder(textBox1.Text);
            s.Insert(textBox1.SelectionStart, '_');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength + 1, '_');
            textBox1.Text = s.ToString();
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"Выделенный текст успешно изменен на наклонный.\n");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageWithUrl = textBox6.Text;
            textBox6.Text = null;
            Url = textBox5.Text;
            textBox5.Text = null;
            botClient.SendTextMessageAsync(id, $"<a href = \"{Url}\" >{MessageWithUrl}</a>", Telegram.Bot.Types.Enums.ParseMode.Html);
            ConsoleRichTextBox.AppendText($"Ссылка отправлена.\n");
        }


        //private void AddChanells_Click(object sender, EventArgs e)
        //{
        //    var NameChanel = ChanellName.Text;
        //    Chanel chanel = new Chanel(NameChanel);
        //    var score = None.SelectedIndex;
        //    //categories[score]Chanels.Add(chanel);

        //    File.WriteAllText(FilePath, JsonConvert.SerializeObject(categories));
        //}
    }
}