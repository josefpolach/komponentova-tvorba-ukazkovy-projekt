using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videopujcovna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            zakaznici.DataSource = Databaze.Zakaznici;
            sklad.DataSource = Databaze.Sklad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Databaze.Sklad.Count() > 0)
            {
                Databaze.Zakaznici[zakaznici.CurrentCell.RowIndex].Polozky.Add(Databaze.Sklad[sklad.CurrentCell.RowIndex]);
                Databaze.Sklad.RemoveAt(sklad.CurrentCell.RowIndex);
            }
        }

        private void zakaznici_SelectionChanged(object sender, EventArgs e)
        {
            polozky.DataSource = Databaze.Zakaznici[zakaznici.CurrentCell.RowIndex].Polozky;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Databaze.Zakaznici[zakaznici.CurrentCell.RowIndex].Polozky.Count() > 0)
            {
                Databaze.Sklad.Add(Databaze.Zakaznici[zakaznici.CurrentCell.RowIndex].Polozky[polozky.CurrentCell.RowIndex]);
                Databaze.Zakaznici[zakaznici.CurrentCell.RowIndex].Polozky.RemoveAt(polozky.CurrentCell.RowIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
