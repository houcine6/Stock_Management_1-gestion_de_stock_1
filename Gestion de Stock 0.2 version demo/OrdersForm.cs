using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Stock
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void itemsV3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsV3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemsDBv3DataSet);

        }
        DateTime from = DateTime.Today;
        DateTime tod = DateTime.Today;
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDBv2DataSet.SalesV2' table. You can move, or remove it, as needed.
            this.salesV2TableAdapter.Fill(this.salesDBv2DataSet.SalesV2);
            // TODO: This line of code loads data into the 'itemsDBv3DataSetV2.ItemsV3' table. You can move, or remove it, as needed.
            this.itemsV3TableAdapter.Fill(this.itemsDBv3DataSet.ItemsV3);

            timer1.Start();

            /*panel3.SendToBack();
            panel3.Hide();*/
            panel5.SendToBack();
            panel5.Hide();

            DateTime day = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker1.Value = day;

            dateTimePicker2.Value = dateTimePicker2.MinDate;
            dateTimePicker2.Value = day;
        }


        
        Double TP = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            itemsV3BindingSource.Filter = string.Format("Nom LIKE '%" + textBox2.Text + "%'");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView2.Visible = true;
            button3.Enabled = true;
            button7.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            button6.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label11.Visible = true;


            itemsV3DataGridView.Visible = false;
            dataGridView1.Visible = false;
            panel3.Visible = false;
            textBox1.Visible = false;
            textBox5.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            nameLabel.Visible = false;
            quantityLabel.Visible = false;
            label3.Visible = false;
            label15.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView2.Visible = false; 
            button3.Enabled = false;
            button7.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            button6.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            itemsV3DataGridView.Visible = true;
            dataGridView1.Visible = true;
            panel3.Visible = true;
            textBox1.Visible = true;
            textBox5.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            nameLabel.Visible = true;
            quantityLabel.Visible = true;
            label3.Visible = true;
            label15.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
             /* int leng = dataGridView2.Rows.Count - 1;

            for (int i = 0; i < leng; i++)
             {
                dataGridView2.Rows[i].Selected = true;

             }

             foreach (DataGridViewRow row in dataGridView2.SelectedRows)
             {
                dataGridView2.Rows.RemoveAt(row.Index);
             }

             this.Validate();
             this.salesV2BindingSource.EndEdit();
             this.tableAdapterManager1.UpdateAll(this.salesDBv2DataSet);*/
        }

        String day = DateTime.Now.ToString("d");
        double TI = 0;
        String q, pll;
        double q2;
        Double Mont = 0;
        //int i = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //quantity
                q = textBox1.Text;
                q2 = Convert.ToDouble(q);

                if (q2 > qq || q2 == 0)
                {
                    MessageBox.Show("Il n'y a pas assez ", "Erreur");
                }
                else
                {
                    if (textBox5.Text != "")
                    {
                        if (c <= 10)
                        {
                            pll = textBox5.Text;
                            pp = Convert.ToDouble(String.Format("{0:0.00}", pll));

                            Mont = (pp * q2);
                            TP = TP + (pp * q2);

                            double rest;

                            rest = qq - q2;
                            Console.WriteLine("rest " + rest);
                            itemsV3DataGridView.CurrentRow.Cells[1].Value = rest;

                            TI = TI + q2;

                            label7.Text = "" + TP;

                            dataGridView1.Rows.Add(n, q, pp, Mont);

                            day = Convert.ToDateTime(day).ToString("dd/MM/yyyy");

                            this.salesV2BindingSource.AddNew();


                            nomTextBox.Text = n;
                            quantitéTextBox.Text = q;
                            prixTextBox.Text = pp.ToString();
                            dateTextBox.Text = day;

                            this.Validate();
                            this.salesV2BindingSource.EndEdit();
                            this.tableAdapterManager1.UpdateAll(this.salesDBv2DataSet);

                            this.Validate();
                            this.itemsV3BindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.itemsDBv3DataSet);

                            itemsV3DataGridView.CurrentRow.Selected = false;
                            textBox1.Text = "";
                            textBox5.Text = "";

                            quantity = Convert.ToString(q);
                            price = Convert.ToString(pp);
                            mon = Convert.ToString(Mont);

                            printList.Add(n);
                            printList.Add(quantity);
                            printList.Add(price);
                            printList.Add(mon);

                            n = "";
                            qq = 0;
                            pp = 0;
                            Mont = 0;
                        }
                        else if (c > 10)
                        {
                            MessageBox.Show("votre logiciel est en mode démonstration \n" +
                               "la version est limmité : \n" +
                               "- 10 Ventes \n", "Information");
                        }
                    }
                }
            }
            else
            {

            }
        }

         String quantity, price, mon;
         List<string> printList = new List<string>();

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = "0";
            textBox1.Text = "";
            textBox5.Text = "";
            TP = 0;
            TI = 0;
            dataGridView1.Rows.Clear();
            printList.Clear();

            n = "";
            qq = 0;
            pp = 0;
            Mont = 0;
        }

        String Q, pl, n;
        double qq;
        double pp;

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    itemsV3BindingSource.Filter = string.Format("Nom LIKE '%" + textBox2.Text + "%'");
                }
                else
                {
                    itemsV3BindingSource.Filter = string.Empty;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        int c;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            c = dataGridView2.Rows.Count;
            c = c - 1;

            //Console.WriteLine("c = " + c);
        }

        Double tp2 = 0;
        private void button6_Click_1(object sender, EventArgs e)
        {
            tp2 = 0;
            label11.Text = "" + tp2;

            from = dateTimePicker1.Value;
            tod = dateTimePicker2.Value;

            Console.WriteLine("f " + from);
            Console.WriteLine("to " + tod);

            int leng = dataGridView2.Rows.Count - 1;

            for (int i = 0; i < leng; i++)
            {
                dataGridView2.Rows[i].Selected = true;

                //String dateCompare = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                String dateCompare = dataGridView2.Rows[i].Cells[4].Value.ToString();
                DateTime dc = DateTime.Parse(dateCompare);

                dataGridView2.Rows[i].Selected = false;
                
                if (dateTimePicker1.Value <=  dc && dateTimePicker2.Value >= dc)
                {
                    Console.WriteLine("w " + dataGridView2.Rows[i].Cells[0].Value.ToString());

                    String price2 = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    double price = Convert.ToDouble(String.Format("{0:0.00}", price2));

                    string quantity2 = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    double quantity = Convert.ToDouble(String.Format("{0:0.00}", quantity2));

                    Console.WriteLine("p"+ price);
                    Console.WriteLine("q" + quantity);

                    double montant = price * quantity;
                    Console.WriteLine("m = " + montant);

                    tp2 = tp2 + montant;
                    Console.WriteLine("m = " + tp2);
                    label11.Text = ""+ tp2;
                    montant = 0;
                    
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void itemsV3DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (itemsV3DataGridView.CurrentRow.Cells[0].Value.ToString() != "" && itemsV3DataGridView.CurrentRow.Cells[3].Value.ToString() != "" && itemsV3DataGridView.CurrentRow.Cells[1].Value.ToString() != "")
            {
                itemsV3DataGridView.CurrentRow.Selected = true;

                n = itemsV3DataGridView.CurrentRow.Cells[0].Value.ToString();

                pl = itemsV3DataGridView.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = pl;
                pp = Convert.ToDouble(String.Format("{0:0.00}", pl));

                Q = itemsV3DataGridView.CurrentRow.Cells[1].Value.ToString();
                qq = Convert.ToDouble(Q);
                
            }
            else
            {

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*printPreviewDialog1.Document = printDocument1;

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

            printPreviewDialog1.ShowDialog();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }
    }

    
}
