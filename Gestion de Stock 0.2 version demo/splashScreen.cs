using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Stock
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        int iBDD = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            iBDD++;

            if (iBDD == 1)
            {
                try
                {
                    // TODO: This line of code loads data into the 'itemsDBv3DataSetV2.ItemsV3' table. You can move, or remove it, as needed.
                    this.itemsV3TableAdapter.Fill(this.itemsDBv3DataSet.ItemsV3);
                    progressBar1.Increment(30);
                    Console.WriteLine("Bdd1 charge");
                }
                catch (Exception eBDD)
                {
                    timer1.Enabled = false;
                    if (MessageBox.Show("Une Base de Données n'a pas été chargé correctement, Veuillez Redémarrer le Logiciel", "Erreur", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            if (iBDD == 2)
            {
                try
                {
                    // TODO: This line of code loads data into the 'salesDBv1DataSet.SalesV1' table. You can move, or remove it, as needed.
                    this.salesV2TableAdapter.Fill(this.salesDBv2DataSet.SalesV2);
                    progressBar1.Increment(30);
                    Console.WriteLine("Bdd2 charge");
                }
                catch (Exception eBDD)
                {
                    timer1.Enabled = false;
                    if (MessageBox.Show("Une Base de Données n'a pas été chargé correctement, Veuillez Redémarrer le Logiciel", "Erreur", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            if (iBDD == 3)
            {
                try
                {
                    // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
                    this.clientsV1TableAdapter.Fill(this.clientsDBv1DataSet.ClientsV1);
                    progressBar1.Increment(40);
                    Console.WriteLine("Bdd3 charge");
                }
                catch (Exception eBDD)
                {
                    timer1.Enabled = false;
                    if (MessageBox.Show("Une Base de Données n'a pas été chargé correctement, Veuillez Redémarrer le Logiciel", "Erreur", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            

            if (progressBar1.Value == 100)
            {
                label2.Text = "Chargement Complet";
                if (iBDD == 6)
                {
                    timer1.Enabled = false;
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
