using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Stock
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
            this.clientsV1TableAdapter.Fill(this.clientsDBv1DataSet.ClientsV1);

            timer1.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        DateTime day = DateTime.Today;
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomTextBox.Enabled = true;
            quantitéTextBox.Enabled = true;
            prix_d_achatTextBox.Enabled = true;
            prix_de_VenteTextBox.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;

            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker1.Value = day;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in itemsV3DataGridView.SelectedRows)
            {
                itemsV3DataGridView.Rows.RemoveAt(row.Index);
            }

            this.Validate();
            this.clientsV1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientsDBv1DataSet);

            MessageBox.Show("Données enregistrées avec succés", "Enregistré");
        }

        private void productsV1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nomTextBox.Text != "")
            {
                if(c <= 5)
                {
                    this.Validate();
                    this.clientsV1BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.clientsDBv1DataSet);

                    MessageBox.Show("Données enregistrées avec succés", "Enregistré");
                }else if (c > 5)
                {
                    MessageBox.Show("votre logiciel est en mode démonstration \n" +
                            "la version est limmité : \n" +
                            "- 5 Clients \n", "Information");
                }
            }
            else
            {
                MessageBox.Show("Un champ important est vide", "Erreur");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            clientsV1BindingSource.Filter = string.Format("Nom LIKE '%" + textBox1.Text + "%'");

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    clientsV1BindingSource.Filter = string.Format("Nom LIKE '%" + textBox1.Text + "%'");
                }
                else
                {
                    clientsV1BindingSource.Filter = string.Empty;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        private void quantitéTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void prix_de_VenteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void itemsV3DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemsV3DataGridView.CurrentRow.Selected = true;

            nomTextBox.Enabled = true;
            quantitéTextBox.Enabled = true;
            prix_d_achatTextBox.Enabled = true;
            prix_de_VenteTextBox.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        int c;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            nomTextBox.MaxLength = 50;
            quantitéTextBox.MaxLength = 11;
            prix_de_VenteTextBox.MaxLength = 15;
            prix_d_achatTextBox.MaxLength = 50;
            textBox2.MaxLength = 50;

            c = itemsV3DataGridView.Rows.Count;
            c = c - 1;
            label4.Text = "" + c + "";
        }
    }
}
