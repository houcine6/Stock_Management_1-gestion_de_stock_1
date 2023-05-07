
namespace Gestion_de_Stock
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.itemsDBv3DataSet = new Gestion_de_Stock.ItemsDBv3DataSet();
            this.itemsV3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsV3TableAdapter = new Gestion_de_Stock.ItemsDBv3DataSetTableAdapters.ItemsV3TableAdapter();
            this.tableAdapterManager = new Gestion_de_Stock.ItemsDBv3DataSetTableAdapters.TableAdapterManager();
            this.itemsDBv3DataSet1 = new Gestion_de_Stock.ItemsDBv3DataSet();
            this.salesDBv2DataSet = new Gestion_de_Stock.SalesDBv2DataSet();
            this.salesV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesV2TableAdapter = new Gestion_de_Stock.SalesDBv2DataSetTableAdapters.SalesV2TableAdapter();
            this.tableAdapterManager1 = new Gestion_de_Stock.SalesDBv2DataSetTableAdapters.TableAdapterManager();
            this.clientsDBv1DataSet = new Gestion_de_Stock.ClientsDBv1DataSet();
            this.clientsV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsV1TableAdapter = new Gestion_de_Stock.ClientsDBv1DataSetTableAdapters.ClientsV1TableAdapter();
            this.tableAdapterManager2 = new Gestion_de_Stock.ClientsDBv1DataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDBv2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(810, 450);
            this.panel1.MinimumSize = new System.Drawing.Size(810, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 450);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(541, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Version d\'essai";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(533, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Gestion de Stock";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(164, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "V.2.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(546, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 128);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(31, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Chargement...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 37);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(31, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Développé par Houcine HadjSaid";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(73, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "0663822138 / 0554315620";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // itemsDBv3DataSet
            // 
            this.itemsDBv3DataSet.DataSetName = "ItemsDBv3DataSet";
            this.itemsDBv3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsV3BindingSource
            // 
            this.itemsV3BindingSource.DataMember = "ItemsV3";
            this.itemsV3BindingSource.DataSource = this.itemsDBv3DataSet;
            // 
            // itemsV3TableAdapter
            // 
            this.itemsV3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsV3TableAdapter = this.itemsV3TableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestion_de_Stock.ItemsDBv3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsDBv3DataSet1
            // 
            this.itemsDBv3DataSet1.DataSetName = "ItemsDBv3DataSet";
            this.itemsDBv3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesDBv2DataSet
            // 
            this.salesDBv2DataSet.DataSetName = "SalesDBv2DataSet";
            this.salesDBv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesV2BindingSource
            // 
            this.salesV2BindingSource.DataMember = "SalesV2";
            this.salesV2BindingSource.DataSource = this.salesDBv2DataSet;
            // 
            // salesV2TableAdapter
            // 
            this.salesV2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SalesV2TableAdapter = this.salesV2TableAdapter;
            this.tableAdapterManager1.UpdateOrder = Gestion_de_Stock.SalesDBv2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsDBv1DataSet
            // 
            this.clientsDBv1DataSet.DataSetName = "ClientsDBv1DataSet";
            this.clientsDBv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsV1BindingSource
            // 
            this.clientsV1BindingSource.DataMember = "ClientsV1";
            this.clientsV1BindingSource.DataSource = this.clientsDBv1DataSet;
            // 
            // clientsV1TableAdapter
            // 
            this.clientsV1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ClientsV1TableAdapter = this.clientsV1TableAdapter;
            this.tableAdapterManager2.UpdateOrder = Gestion_de_Stock.ClientsDBv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDBv2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private ItemsDBv3DataSet itemsDBv3DataSet;
        private System.Windows.Forms.BindingSource itemsV3BindingSource;
        private ItemsDBv3DataSetTableAdapters.ItemsV3TableAdapter itemsV3TableAdapter;
        private ItemsDBv3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ItemsDBv3DataSet itemsDBv3DataSet1;
        private SalesDBv2DataSet salesDBv2DataSet;
        private System.Windows.Forms.BindingSource salesV2BindingSource;
        private SalesDBv2DataSetTableAdapters.SalesV2TableAdapter salesV2TableAdapter;
        private SalesDBv2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ClientsDBv1DataSet clientsDBv1DataSet;
        private System.Windows.Forms.BindingSource clientsV1BindingSource;
        private ClientsDBv1DataSetTableAdapters.ClientsV1TableAdapter clientsV1TableAdapter;
        private ClientsDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Label label6;
    }
}