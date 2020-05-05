using System.Windows.Forms;

namespace GuiCalculator
{
    public partial class Calculator : Form
    {
        private double accumulator = 0;
        private string lastOperation;
        private Button button0 = new Button();
        private Button button1 = new Button();
        private Button button2 = new Button();
        private Button button3 = new Button();
        private Button button4 = new Button();
        private Button button5 = new Button();
        private Button button6 = new Button();
        private Button button7 = new Button();
        private Button button8 = new Button();
        private Button button9 = new Button();
        private Button add = new Button();
        private Button substract = new Button();
        private Button multiply = new Button();
        private Button divide = new Button();
        private Button dec = new Button();
        private Button zero = new Button();
        private Button total = new Button();
        private TextBox results = new TextBox();
        public Calculator()
        {
            InitializeComponent();
        }
    }
}
