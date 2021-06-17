using System;
using System.Windows.Forms;

namespace KursachApp
{
    public partial class SortForm : Form
    {
        KursachLib.List list;
        KursachLib.List listSelSort;
        KursachLib.List listQSort;
        public SortForm(KursachLib.List _list, string data)
        {
            InitializeComponent();
            list = _list;
            textBox.Text = data;

            list = KursachLib.Utilites.InputList(textBox, list);
            listSelSort = list.Copy();
            listQSort = list.Copy();
        }

        private void selSortButton_Click(object sender, EventArgs e)
        {
            KursachLib.SortClass sortClass = new KursachLib.SelectionSort();

            listSelSort.Sort(sortClass);
            KursachLib.Utilites.Output(listSelSort, selSortTextBox);

            compSS.Text = sortClass.comparisons.ToString();
            transpSS.Text = sortClass.transpositions.ToString();
        }

        private void qSortButton_Click(object sender, EventArgs e)
        {
            KursachLib.SortClass sortClass = new KursachLib.QuickSort();

            listQSort.Sort(sortClass);
            KursachLib.Utilites.Output(listQSort, qSortTextBox);

            compQS.Text = sortClass.comparisons.ToString();
            transpQS.Text = sortClass.transpositions.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
