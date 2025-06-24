using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RozpocznijGre();
        }
        private string haslo = "PROGRAMOWANIE";
        private char[] ukryteHaslo;
        private int zycia = 10;
        private HashSet<char> uzyteLitery = new HashSet<char>();
        private List<char> bledneLitery = new List<char>();
        private void RozpocznijGre()
        {
            ukryteHaslo = new string('_', haslo.Length).ToCharArray();
            lblHaslo.Text = string.Join(" ", ukryteHaslo);
            lblZycia.Text = $"Życia: {zycia}";
            lblInfo.Text = "";
            lblBledy.Text = "Złe litery:";
            lblKoniecGry.Text = "";
            uzyteLitery.Clear();
            bledneLitery.Clear();
            btnSprawdz.Enabled = true;
            txtLitera.Clear();
            txtLitera.Focus();
        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            string input = txtLitera.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]))
            {
                lblInfo.Text = "Wprowadź jedną literę!";
                return;
            }

            char litera = input[0];

            if (uzyteLitery.Contains(litera))
            {
                lblInfo.Text = $"Litera '{litera}' już była!";
                txtLitera.Clear();
                txtLitera.Focus();
                return;
            }

            uzyteLitery.Add(litera);
            bool trafiona = false;

            for (int i = 0; i < haslo.Length; i++)
            {
                if (haslo[i] == litera)
                {
                    ukryteHaslo[i] = litera;
                    trafiona = true;
                }
            }

            if (!trafiona)
            {
                zycia--;
                bledneLitery.Add(litera);
                lblZycia.Text = $"Życia: {zycia}";
                lblInfo.Text = $"Zła litera: {litera}";
                lblBledy.Text = $"Złe litery: {string.Join(" ", bledneLitery)}";
            }
            else
            {
                lblHaslo.Text = string.Join(" ", ukryteHaslo);
                lblInfo.Text = $"Dobra litera: {litera}";
            }

            if (!ukryteHaslo.Contains('_'))
            {
                lblKoniecGry.Text = "🎉 WYGRAŁEŚ! 🎉\nHasło: " + haslo;
                lblKoniecGry.ForeColor = System.Drawing.Color.Green;
                btnSprawdz.Enabled = false;
            }
            else if (zycia == 0)
            {
                lblKoniecGry.Text = "❌ PRZEGRAŁEŚ ❌\nHasło to: " + haslo;
                lblKoniecGry.ForeColor = System.Drawing.Color.Red;
                lblHaslo.Text = string.Join(" ", haslo.ToCharArray());
                btnSprawdz.Enabled = false;
            }

            txtLitera.Clear();
            txtLitera.Focus();
        }

        private void lblKoniecGry_Click(object sender, EventArgs e)
        {

        }

        private void lblHaslo_Click(object sender, EventArgs e)
        {

        }
    }
}