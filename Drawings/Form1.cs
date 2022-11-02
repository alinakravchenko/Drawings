namespace Drawings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pn = new Pen(Brushes.DarkBlue, 5); //цвет, толщина линии
            Rectangle rect = new Rectangle(370, 340, 60, 60);
            e.Graphics.DrawEllipse(pn, rect);
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 400), new Point(400, 500));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(360, 460));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(440, 460));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(360, 540));
            graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(440, 540));
           //graphics.DrawLine(new Pen(Brushes.Red, 5), new Point(440, 430), new Point(440, 490));
            graphics.DrawEllipse(new Pen(Brushes.Blue, 4), 430, 410, 20, 20);
            graphics.DrawLine(new Pen(Brushes.Blue, 4), new Point(440, 430), new Point(440, 490));
            //graphics.DrawEllipse(new Pen(Brushes.Blue, 4), 430, 420, 20, 20);
            graphics.DrawEllipse(new Pen(Brushes.Blue, 3), 426, 405, 8, 8);
            graphics.DrawEllipse(new Pen(Brushes.Blue, 3), 437, 400, 8, 8);
            graphics.DrawEllipse(new Pen(Brushes.Blue, 3), 423, 420, 8, 8);
            graphics.DrawEllipse(new Pen(Brushes.Blue, 3), 448, 420, 8, 8);
            graphics.DrawEllipse(new Pen(Brushes.Blue, 3), 444, 405, 8, 8);
            graphics.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(320, 310, 40, 40), 0, 180);
            graphics.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(280, 300, 40, 40), 30, 180);
            graphics.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(280, 280, 40, 40), 144, 180);
            graphics.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(310, 280, 40, 40), 216, 135);
            graphics.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(330, 295, 40, 40), 270, 150);


        }
    }
}