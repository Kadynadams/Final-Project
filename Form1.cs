namespace Final_Project
{
    public partial class Form1 : Form
    {
        Pen drawPen = new Pen(Color.Black,4);
        Image adventureguys = Properties.Resources.adventure_phoyo;
        //initial location of my hero (Han Solo)
        Rectangle hero = new Rectangle(150, 100, 70,70);
        //make booleans for movement
        Boolean wPressed = false;
        Boolean sPressed = false;
        Boolean aPressed = false;
        Boolean dPressed = false;
        //size of Han Solo’s Steps
        int stepSize = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)

        {

            Graphics g = e.Graphics;
            g.DrawLine(drawPen, 50, 50, 150, 50);
            g.DrawLine(drawPen, 50, 50, 50, 200);
            g.DrawLine(drawPen, 100, 150, 100, 100);
            g.DrawLine(drawPen, 50, 150, 150, 150);
            g.DrawLine(drawPen, 50,400, 400, 400);
            g.DrawLine(drawPen, 50, 400, 50, 300);
            g.DrawLine(drawPen, 100, 300, 50, 300);
            g.DrawLine(drawPen, 100, 300, 100, 250);
            g.DrawLine(drawPen, 400, 50, 400,400);
            g.DrawLine(drawPen, 300, 50, 400, 50);
            g.DrawLine(drawPen, 300, 50, 250, 50);
            g.DrawLine(drawPen,400, 200,250, 200);
            g.DrawLine(drawPen, 250, 100,250, 200);
            g.DrawLine(drawPen,150, 100,150,350);
            g.DrawImage(adventureguys, hero);











        }
    }
}
