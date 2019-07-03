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
        public static string id;
        public static long ids;
        string mesage;
        public static TelegramBotClient botClient;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < categories.Count; i++)
            {
                None.Items.Add(categories[i].Name);
            }
            categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("categoryes.json")) ?? new List<Category>();
            botClient = new TelegramBotClient("794414690:AAG2dr2Nv-SrlJkuG929U2wv4Vc-rE4kxx0");
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Бот успешно запущен.\n");
            NumberConsoleMessage++;
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
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            botClient.SendTextMessageAsync(id, message, Telegram.Bot.Types.Enums.ParseMode.Markdown);

            button5.BackColor = Color.White;
            button4.BackColor = Color.White;
            button6.BackColor = Color.White;
            textBox1.Text = null;
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Сообщение успешно отправлено.\n");
            NumberConsoleMessage++;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string url;
        private void button3_Click(object sender, EventArgs e)  // картинка по ссылке
        {
            botClient.SendPhotoAsync(id, url, "Картинка.", Telegram.Bot.Types.Enums.ParseMode.Markdown);
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Картиинка успешно отправлена.\n");
            NumberConsoleMessage++;
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
        // снизу кнопки отвечающие за формат текста
        
        public string textformat = null;
         
        

        private void button4_Click(object sender, EventArgs e)  // code текст
        {
            button4.BackColor = Color.Green;
            button6.BackColor = Color.White;
            button5.BackColor = Color.White;
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

            button6.BackColor = Color.Green;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
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
            button5.BackColor = Color.Green;
            button4.BackColor = Color.White;
            button6.BackColor = Color.White;
            StringBuilder s = new StringBuilder(textBox1.Text);
            s.Insert(textBox1.SelectionStart, '_');
            s.Insert(textBox1.SelectionStart + textBox1.SelectionLength + 1, '_');
            textBox1.Text = s.ToString();
            mesage = textBox1.Text;
            ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Выделенный текст успешно изменен на наклонный.\n");
            NumberConsoleMessage++;
        }
        public string text;
        public string url2;
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
            botClient.SendTextMessageAsync(id, $"< a href =\"http://example.com/url\">текст ссылки</a>", Telegram.Bot.Types.Enums.ParseMode.Html);
        }
        //

        
        private void AddCategory_Click(object sender, EventArgs e)
        {
           
            
            var nameCategory = CategoryName.Text;
            None.Items.Add(nameCategory);
            Category category = new Category(nameCategory);
            CategoryName.Text = null;
            
            if (File.Exists("categoryes.json"))
            {
                var s = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("categoryes.json")) ?? new List<Category>();
                ConsoleRichTextBox.AppendText($"{NumberConsoleMessage}.Категория успешно добавлена.\n");
                s.Add(category);
                categories.Add(category);
                File.WriteAllText("categoryes.json", JsonConvert.SerializeObject(s));
            }
            else
            {
                File.Create("categoryes.json");
            }
          

        }

        List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("categoryes.json")) ?? new List<Category>();


        private void ActiveCategory_TextChanged(object sender, EventArgs e)
        {
        }

        private void ChanellName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddChanells_Click(object sender, EventArgs e)
        {
            var NameChanel = ChanellName.Text;
            Chanel chanel = new Chanel(NameChanel);
            var score = None.SelectedIndex;
            //categories[score]Chanels.Add(chanel);
           
            File.WriteAllText("categoryes.json", JsonConvert.SerializeObject(categories));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}