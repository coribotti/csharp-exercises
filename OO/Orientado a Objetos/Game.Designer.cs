namespace Orientado_a_Objetos
{
    partial class Game
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
            this.txtCasilla = new System.Windows.Forms.TextBox();
            this.btnCasilla = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCasilla
            // 
            this.txtCasilla.Location = new System.Drawing.Point(12, 109);
            this.txtCasilla.Name = "txtCasilla";
            this.txtCasilla.Size = new System.Drawing.Size(100, 20);
            this.txtCasilla.TabIndex = 0;
            this.txtCasilla.Text = "0";
            // 
            // btnCasilla
            // 
            this.btnCasilla.Location = new System.Drawing.Point(122, 57);
            this.btnCasilla.Name = "btnCasilla";
            this.btnCasilla.Size = new System.Drawing.Size(75, 23);
            this.btnCasilla.TabIndex = 1;
            this.btnCasilla.Text = "Nº casilla";
            this.btnCasilla.UseVisualStyleBackColor = true;
            this.btnCasilla.Click += new System.EventHandler(this.btnCasilla_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(185, 109);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnCasilla);
            this.Controls.Add(this.txtCasilla);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCasilla;
        private System.Windows.Forms.Button btnCasilla;
        private System.Windows.Forms.Button btnAvanzar;
    }
}