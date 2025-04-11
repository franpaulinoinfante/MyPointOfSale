using System.Drawing;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.usuarios = new System.Windows.Forms.LinkLabel();
            this.clientes = new System.Windows.Forms.LinkLabel();
            this.reporte = new System.Windows.Forms.LinkLabel();
            this.stock = new System.Windows.Forms.LinkLabel();
            this.lklProductos = new System.Windows.Forms.LinkLabel();
            this.documentos = new System.Windows.Forms.LinkLabel();
            this.lklInvoice = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblNCFTotales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSalesTotals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientsQuantities = new System.Windows.Forms.Label();
            this.ctrlDateTime = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.clmProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.usuarios);
            this.panel1.Controls.Add(this.clientes);
            this.panel1.Controls.Add(this.reporte);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.lklProductos);
            this.panel1.Controls.Add(this.documentos);
            this.panel1.Controls.Add(this.lklInvoice);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 556);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(117, 440);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 20);
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.Text = "Cerrar Sección";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // usuarios
            // 
            this.usuarios.AutoSize = true;
            this.usuarios.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.usuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.usuarios.LinkColor = System.Drawing.SystemColors.Control;
            this.usuarios.Location = new System.Drawing.Point(43, 402);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(154, 21);
            this.usuarios.TabIndex = 24;
            this.usuarios.TabStop = true;
            this.usuarios.Text = "Usuarios y Seguridad";
            this.usuarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usuarios_LinkClicked);
            // 
            // clientes
            // 
            this.clientes.AutoSize = true;
            this.clientes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.clientes.LinkColor = System.Drawing.SystemColors.Control;
            this.clientes.Location = new System.Drawing.Point(43, 340);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(152, 21);
            this.clientes.TabIndex = 23;
            this.clientes.TabStop = true;
            this.clientes.Text = "Clientes y Suplidores";
            // 
            // reporte
            // 
            this.reporte.AutoSize = true;
            this.reporte.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.reporte.ForeColor = System.Drawing.SystemColors.Control;
            this.reporte.LinkColor = System.Drawing.SystemColors.Control;
            this.reporte.Location = new System.Drawing.Point(43, 281);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(63, 21);
            this.reporte.TabIndex = 22;
            this.reporte.TabStop = true;
            this.reporte.Text = "Reporte";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.stock.ForeColor = System.Drawing.SystemColors.Control;
            this.stock.LinkColor = System.Drawing.SystemColors.Control;
            this.stock.Location = new System.Drawing.Point(43, 222);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(46, 21);
            this.stock.TabIndex = 21;
            this.stock.TabStop = true;
            this.stock.Text = "Stock";
            // 
            // lklProductos
            // 
            this.lklProductos.AutoSize = true;
            this.lklProductos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lklProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.lklProductos.LinkColor = System.Drawing.SystemColors.Control;
            this.lklProductos.Location = new System.Drawing.Point(43, 162);
            this.lklProductos.Name = "lklProductos";
            this.lklProductos.Size = new System.Drawing.Size(79, 21);
            this.lklProductos.TabIndex = 20;
            this.lklProductos.TabStop = true;
            this.lklProductos.Text = "Productos";
            this.lklProductos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productos_LinkClicked);
            // 
            // documentos
            // 
            this.documentos.AutoSize = true;
            this.documentos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.documentos.ForeColor = System.Drawing.SystemColors.Control;
            this.documentos.LinkColor = System.Drawing.SystemColors.Control;
            this.documentos.Location = new System.Drawing.Point(43, 107);
            this.documentos.Name = "documentos";
            this.documentos.Size = new System.Drawing.Size(97, 21);
            this.documentos.TabIndex = 19;
            this.documentos.TabStop = true;
            this.documentos.Text = "Documentos";
            // 
            // lklInvoice
            // 
            this.lklInvoice.AutoSize = true;
            this.lklInvoice.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lklInvoice.ForeColor = System.Drawing.SystemColors.Control;
            this.lklInvoice.LinkColor = System.Drawing.SystemColors.Control;
            this.lklInvoice.Location = new System.Drawing.Point(43, 59);
            this.lklInvoice.Name = "lklInvoice";
            this.lklInvoice.Size = new System.Drawing.Size(56, 21);
            this.lklInvoice.TabIndex = 18;
            this.lklInvoice.TabStop = true;
            this.lklInvoice.Text = "Ventas";
            this.lklInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklInvoice_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblUserEmail);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 91);
            this.panel2.TabIndex = 17;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.BackColor = System.Drawing.Color.White;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUserEmail.ForeColor = System.Drawing.Color.Black;
            this.lblUserEmail.Location = new System.Drawing.Point(58, 58);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(57, 13);
            this.lblUserEmail.TabIndex = 3;
            this.lblUserEmail.Text = "UserEmail";
            this.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(3, 13);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(51, 65);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.White;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPosition.ForeColor = System.Drawing.Color.Black;
            this.lblPosition.Location = new System.Drawing.Point(58, 3);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(53, 15);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "UserRole";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(59, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dashboard";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(7, 340);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(7, 399);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyPointOfSale.WinForm.Properties.Resources.icons8_report_50;
            this.pictureBox5.Location = new System.Drawing.Point(7, 281);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(563, 423);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(283, 86);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "23:59:59";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDate.Location = new System.Drawing.Point(672, 523);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 24);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Fecha";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductId,
            this.clmDescription,
            this.clmPrice,
            this.clmITBIS,
            this.clmCategory});
            this.dataGridView1.Location = new System.Drawing.Point(7, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 416);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 556);
            this.panel3.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 100);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblNCFTotales);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(639, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 94);
            this.panel7.TabIndex = 3;
            // 
            // lblNCFTotales
            // 
            this.lblNCFTotales.AutoSize = true;
            this.lblNCFTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCFTotales.Location = new System.Drawing.Point(59, 46);
            this.lblNCFTotales.Name = "lblNCFTotales";
            this.lblNCFTotales.Size = new System.Drawing.Size(94, 16);
            this.lblNCFTotales.TabIndex = 7;
            this.lblNCFTotales.Text = "NCF Totales";
            this.lblNCFTotales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "NCF Totales";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lblTotalProducts);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(427, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 94);
            this.panel6.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de Productos";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.Location = new System.Drawing.Point(12, 46);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(139, 16);
            this.lblTotalProducts.TabIndex = 4;
            this.lblTotalProducts.Text = "Total de Productos";
            this.lblTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblSalesTotals);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(215, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 94);
            this.panel5.TabIndex = 1;
            // 
            // lblSalesTotals
            // 
            this.lblSalesTotals.AutoSize = true;
            this.lblSalesTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTotals.Location = new System.Drawing.Point(37, 46);
            this.lblSalesTotals.Name = "lblSalesTotals";
            this.lblSalesTotals.Size = new System.Drawing.Size(112, 16);
            this.lblSalesTotals.TabIndex = 0;
            this.lblSalesTotals.Text = "Ventas Totales";
            this.lblSalesTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas Totales";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblClientsQuantities);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 94);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clientes";
            // 
            // lblClientsQuantities
            // 
            this.lblClientsQuantities.AutoSize = true;
            this.lblClientsQuantities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsQuantities.Location = new System.Drawing.Point(24, 46);
            this.lblClientsQuantities.Name = "lblClientsQuantities";
            this.lblClientsQuantities.Size = new System.Drawing.Size(149, 16);
            this.lblClientsQuantities.TabIndex = 3;
            this.lblClientsQuantities.Text = "Cantidad de clientes";
            this.lblClientsQuantities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlDateTime
            // 
            this.ctrlDateTime.Enabled = true;
            this.ctrlDateTime.Tick += new System.EventHandler(this.ctrlDateTime_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Listado de Productos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clmProductId
            // 
            this.clmProductId.HeaderText = "Producto ID";
            this.clmProductId.Name = "clmProductId";
            this.clmProductId.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Descricpción";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmITBIS
            // 
            this.clmITBIS.HeaderText = "ITBIS";
            this.clmITBIS.Name = "clmITBIS";
            this.clmITBIS.ReadOnly = true;
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Categoria";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel reporte;
        private System.Windows.Forms.LinkLabel stock;
        private System.Windows.Forms.LinkLabel lklProductos;
        private System.Windows.Forms.LinkLabel documentos;
        private System.Windows.Forms.LinkLabel lklInvoice;
        private System.Windows.Forms.LinkLabel usuarios;
        private System.Windows.Forms.LinkLabel clientes;
        private Button btnLogOut;
        private Label lblUserName;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Label lblClientsQuantities;
        private Label label2;
        private Panel panel4;
        private Label label1;
        private Label lblSalesTotals;
        private Label lblNCFTotales;
        private Label label5;
        private Label label4;
        private Label lblTotalProducts;
        private Timer ctrlDateTime;
        private Label label3;
        private DataGridViewTextBoxColumn clmProductId;
        private DataGridViewTextBoxColumn clmDescription;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmITBIS;
        private DataGridViewTextBoxColumn clmCategory;
    }
}