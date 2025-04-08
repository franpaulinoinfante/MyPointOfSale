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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnLogOut = new Button();
            usuarios = new LinkLabel();
            clientes = new LinkLabel();
            reporte = new LinkLabel();
            stock = new LinkLabel();
            productos = new LinkLabel();
            documentos = new LinkLabel();
            ventas = new LinkLabel();
            panel2 = new Panel();
            lblUserEmail = new Label();
            pictureBox8 = new PictureBox();
            lblPosition = new Label();
            lblUserName = new Label();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 68, 108);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(usuarios);
            panel1.Controls.Add(clientes);
            panel1.Controls.Add(reporte);
            panel1.Controls.Add(stock);
            panel1.Controls.Add(productos);
            panel1.Controls.Add(documentos);
            panel1.Controls.Add(ventas);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 642);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(137, 508);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(97, 23);
            btnLogOut.TabIndex = 25;
            btnLogOut.Text = "Cerrar Sección";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // usuarios
            // 
            usuarios.AutoSize = true;
            usuarios.Font = new Font("Segoe UI Semilight", 12F);
            usuarios.ForeColor = SystemColors.Control;
            usuarios.LinkColor = SystemColors.Control;
            usuarios.Location = new Point(50, 464);
            usuarios.Margin = new Padding(4, 0, 4, 0);
            usuarios.Name = "usuarios";
            usuarios.Size = new Size(154, 21);
            usuarios.TabIndex = 24;
            usuarios.TabStop = true;
            usuarios.Text = "Usuarios y Seguridad";
            // 
            // clientes
            // 
            clientes.AutoSize = true;
            clientes.Font = new Font("Segoe UI Semilight", 12F);
            clientes.ForeColor = SystemColors.Control;
            clientes.LinkColor = SystemColors.Control;
            clientes.Location = new Point(50, 392);
            clientes.Margin = new Padding(4, 0, 4, 0);
            clientes.Name = "clientes";
            clientes.Size = new Size(152, 21);
            clientes.TabIndex = 23;
            clientes.TabStop = true;
            clientes.Text = "Clientes y Suplidores";
            // 
            // reporte
            // 
            reporte.AutoSize = true;
            reporte.Font = new Font("Segoe UI Semilight", 12F);
            reporte.ForeColor = SystemColors.Control;
            reporte.LinkColor = SystemColors.Control;
            reporte.Location = new Point(50, 324);
            reporte.Margin = new Padding(4, 0, 4, 0);
            reporte.Name = "reporte";
            reporte.Size = new Size(63, 21);
            reporte.TabIndex = 22;
            reporte.TabStop = true;
            reporte.Text = "Reporte";
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Font = new Font("Segoe UI Semilight", 12F);
            stock.ForeColor = SystemColors.Control;
            stock.LinkColor = SystemColors.Control;
            stock.Location = new Point(50, 256);
            stock.Margin = new Padding(4, 0, 4, 0);
            stock.Name = "stock";
            stock.Size = new Size(46, 21);
            stock.TabIndex = 21;
            stock.TabStop = true;
            stock.Text = "Stock";
            // 
            // productos
            // 
            productos.AutoSize = true;
            productos.Font = new Font("Segoe UI Semilight", 12F);
            productos.ForeColor = SystemColors.Control;
            productos.LinkColor = SystemColors.Control;
            productos.Location = new Point(50, 187);
            productos.Margin = new Padding(4, 0, 4, 0);
            productos.Name = "productos";
            productos.Size = new Size(79, 21);
            productos.TabIndex = 20;
            productos.TabStop = true;
            productos.Text = "Productos";
            // 
            // documentos
            // 
            documentos.AutoSize = true;
            documentos.Font = new Font("Segoe UI Semilight", 12F);
            documentos.ForeColor = SystemColors.Control;
            documentos.LinkColor = SystemColors.Control;
            documentos.Location = new Point(50, 124);
            documentos.Margin = new Padding(4, 0, 4, 0);
            documentos.Name = "documentos";
            documentos.Size = new Size(97, 21);
            documentos.TabIndex = 19;
            documentos.TabStop = true;
            documentos.Text = "Documentos";
            // 
            // ventas
            // 
            ventas.AutoSize = true;
            ventas.Font = new Font("Segoe UI Semilight", 12F);
            ventas.ForeColor = SystemColors.Control;
            ventas.LinkColor = SystemColors.Control;
            ventas.Location = new Point(50, 68);
            ventas.Margin = new Padding(4, 0, 4, 0);
            ventas.Name = "ventas";
            ventas.Size = new Size(56, 21);
            ventas.TabIndex = 18;
            ventas.TabStop = true;
            ventas.Text = "Ventas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUserEmail);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(lblPosition);
            panel2.Controls.Add(lblUserName);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 537);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 105);
            panel2.TabIndex = 17;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.BackColor = Color.White;
            lblUserEmail.Font = new Font("Segoe UI", 9F);
            lblUserEmail.ForeColor = Color.Black;
            lblUserEmail.Location = new Point(76, 66);
            lblUserEmail.Margin = new Padding(4, 0, 4, 0);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(59, 15);
            lblUserEmail.TabIndex = 3;
            lblUserEmail.Text = "UserEmail";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Location = new Point(4, 15);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(69, 75);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.BackColor = Color.White;
            lblPosition.Font = new Font("Segoe UI", 9F);
            lblPosition.ForeColor = Color.Black;
            lblPosition.Location = new Point(77, 4);
            lblPosition.Margin = new Padding(4, 0, 4, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 15);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "UserRole";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.White;
            lblUserName.Font = new Font("Segoe UI", 9F);
            lblUserName.ForeColor = Color.Black;
            lblUserName.Location = new Point(77, 33);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(62, 15);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "UserName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(7, 10);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 33);
            label7.TabIndex = 16;
            label7.Text = "Dashboard";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(8, 392);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(29, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(8, 460);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(8, 324);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(8, 187);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(8, 256);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(8, 119);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 68);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(670, 508);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(283, 86);
            label11.TabIndex = 1;
            label11.Text = "23:59:59";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.MenuHighlight;
            label12.Location = new Point(670, 603);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(308, 25);
            label12.TabIndex = 18;
            label12.Text = "sábado, 31 de diciembre, 2011";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 389);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(621, 250);
            dataGridView1.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(241, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(991, 642);
            panel3.TabIndex = 20;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 642);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel reporte;
        private System.Windows.Forms.LinkLabel stock;
        private System.Windows.Forms.LinkLabel productos;
        private System.Windows.Forms.LinkLabel documentos;
        private System.Windows.Forms.LinkLabel ventas;
        private System.Windows.Forms.LinkLabel usuarios;
        private System.Windows.Forms.LinkLabel clientes;
        private Button btnLogOut;
        private Label lblUserName;
        private Panel panel3;
    }
}