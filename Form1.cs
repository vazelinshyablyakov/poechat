using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace poechat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string result = "";

        private void printButton_Click(object sender, EventArgs e)
        {
            result = "Строка 1\n\n";

            result += "Строка 2\nСтрока3";

            PrintDocument PrintDocument = new PrintDocument();

            PrintDocument.PrintPage += PrintPageHandler;


            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = PrintDocument;


            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
