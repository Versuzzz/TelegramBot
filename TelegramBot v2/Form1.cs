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
        public int NumberConsoleMessage = 1;
        public static long id = 310811454;
        public static long ids;
        string mesage;
        public static TelegramBotClient botClient;
        public int messagechat;
        public string message;
        public string text;
        public string url2;
        public string url;

        List<Category> categories = new List<Category>();
        List<Chanel> chanels = new List<Chanel>();

        public Form1()
        {
            InitializeComponent();
            UpdatePanel();
            UpdateChannelsPanel();
            botClient = new TelegramBotClient("794414690:AAG2dr2Nv-SrlJkuG929U2wv4Vc-rE4kxx0");
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Бот успешно запущен.\n");
            NumberConsoleMessage++;
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();

        }

        public void UpdatePanel()
        {
            controlPanel.Controls.Clear();
            categories = ChanelsRepository.Read();
            foreach (var category in categories)
            {
                controlPanel.Controls.Add(new Button { Text = category.Name, Size = new Size(300, 50) });
            }
            controlPanel.Controls.Add(new AddButton(this));
        }
        public void UpdateChannelsPanel()
        {
            chanellsPanel.Controls.Clear();
            chanels = CategoriesRepository.Read();
            foreach (var chanel in chanels)
            {
                chanellsPanel.Controls.Add(new Button { Text = chanel., Size = new Size(300, 50) });
            }
            chanellsPanel.Controls.Add(new AddButton(this));
        }
        public static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text == "/start")
            {
                botClient.SendTextMessageAsync(e.Message.Chat.Id, "Bot started.Hello.");
                ids = e.Message.Chat.Id;
                UserRepository.UserIds(ids);
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            botClient.SendTextMessageAsync(id, message, Telegram.Bot.Types.Enums.ParseMode.Markdown);
            textBox1.Text = null;
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Сообщение успешно отправлено.\n");
            NumberConsoleMessage++;
        }

        private void button3_Click(object sender, EventArgs e)  // картинка по ссылке
        {
            botClient.SendPhotoAsync(id, url, "Картинка.", Telegram.Bot.Types.Enums.ParseMode.Markdown);
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Картиинка успешно отправлена.\n");
            NumberConsoleMessage++;
            textBox3.Text = null;
        }

        // снизу кнопки отвечающие за формат текста
        
        public string textformat = null;
         
        

        private void button4_Click(object sender, EventArgs e)  // code текст
        {
            StringBuilder s = new StringBuilder(textBox1.Text);
            s.Insert(textBox1.SelectionStart, '`');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength + 1, '`');
            textBox1.Text = s.ToString();
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Выделенный текст успешно изменен на code.\n");
            NumberConsoleMessage++;
        }

        private void button6_Click(object sender, EventArgs e) // жирный текст
        {

            StringBuilder s = new StringBuilder(textBox1.Text);
            s.Insert(textBox1.SelectionStart, '*');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength +1 , '*');
            textBox1.Text = s.ToString();
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Выделенный текст успешно изменен на жирный.\n");
            NumberConsoleMessage++;
        }

        private void button5_Click(object sender, EventArgs e) // наклонный текст
        {

            StringBuilder s = new StringBuilder(textBox1.Text);
            s.Insert(textBox1.SelectionStart, '_');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength + 1, '_');
            textBox1.Text = s.ToString();
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Выделенный текст успешно изменен на наклонный.\n");
            NumberConsoleMessage++;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            url2 = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            text = textBox6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            botClient.SendTextMessageAsync(id, "<a href = \"http://www.example.com/\" >inline URL</a>", Telegram.Bot.Types.Enums.ParseMode.Html);
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