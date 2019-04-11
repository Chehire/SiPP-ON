using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1) Opacity += 0.1;
            else timer1.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath gr = new GraphicsPath();//Создаем Регион
            this.BackColor = Color.Aqua;//Цвет
            gr.AddString("Жизнь слишком коротка,", Font.FontFamily, 2, 32, new Point(10, 10), StringFormat.GenericDefault);//Добавление текста
            gr.AddString("начинайте с десерта", Font.FontFamily, 2, 32, new Point(10, 42), StringFormat.GenericDefault);
            Rectangle rct = new Rectangle(130, 152, 250, 155);//Создание прямогоугльника
            gr.AddRectangle(rct);//Рисование прямоугольника
            gr.AddLine(130, 152, 194, 102);//Рисуем линию
            gr.AddLine(194, 102, 380, 152);
            gr.AddLine(380, 152, 130, 152);
            Rectangle rct1 = new Rectangle(135, 152, 240, 3);//Создание прямогоугльника
            gr.AddRectangle(rct1);//Рисование прямоугольника
            Rectangle rct2 = new Rectangle(135, 217, 240, 35);//Создание прямогоугльника
            gr.AddRectangle(rct2);//Рисование прямоугольника
            gr.AddEllipse(25, 265, 490, 70);//Рисуем круг
            gr.AddEllipse(20, 260, 500, 80); 
            Region r = new Region(gr);
            this.Region = r;//Отображение именно этого региона
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
 
        }
    }
}
