using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozilaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int motociklCount = 0;
        private int automobilCount = 0;
        private int kamionCount = 0;
        private object errorProvider1;

        private void btnUnesi_Click(object sender, EventArgs e)
        {

            string model = txtModel.Text;
            int GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text);
            int BrojKotaca = int.Parse(txtBrojKotaca.Text);

            string kategorija = GetKategorija(BrojKotaca);

           
            switch (kategorija)
            {
                case "Motocikl":
                    motociklCount++;
                    break;
                case "Automobil":
                    automobilCount++;
                    break;
                case "Kamion":
                    kamionCount++;
                    break;
            }

           
            btnIspis.Text = $"Model: {model}, Godina proizvodnje: {GodinaProizvodnje}, Broj kotača: {BrojKotaca}, Kategorija: {kategorija}" +
                Environment.NewLine +
                $"Motocikl: {motociklCount}, Automobil: {automobilCount}, Kamion: {kamionCount}";
        }

        private string GetKategorija(int brojKotaca)
        {
            if (brojKotaca == 2)
            {
                return "Motocikl";
            }
            else if (brojKotaca == 4)
            {
                return "Automobil";
            }
            else
            {
                return "Kamion";
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            
            txtModel.Text = "";
            txtGodinaProizvodnje.Text = "";
            txtBrojKotaca.Text = "";
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {

            btnIspis.Text = $"Motocikl: {motociklCount}, Automobil: {automobilCount}, Kamion: {kamionCount}";

        }

        private void txtGodinaProizvodnje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
