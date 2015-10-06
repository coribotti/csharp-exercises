namespace Visto_en_clase
{
    partial class mainWin
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
            this.btnNewPer = new System.Windows.Forms.Button();
            this.btnNewList = new System.Windows.Forms.Button();
            this.btnNewConstante = new System.Windows.Forms.Button();
            this.btnNewEuler = new System.Windows.Forms.Button();
            this.btnNewListas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewPer
            // 
            this.btnNewPer.Location = new System.Drawing.Point(12, 12);
            this.btnNewPer.Name = "btnNewPer";
            this.btnNewPer.Size = new System.Drawing.Size(75, 23);
            this.btnNewPer.TabIndex = 0;
            this.btnNewPer.Text = "Es Perfecto";
            this.btnNewPer.UseVisualStyleBackColor = true;
            this.btnNewPer.Click += new System.EventHandler(this.btnNewPer_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.Location = new System.Drawing.Point(96, 12);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(75, 23);
            this.btnNewList.TabIndex = 1;
            this.btnNewList.Text = "Listas";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // btnNewConstante
            // 
            this.btnNewConstante.Location = new System.Drawing.Point(12, 41);
            this.btnNewConstante.Name = "btnNewConstante";
            this.btnNewConstante.Size = new System.Drawing.Size(75, 23);
            this.btnNewConstante.TabIndex = 2;
            this.btnNewConstante.Text = "Constante";
            this.btnNewConstante.UseVisualStyleBackColor = true;
            this.btnNewConstante.Click += new System.EventHandler(this.btnNewConstante_Click);
            // 
            // btnNewEuler
            // 
            this.btnNewEuler.Location = new System.Drawing.Point(96, 41);
            this.btnNewEuler.Name = "btnNewEuler";
            this.btnNewEuler.Size = new System.Drawing.Size(75, 23);
            this.btnNewEuler.TabIndex = 3;
            this.btnNewEuler.Text = "Euler";
            this.btnNewEuler.UseVisualStyleBackColor = true;
            this.btnNewEuler.Click += new System.EventHandler(this.btnNewEuler_Click);
            // 
            // btnNewListas
            // 
            this.btnNewListas.Location = new System.Drawing.Point(12, 70);
            this.btnNewListas.Name = "btnNewListas";
            this.btnNewListas.Size = new System.Drawing.Size(75, 23);
            this.btnNewListas.TabIndex = 4;
            this.btnNewListas.Text = "ListBox";
            this.btnNewListas.UseVisualStyleBackColor = true;
            this.btnNewListas.Click += new System.EventHandler(this.btnNewListas_Click);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 136);
            this.Controls.Add(this.btnNewListas);
            this.Controls.Add(this.btnNewEuler);
            this.Controls.Add(this.btnNewConstante);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.btnNewPer);
            this.Name = "mainWin";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewPer;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Button btnNewConstante;
        private System.Windows.Forms.Button btnNewEuler;
        private System.Windows.Forms.Button btnNewListas;
    }
}

