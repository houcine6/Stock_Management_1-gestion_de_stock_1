
namespace Gestion_de_Stock
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clientsV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDBv1DataSet = new Gestion_de_Stock.ClientsDBv1DataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.quantitéTextBox = new System.Windows.Forms.TextBox();
            this.prix_d_achatTextBox = new System.Windows.Forms.TextBox();
            this.prix_de_VenteTextBox = new System.Windows.Forms.TextBox();
            this.itemsV3DataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.téléphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomArticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.créditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemsV2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsV1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientsV1TableAdapter = new Gestion_de_Stock.ClientsDBv1DataSetTableAdapters.ClientsV1TableAdapter();
            this.tableAdapterManager = new Gestion_de_Stock.ClientsDBv1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV3DataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV2BindingNavigator)).BeginInit();
            this.itemsV2BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(70, 187);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(101, 17);
            label6.TabIndex = 36;
            label6.Text = "Nom Article :";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(287, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 17);
            label3.TabIndex = 24;
            label3.Text = "Rechercher :";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(378, 279);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(149, 17);
            label5.TabIndex = 33;
            label5.Text = "Totale des Clients :";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(70, 98);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(50, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nom :";
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(336, 98);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(95, 17);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Téléphone :";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(602, 98);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(77, 17);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Adresse :";
            priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(336, 187);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 17);
            label1.TabIndex = 46;
            label1.Text = "Date :";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(602, 187);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 17);
            label7.TabIndex = 47;
            label7.Text = "Crédit :";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.nomTextBox);
            this.panel1.Controls.Add(this.quantitéTextBox);
            this.panel1.Controls.Add(this.prix_d_achatTextBox);
            this.panel1.Controls.Add(this.prix_de_VenteTextBox);
            this.panel1.Controls.Add(this.itemsV3DataGridView);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.itemsV2BindingNavigator);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(quantityLabel);
            this.panel1.Controls.Add(priceLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 618);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsV1BindingSource, "Date", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 219);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(225, 35);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(225, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 35);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // clientsV1BindingSource
            // 
            this.clientsV1BindingSource.DataMember = "ClientsV1";
            this.clientsV1BindingSource.DataSource = this.clientsDBv1DataSet;
            // 
            // clientsDBv1DataSet
            // 
            this.clientsDBv1DataSet.DataSetName = "ClientsDBv1DataSet";
            this.clientsDBv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsV1BindingSource, "Nom Article", true));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(85, 219);
            this.textBox2.MaximumSize = new System.Drawing.Size(225, 35);
            this.textBox2.MinimumSize = new System.Drawing.Size(225, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 26);
            this.textBox2.TabIndex = 48;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsV1BindingSource, "Nom", true));
            this.nomTextBox.Enabled = false;
            this.nomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(85, 130);
            this.nomTextBox.MaximumSize = new System.Drawing.Size(225, 35);
            this.nomTextBox.MinimumSize = new System.Drawing.Size(225, 35);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(225, 26);
            this.nomTextBox.TabIndex = 39;
            // 
            // quantitéTextBox
            // 
            this.quantitéTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quantitéTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsV1BindingSource, "Téléphone", true));
            this.quantitéTextBox.Enabled = false;
            this.quantitéTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitéTextBox.Location = new System.Drawing.Point(351, 130);
            this.quantitéTextBox.MaximumSize = new System.Drawing.Size(225, 35);
            this.quantitéTextBox.MinimumSize = new System.Drawing.Size(225, 35);
            this.quantitéTextBox.Name = "quantitéTextBox";
            this.quantitéTextBox.Size = new System.Drawing.Size(225, 26);
            this.quantitéTextBox.TabIndex = 41;
            this.quantitéTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitéTextBox_KeyPress);
            // 
            // prix_d_achatTextBox
            // 
            this.prix_d_achatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prix_d_achatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsV1BindingSource, "Adresse", true));
            this.prix_d_achatTextBox.Enabled = false;
            this.prix_d_achatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_d_achatTextBox.Location = new System.Drawing.Point(614, 130);
            this.prix_d_achatTextBox.MaximumSize = new System.Drawing.Size(225, 35);
            this.prix_d_achatTextBox.MinimumSize = new System.Drawing.Size(225, 35);
            this.prix_d_achatTextBox.Name = "prix_d_achatTextBox";
            this.prix_d_achatTextBox.Size = new System.Drawing.Size(225, 26);
            this.prix_d_achatTextBox.TabIndex = 43;
            // 
            // prix_de_VenteTextBox
            // 
            this.prix_de_VenteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prix_de_VenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsV1BindingSource, "Crédit", true));
            this.prix_de_VenteTextBox.Enabled = false;
            this.prix_de_VenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_de_VenteTextBox.Location = new System.Drawing.Point(614, 219);
            this.prix_de_VenteTextBox.MaximumSize = new System.Drawing.Size(225, 35);
            this.prix_de_VenteTextBox.MinimumSize = new System.Drawing.Size(225, 35);
            this.prix_de_VenteTextBox.Name = "prix_de_VenteTextBox";
            this.prix_de_VenteTextBox.Size = new System.Drawing.Size(225, 26);
            this.prix_de_VenteTextBox.TabIndex = 45;
            this.prix_de_VenteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prix_de_VenteTextBox_KeyPress);
            // 
            // itemsV3DataGridView
            // 
            this.itemsV3DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.itemsV3DataGridView.AutoGenerateColumns = false;
            this.itemsV3DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.itemsV3DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsV3DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsV3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsV3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.téléphoneDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.nomArticleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.créditDataGridViewTextBoxColumn});
            this.itemsV3DataGridView.DataSource = this.clientsV1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsV3DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemsV3DataGridView.EnableHeadersVisualStyles = false;
            this.itemsV3DataGridView.GridColor = System.Drawing.Color.Black;
            this.itemsV3DataGridView.Location = new System.Drawing.Point(-22, 315);
            this.itemsV3DataGridView.Name = "itemsV3DataGridView";
            this.itemsV3DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsV3DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itemsV3DataGridView.RowTemplate.ReadOnly = true;
            this.itemsV3DataGridView.Size = new System.Drawing.Size(954, 291);
            this.itemsV3DataGridView.TabIndex = 36;
            this.itemsV3DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsV3DataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 130;
            // 
            // téléphoneDataGridViewTextBoxColumn
            // 
            this.téléphoneDataGridViewTextBoxColumn.DataPropertyName = "Téléphone";
            this.téléphoneDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.téléphoneDataGridViewTextBoxColumn.Name = "téléphoneDataGridViewTextBoxColumn";
            this.téléphoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 130;
            // 
            // nomArticleDataGridViewTextBoxColumn
            // 
            this.nomArticleDataGridViewTextBoxColumn.DataPropertyName = "Nom Article";
            this.nomArticleDataGridViewTextBoxColumn.HeaderText = "Nom Article";
            this.nomArticleDataGridViewTextBoxColumn.Name = "nomArticleDataGridViewTextBoxColumn";
            this.nomArticleDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 130;
            // 
            // créditDataGridViewTextBoxColumn
            // 
            this.créditDataGridViewTextBoxColumn.DataPropertyName = "Crédit";
            this.créditDataGridViewTextBoxColumn.HeaderText = "Crédit";
            this.créditDataGridViewTextBoxColumn.Name = "créditDataGridViewTextBoxColumn";
            this.créditDataGridViewTextBoxColumn.Width = 130;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 76);
            this.panel2.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(601, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(395, 21);
            this.textBox1.MaximumSize = new System.Drawing.Size(200, 35);
            this.textBox1.MinimumSize = new System.Drawing.Size(200, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 76);
            this.panel3.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(894, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 76);
            this.panel7.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(533, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "0";
            // 
            // itemsV2BindingNavigator
            // 
            this.itemsV2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemsV2BindingNavigator.BackColor = System.Drawing.Color.SteelBlue;
            this.itemsV2BindingNavigator.BindingSource = this.clientsV1BindingSource;
            this.itemsV2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsV2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemsV2BindingNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.itemsV2BindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemsV2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsV1BindingNavigatorSaveItem});
            this.itemsV2BindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.itemsV2BindingNavigator.Location = new System.Drawing.Point(904, 0);
            this.itemsV2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsV2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsV2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsV2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsV2BindingNavigator.Name = "itemsV2BindingNavigator";
            this.itemsV2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsV2BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.itemsV2BindingNavigator.Size = new System.Drawing.Size(53, 618);
            this.itemsV2BindingNavigator.TabIndex = 1;
            this.itemsV2BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // productsV1BindingNavigatorSaveItem
            // 
            this.productsV1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsV1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsV1BindingNavigatorSaveItem.Image")));
            this.productsV1BindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.productsV1BindingNavigatorSaveItem.Name = "productsV1BindingNavigatorSaveItem";
            this.productsV1BindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(5);
            this.productsV1BindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 30);
            this.productsV1BindingNavigatorSaveItem.Text = "Save Data";
            this.productsV1BindingNavigatorSaveItem.Click += new System.EventHandler(this.productsV1BindingNavigatorSaveItem_Click);
            // 
            // clientsV1TableAdapter
            // 
            this.clientsV1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsV1TableAdapter = this.clientsV1TableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestion_de_Stock.ClientsDBv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(957, 618);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV3DataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV2BindingNavigator)).EndInit();
            this.itemsV2BindingNavigator.ResumeLayout(false);
            this.itemsV2BindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox quantitéTextBox;
        private System.Windows.Forms.TextBox prix_d_achatTextBox;
        private System.Windows.Forms.TextBox prix_de_VenteTextBox;
        private System.Windows.Forms.DataGridView itemsV3DataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator itemsV2BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsV1BindingNavigatorSaveItem;
        private ClientsDBv1DataSet clientsDBv1DataSet;
        private System.Windows.Forms.BindingSource clientsV1BindingSource;
        private ClientsDBv1DataSetTableAdapters.ClientsV1TableAdapter clientsV1TableAdapter;
        private ClientsDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn téléphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomArticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn créditDataGridViewTextBoxColumn;
    }
}