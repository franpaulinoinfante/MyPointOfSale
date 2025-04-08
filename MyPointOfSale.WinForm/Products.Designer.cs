namespace MyPointOfSale.WinForm
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlb = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.prelbl = new System.Windows.Forms.Label();
            this.itblbl = new System.Windows.Forms.Label();
            this.catlbl = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.ITBIS = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 249);
            this.dataGridView1.TabIndex = 2;
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.idlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idlb.Location = new System.Drawing.Point(31, 71);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(30, 25);
            this.idlb.TabIndex = 3;
            this.idlb.Text = "ID";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.desclbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desclbl.Location = new System.Drawing.Point(25, 178);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(108, 25);
            this.desclbl.TabIndex = 4;
            this.desclbl.Text = "Description";
            // 
            // prelbl
            // 
            this.prelbl.AutoSize = true;
            this.prelbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.prelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prelbl.Location = new System.Drawing.Point(25, 232);
            this.prelbl.Name = "prelbl";
            this.prelbl.Size = new System.Drawing.Size(54, 25);
            this.prelbl.TabIndex = 5;
            this.prelbl.Text = "Price";
            // 
            // itblbl
            // 
            this.itblbl.AutoSize = true;
            this.itblbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.itblbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itblbl.Location = new System.Drawing.Point(25, 286);
            this.itblbl.Name = "itblbl";
            this.itblbl.Size = new System.Drawing.Size(53, 25);
            this.itblbl.TabIndex = 6;
            this.itblbl.Text = "ITBIS";
            // 
            // catlbl
            // 
            this.catlbl.AutoSize = true;
            this.catlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.catlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catlbl.Location = new System.Drawing.Point(25, 124);
            this.catlbl.Name = "catlbl";
            this.catlbl.Size = new System.Drawing.Size(88, 25);
            this.catlbl.TabIndex = 10;
            this.catlbl.Text = "Category";
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(149, 122);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(210, 33);
            this.Category.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Id.Location = new System.Drawing.Point(149, 67);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 32);
            this.Id.TabIndex = 12;
            // 
            // ITBIS
            // 
            this.ITBIS.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ITBIS.Location = new System.Drawing.Point(149, 288);
            this.ITBIS.Name = "ITBIS";
            this.ITBIS.Size = new System.Drawing.Size(210, 32);
            this.ITBIS.TabIndex = 14;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Price.Location = new System.Drawing.Point(149, 233);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(210, 32);
            this.Price.TabIndex = 15;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Description.Location = new System.Drawing.Point(149, 178);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(210, 32);
            this.Description.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(382, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(382, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(382, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 34);
            this.button4.TabIndex = 20;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(558, 596);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ITBIS);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.catlbl);
            this.Controls.Add(this.itblbl);
            this.Controls.Add(this.prelbl);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.idlb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "Productos";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Label prelbl;
        private System.Windows.Forms.Label itblbl;
        private System.Windows.Forms.Label catlbl;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox ITBIS;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}