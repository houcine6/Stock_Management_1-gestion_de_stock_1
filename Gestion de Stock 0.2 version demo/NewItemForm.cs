using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Stock
{
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            itemsV3BindingSource.Filter = string.Format("Nom LIKE '%" + textBox1.Text + "%'");

        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsDBv3DataSet.ItemsV3' table. You can move, or remove it, as needed.
            this.itemsV3TableAdapter.Fill(this.itemsDBv3DataSet.ItemsV3);
            timer1.Start();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomTextBox.Enabled = true;
            quantitéTextBox.Enabled = true;
            prix_d_achatTextBox.Enabled = true;
            prix_de_VenteTextBox.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in itemsV3DataGridView.SelectedRows)
            {
                itemsV3DataGridView.Rows.RemoveAt(row.Index);
            }

            this.Validate();
            this.itemsV3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemsDBv3DataSet);

            MessageBox.Show("Données enregistrées avec succés", "Enregistré");
        }

        private void productsV1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nomTextBox.Text != "" && prix_de_VenteTextBox.Text != "" && quantitéTextBox.Text != "")
            {
                if(c <= 10)
                {
                    this.Validate();
                    this.itemsV3BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.itemsDBv3DataSet);

                    MessageBox.Show("Données enregistrées avec succés", "Enregistré");
                }else if(c > 10)
                {
                    MessageBox.Show("votre logiciel est en mode démonstration \n" +
                            "la version est limmité : \n" +
                            "- 10 Produits \n", "Information");
                }
            }
            else
            {
                MessageBox.Show("Un champ important est vide", "Erreur");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        int c;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            nomTextBox.MaxLength = 55;
            quantitéTextBox.MaxLength = 10;
            prix_de_VenteTextBox.MaxLength = 15;
            prix_d_achatTextBox.MaxLength = 15;

            c = itemsV3DataGridView.Rows.Count;
            c = c - 1;
            label4.Text = "" + c + "";
        }

        private void quantitéTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void prix_d_achatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    itemsV3BindingSource.Filter = string.Format("Nom LIKE '%" + textBox1.Text + "%'");
                }
                else
                {
                    itemsV3BindingSource.Filter = string.Empty;
                }
            }
        }

        private void itemsV3DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemsV3DataGridView.CurrentRow.Selected = true;

            nomTextBox.Enabled = true;
            quantitéTextBox.Enabled = true;
            prix_d_achatTextBox.Enabled = true;
            prix_de_VenteTextBox.Enabled = true;
        }

        private void prix_de_VenteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
