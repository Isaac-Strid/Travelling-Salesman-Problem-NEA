namespace Display
{
    public partial class Form1 : Form
    {

        private DBPanel displayGraph;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatrixGraph graph = new MatrixGraph();
            DisplayGraph();
            NearestNeighbour nearestNeighbour = new NearestNeighbour(graph);

        }

        private void DisplayGraph()
        {
            displayGraph = new DBPanel(); // uses double-buffered subclass, defined below, to avoid flicker on repaint
            displayGraph.Height = 350;
            displayGraph.Width = 180;
            displayGraph.Left = 550;
            displayGraph.Top = 50;
            displayGraph.BorderStyle = BorderStyle.None;
            displayGraph.Paint += new PaintEventHandler(Graph_Paint);
            this.Controls.Add(displayGraph);
        }

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;

            g = this.CreateGraphics();

            Brush blackBrush = new SolidBrush(Color.Black);

            e.Graphics.FillEllipse(blackBrush, 50, 60, 10, 10);
        }
    }
    public class DBPanel : Panel
    {
        public DBPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}