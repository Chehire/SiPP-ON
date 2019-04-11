using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Zastavka2 : Form
    {
        public Zastavka2()
        {
            InitializeComponent();
        }

        private void Zastavka2_Load(object sender, EventArgs e)
        {
            AllowTransparency = true;// Позволяе сделать фон формы прозрачным
                TransparencyKey = Color.White;// Указывает какой цвет
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1) Opacity += 0.1;//Прозрачность
            else
            {
                timer1.Enabled = false;//Выключам таймер
                Form1 Fr = new Form1();
                Fr.Show();//Переход на новую форму
                Hide();//Скрытие старой
            }

        }
    }
}
