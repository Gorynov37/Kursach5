using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachApp
{
    public partial class Form1 : Form
    {
        KursachLib.List list = null;
        string data = string.Empty;
        public Form1()
        {
            InitializeComponent();
            list = new KursachLib.List<int>();
        }

        private void randomInitButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(countTextBox.Text))
            {
                MessageBox.Show("Введите кол-во элементов");
            }
            else
            {
                int n = Convert.ToInt32(countTextBox.Text);
                data = KursachLib.Utilites.RandomInit(n,list);
                textBoxData.Text = data;
            }
        }


        private void radioButtonINT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonINT.Checked) list = new KursachLib.List<int>(); ;
        }

        private void radioButtonDOUBLE_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDOUBLE.Checked) list = new KursachLib.List<double>();
        }

        private void radioButtonSTRING_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSTRING.Checked) list = new KursachLib.List<string>();
        }

        private void sortBbutton_Click(object sender, EventArgs e)
        {
            data = textBoxData.Text;
            Form form2 = new SortForm(list, data);
            form2.ShowDialog();
        }
    }
}
