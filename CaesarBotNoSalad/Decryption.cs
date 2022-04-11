using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarBotNoSalad
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string m = textBox1.Text;
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов
            int Enternumber = Convert.ToInt32(Enternumb2.Text);
            char[] massage = m.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 28) // Если j равно 26, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer - Enternumber; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 25)
                    {
                        d = d - 26;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            textBox2.Text = s; // Записываем результат в файл.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perexodnik perexodnik = new Perexodnik();
            perexodnik.Show();
            this.Hide();
        }
    }
    }

