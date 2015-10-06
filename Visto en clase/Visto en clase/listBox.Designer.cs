namespace Visto_en_clase
{
    partial class listBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listNumeros = new System.Windows.Forms.ListBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.btnMayorProm = new System.Windows.Forms.Button();
            this.txtMayorProm = new System.Windows.Forms.TextBox();
            this.btnNumMayor = new System.Windows.Forms.Button();
            this.txtNumMayor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(6, 19);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(75, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listNumeros
            // 
            this.listNumeros.FormattingEnabled = true;
            this.listNumeros.Location = new System.Drawing.Point(120, 12);
            this.listNumeros.Name = "listNumeros";
            this.listNumeros.Size = new System.Drawing.Size(54, 160);
            this.listNumeros.TabIndex = 2;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(180, 12);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // txtProm
            // 
            this.txtProm.Location = new System.Drawing.Point(261, 14);
            this.txtProm.Name = "txtProm";
            this.txtProm.ReadOnly = true;
            this.txtProm.Size = new System.Drawing.Size(140, 20);
            this.txtProm.TabIndex = 4;
            this.txtProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMayorProm
            // 
            this.btnMayorProm.Location = new System.Drawing.Point(180, 41);
            this.btnMayorProm.Name = "btnMayorProm";
            this.btnMayorProm.Size = new System.Drawing.Size(75, 23);
            this.btnMayorProm.TabIndex = 5;
            this.btnMayorProm.Text = "> Promedio";
            this.btnMayorProm.UseVisualStyleBackColor = true;
            this.btnMayorProm.Click += new System.EventHandler(this.btnMayorProm_Click);
            // 
            // txtMayorProm
            // 
            this.txtMayorProm.Location = new System.Drawing.Point(261, 43);
            this.txtMayorProm.Multiline = true;
            this.txtMayorProm.Name = "txtMayorProm";
            this.txtMayorProm.ReadOnly = true;
            this.txtMayorProm.Size = new System.Drawing.Size(140, 37);
            this.txtMayorProm.TabIndex = 6;
            this.txtMayorProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNumMayor
            // 
            this.btnNumMayor.Location = new System.Drawing.Point(180, 86);
            this.btnNumMayor.Name = "btnNumMayor";
            this.btnNumMayor.Size = new System.Drawing.Size(75, 23);
            this.btnNumMayor.TabIndex = 7;
            this.btnNumMayor.Text = "Num Mayor";
            this.btnNumMayor.UseVisualStyleBackColor = true;
            this.btnNumMayor.Click += new System.EventHandler(this.btnNumMayor_Click);
            // 
            // txtNumMayor
            // 
            this.txtNumMayor.Location = new System.Drawing.Point(261, 89);
            this.txtNumMayor.Name = "txtNumMayor";
            this.txtNumMayor.ReadOnly = true;
            this.txtNumMayor.Size = new System.Drawing.Size(140, 20);
            this.txtNumMayor.TabIndex = 8;
            this.txtNumMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 184);
            this.Controls.Add(this.txtNumMayor);
            this.Controls.Add(this.btnNumMayor);
            this.Controls.Add(this.txtMayorProm);
            this.Controls.Add(this.btnMayorProm);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.listNumeros);
            this.Controls.Add(this.groupBox1);
            this.Name = "listBox";
            this.Text = "List Box";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox listNumeros;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.Button btnMayorProm;
        private System.Windows.Forms.TextBox txtMayorProm;
        private System.Windows.Forms.Button btnNumMayor;
        private System.Windows.Forms.TextBox txtNumMayor;
    }
}