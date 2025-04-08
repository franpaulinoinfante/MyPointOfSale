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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.usuarios = new System.Windows.Forms.LinkLabel();
            this.clientes = new System.Windows.Forms.LinkLabel();
            this.reporte = new System.Windows.Forms.LinkLabel();
            this.stock = new System.Windows.Forms.LinkLabel();
            this.productos = new System.Windows.Forms.LinkLabel();
            this.documentos = new System.Windows.Forms.LinkLabel();
            this.ventas = new System.Windows.Forms.LinkLabel();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.productos);
            this.panel1.Controls.Add(this.documentos);
            this.panel1.Controls.Add(this.ventas);
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
            // productos
            // 
            this.productos.AutoSize = true;
            this.productos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.productos.ForeColor = System.Drawing.SystemColors.Control;
            this.productos.LinkColor = System.Drawing.SystemColors.Control;
            this.productos.Location = new System.Drawing.Point(43, 162);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(79, 21);
            this.productos.TabIndex = 20;
            this.productos.TabStop = true;
            this.productos.Text = "Productos";
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
            // ventas
            // 
            this.ventas.AutoSize = true;
            this.ventas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.ventas.ForeColor = System.Drawing.SystemColors.Control;
            this.ventas.LinkColor = System.Drawing.SystemColors.Control;
            this.ventas.Location = new System.Drawing.Point(43, 59);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(56, 21);
            this.ventas.TabIndex = 18;
            this.ventas.TabStop = true;
            this.ventas.Text = "Ventas";
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
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserEmail.ForeColor = System.Drawing.Color.Black;
            this.lblUserEmail.Location = new System.Drawing.Point(65, 57);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(59, 15);
            this.lblUserEmail.TabIndex = 3;
            this.lblUserEmail.Text = "UserEmail";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(3, 13);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(59, 65);
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
            this.lblPosition.Location = new System.Drawing.Point(66, 3);
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
            this.lblUserName.Location = new System.Drawing.Point(66, 29);
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
            this.pictureBox7.Location = new System.Drawing.Point(7, 340);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(7, 399);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(7, 281);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(7, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(7, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(545, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 86);
            this.label11.TabIndex = 1;
            this.label11.Text = "23:59:59";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(545, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "sábado, 31 de diciembre, 2011";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 217);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 556);
            this.panel3.TabIndex = 20;
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