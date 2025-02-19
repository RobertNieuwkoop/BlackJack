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
    public partial class BlackJackForm: Form
    {
        Class1 c = new Class1();
        public BlackJackForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
        }

        private void BlackJackForm_ResizeBegin(object sender, EventArgs e)
        {

        }
    }
}
