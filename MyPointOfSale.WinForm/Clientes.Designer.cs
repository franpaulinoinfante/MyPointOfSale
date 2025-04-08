namespace MyPointOfSale.WinForm
{
    partial class Clientes
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.DocumentNumber = new System.Windows.Forms.TextBox();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.DocumentType = new System.Windows.Forms.ComboBox();
            this.catlbl = new System.Windows.Forms.Label();
            this.itblbl = new System.Windows.Forms.Label();
            this.prelbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.idlb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(385, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 34);
            this.button4.TabIndex = 36;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(385, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 34);
            this.button3.TabIndex = 35;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(385, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(385, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LastName.Location = new System.Drawing.Point(152, 185);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(210, 32);
            this.LastName.TabIndex = 32;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.FirstName.Location = new System.Drawing.Point(152, 130);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(210, 32);
            this.FirstName.TabIndex = 31;
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DocumentNumber.Location = new System.Drawing.Point(152, 295);
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.Size = new System.Drawing.Size(210, 32);
            this.DocumentNumber.TabIndex = 30;
            // 
            // ClientId
            // 
            this.ClientId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ClientId.Location = new System.Drawing.Point(152, 74);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(100, 32);
            this.ClientId.TabIndex = 29;
            // 
            // DocumentType
            // 
            this.DocumentType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DocumentType.FormattingEnabled = true;
            this.DocumentType.Location = new System.Drawing.Point(152, 236);
            this.DocumentType.Name = "DocumentType";
            this.DocumentType.Size = new System.Drawing.Size(210, 33);
            this.DocumentType.TabIndex = 28;
            // 
            // catlbl
            // 
            this.catlbl.AutoSize = true;
            this.catlbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.catlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catlbl.Location = new System.Drawing.Point(28, 131);
            this.catlbl.Name = "catlbl";
            this.catlbl.Size = new System.Drawing.Size(81, 25);
            this.catlbl.TabIndex = 27;
            this.catlbl.Text = "Nombre";
            // 
            // itblbl
            // 
            this.itblbl.AutoSize = true;
            this.itblbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.itblbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itblbl.Location = new System.Drawing.Point(24, 293);
            this.itblbl.Name = "itblbl";
            this.itblbl.Size = new System.Drawing.Size(125, 25);
            this.itblbl.TabIndex = 26;
            this.itblbl.Text = "Num. de Doc.";
            // 
            // prelbl
            // 
            this.prelbl.AutoSize = true;
            this.prelbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.prelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prelbl.Location = new System.Drawing.Point(28, 239);
            this.prelbl.Name = "prelbl";
            this.prelbl.Size = new System.Drawing.Size(117, 25);
            this.prelbl.TabIndex = 25;
            this.prelbl.Text = "Tipo de Doc.";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.desclbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desclbl.Location = new System.Drawing.Point(28, 185);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(82, 25);
            this.desclbl.TabIndex = 24;
            this.desclbl.Text = "Apellido";
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.idlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idlb.Location = new System.Drawing.Point(28, 77);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(94, 25);
            this.idlb.TabIndex = 23;
            this.idlb.Text = "ID Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 249);
            this.dataGridView1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(574, 612);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.DocumentNumber);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.DocumentType);
            this.Controls.Add(this.catlbl);
            this.Controls.Add(this.itblbl);
            this.Controls.Add(this.prelbl);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.idlb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox DocumentNumber;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.ComboBox DocumentType;
        private System.Windows.Forms.Label catlbl;
        private System.Windows.Forms.Label itblbl;
        private System.Windows.Forms.Label prelbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}