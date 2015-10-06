namespace Serpientes_y_escaleras
{
    partial class SerpientesEscaleras
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
            this.gBJ1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCasillaJ1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDado1 = new System.Windows.Forms.Button();
            this.gBJ2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCasillaJ2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBTablero = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBJ1.SuspendLayout();
            this.gBJ2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTablero)).BeginInit();
            this.SuspendLayout();
            // 
            // gBJ1
            // 
            this.gBJ1.Controls.Add(this.label5);
            this.gBJ1.Controls.Add(this.txCasillaJ1);
            this.gBJ1.Controls.Add(this.label2);
            this.gBJ1.Location = new System.Drawing.Point(12, 24);
            this.gBJ1.Name = "gBJ1";
            this.gBJ1.Size = new System.Drawing.Size(106, 144);
            this.gBJ1.TabIndex = 1;
            this.gBJ1.TabStop = false;
            this.gBJ1.Text = "Jugador 1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Presione la tecla Q para lanzar el dado.";
            // 
            // txCasillaJ1
            // 
            this.txCasillaJ1.Location = new System.Drawing.Point(6, 106);
            this.txCasillaJ1.Name = "txCasillaJ1";
            this.txCasillaJ1.ReadOnly = true;
            this.txCasillaJ1.Size = new System.Drawing.Size(75, 20);
            this.txCasillaJ1.TabIndex = 2;
            this.txCasillaJ1.Text = "0";
            this.txCasillaJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Casilla actual:";
            // 
            // btnDado1
            // 
            this.btnDado1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDado1.Location = new System.Drawing.Point(255, 136);
            this.btnDado1.Name = "btnDado1";
            this.btnDado1.Size = new System.Drawing.Size(75, 23);
            this.btnDado1.TabIndex = 0;
            this.btnDado1.Text = "Trigger";
            this.btnDado1.UseVisualStyleBackColor = true;
            this.btnDado1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnDado1_KeyUp);
            // 
            // gBJ2
            // 
            this.gBJ2.Controls.Add(this.label4);
            this.gBJ2.Controls.Add(this.txtCasillaJ2);
            this.gBJ2.Controls.Add(this.label1);
            this.gBJ2.Location = new System.Drawing.Point(477, 24);
            this.gBJ2.Name = "gBJ2";
            this.gBJ2.Size = new System.Drawing.Size(104, 144);
            this.gBJ2.TabIndex = 2;
            this.gBJ2.TabStop = false;
            this.gBJ2.Text = "Jugador 2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Presione la tecla P para lanzar el dado.";
            // 
            // txtCasillaJ2
            // 
            this.txtCasillaJ2.Location = new System.Drawing.Point(9, 106);
            this.txtCasillaJ2.Name = "txtCasillaJ2";
            this.txtCasillaJ2.ReadOnly = true;
            this.txtCasillaJ2.Size = new System.Drawing.Size(72, 20);
            this.txtCasillaJ2.TabIndex = 2;
            this.txtCasillaJ2.Text = "0";
            this.txtCasillaJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Casilla actual:";
            // 
            // picBTablero
            // 
            this.picBTablero.Image = global::Serpientes_y_escaleras.Properties.Resources.Tablero;
            this.picBTablero.Location = new System.Drawing.Point(131, 12);
            this.picBTablero.Name = "picBTablero";
            this.picBTablero.Size = new System.Drawing.Size(332, 325);
            this.picBTablero.TabIndex = 3;
            this.picBTablero.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dado:";
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(481, 317);
            this.txtDado.Name = "txtDado";
            this.txtDado.ReadOnly = true;
            this.txtDado.Size = new System.Drawing.Size(100, 20);
            this.txtDado.TabIndex = 5;
            this.txtDado.Text = "0";
            this.txtDado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Presione la tecla X para salir.";
            // 
            // SerpientesEscaleras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBTablero);
            this.Controls.Add(this.gBJ2);
            this.Controls.Add(this.gBJ1);
            this.Controls.Add(this.btnDado1);
            this.Name = "SerpientesEscaleras";
            this.Text = "Serpientes y Escaleras";
            this.Load += new System.EventHandler(this.SerpientesEscaleras_Load);
            this.gBJ1.ResumeLayout(false);
            this.gBJ1.PerformLayout();
            this.gBJ2.ResumeLayout(false);
            this.gBJ2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBTablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBJ1;
        private System.Windows.Forms.TextBox txCasillaJ1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDado1;
        private System.Windows.Forms.GroupBox gBJ2;
        private System.Windows.Forms.TextBox txtCasillaJ2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBTablero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

