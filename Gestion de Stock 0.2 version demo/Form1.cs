using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           loadForm(new HomeScreenForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadForm(new OrdersForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new NewItemForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            loadForm(new HomeScreenForm());

            MessageBox.Show("votre logiciel est en mode démonstration \n" +
                            "la version est limmité : \n" +
                            "- 10 Produits \n" +
                            "- 5 Clients \n" +
                            "- 10 Ventes \n", "Information");
            timer1.Start();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        int i = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            i++;
            //
            if (i == 60)
            {
                // TODO: This line of code loads data into the 'itemsDBv3DataSetV2.ItemsV3' table. You can move, or remove it, as needed.
                this.itemsV3TableAdapter.Fill(this.itemsDBv3DataSet.ItemsV3);

                // TODO: This line of code loads data into the 'salesDBv1DataSet.SalesV1' table. You can move, or remove it, as needed.
                this.salesV2TableAdapter.Fill(this.salesDBv2DataSet.SalesV2);

                // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
                this.clientsV1TableAdapter.Fill(this.clientsDBv1DataSet.ClientsV1);
                Console.WriteLine("bdd chargees " + i);
                i = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new ClientsForm());
        }
    }
}
