using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBall
{
   
    public partial class Form1 : Form
    {
        public string GetAnswer(TextBox text)
        {
            Random rnd = new Random();
            //Выбираем ответ
            int answer_number = rnd.Next(1, 6);
            // Логика ответа
            // Сколько, где, когда, зачем, почему, как, обобщающий вопрос
            string newtext = text.Text.ToLower();
            string[] words = newtext.Split(new char[] { ' ' });

            if (words.Contains("сколько"))
            {
                switch (answer_number)
                {
                    case 1:
                        return "Большое количество";
                    case 2:
                        return "Совсем немного";
                    case 3:
                        return "Мало";
                    case 4:
                        return "Нисколько";
                    case 5:
                        return "Огромное количество";
                    case 6:
                        return "Много";
                }
            }
            else if (words.Contains("где"))
            {
                switch (answer_number)
                {
                    case 1:
                        return "Нигде";
                    case 2:
                        return "В далеких землях";
                    case 3:
                        return "Близко";
                    case 4:
                        return "Совсем рядом";
                    case 5:
                        return "Под землей";
                    case 6:
                        return "Выше облаков";
                }
            }
            else if (words.Contains("когда"))
            {
                switch (answer_number)
                {
                    case 1:
                        return "Скоро";
                    case 2:
                        return "Никогда";
                    case 3:
                        return "Завтра";
                    case 4:
                        return "В ближайшее время";
                    case 5:
                        return "Нескоро";
                    case 6:
                        return "Совсем скоро";
                }
            }
            else if (words.Contains("зачем"))
            {
                switch (answer_number)
                {
                    case 1:
                        return "Затем";
                    case 2:
                        return "Просто так";
                    case 3:
                        return "Такая судьба";
                    case 4:
                        return "Так получилось";
                    case 5:
                        return "За мясом :)";
                    case 6:
                        return "Так надо";
                }
            }
            else if (words.Contains("почему"))
            {
                switch (answer_number)
                {
                    case 1:
                        return "Потому";
                    case 2:
                        return "Покачану";
                    case 3:
                        return "Так надо";
                    case 4:
                        return "Это было неправильно";
                    case 5:
                        return "Это было правильно";
                    case 6:
                        return "Это важно";
                }
            }
            else if (words.Contains("как"))
            {
                switch (answer_number)
                {
                    case 1:
                        return "Отлично";
                    case 2:
                        return "Нелегко";
                    case 3:
                        return "Вот так";
                    case 4:
                        return "Сложно";
                    case 5:
                        return "Непросто";
                    case 6:
                        return "Легко";
                }
            }
            else
            {
                switch (answer_number)
                {
                    case 1:
                        return "Сложный вопрос";
                    case 2:
                        return "Надо подумать";
                    case 3:
                        return "Да";
                    case 4:
                        return "Нет";
                    case 5:
                        return "Скорее да";
                    case 6:
                        return "Скорее нет";
                }
            }
            

            return "s";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = GetAnswer(textBox1);
        }
    }
}
