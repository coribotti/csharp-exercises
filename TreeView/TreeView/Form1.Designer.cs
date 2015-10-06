namespace TreeView
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("4ºD");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("4ºG");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("4ºK");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txnumCuenta = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.txProm = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gBAlumno = new System.Windows.Forms.GroupBox();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.btnNewAlumno = new System.Windows.Forms.Button();
            this.gBAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº de Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio:";
            // 
            // txnumCuenta
            // 
            this.txnumCuenta.Location = new System.Drawing.Point(86, 24);
            this.txnumCuenta.Name = "txnumCuenta";
            this.txnumCuenta.Size = new System.Drawing.Size(100, 20);
            this.txnumCuenta.TabIndex = 4;
            this.txnumCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(86, 54);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 5;
            this.txName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "4ºD",
            "4ºG",
            "4ºK"});
            this.cbGroup.Location = new System.Drawing.Point(86, 82);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(100, 21);
            this.cbGroup.TabIndex = 6;
            // 
            // txProm
            // 
            this.txProm.Location = new System.Drawing.Point(86, 109);
            this.txProm.Name = "txProm";
            this.txProm.Size = new System.Drawing.Size(100, 20);
            this.txProm.TabIndex = 7;
            this.txProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(72, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gBAlumno
            // 
            this.gBAlumno.Controls.Add(this.label1);
            this.gBAlumno.Controls.Add(this.btnAdd);
            this.gBAlumno.Controls.Add(this.cbGroup);
            this.gBAlumno.Controls.Add(this.txProm);
            this.gBAlumno.Controls.Add(this.label2);
            this.gBAlumno.Controls.Add(this.label3);
            this.gBAlumno.Controls.Add(this.txName);
            this.gBAlumno.Controls.Add(this.label4);
            this.gBAlumno.Controls.Add(this.txnumCuenta);
            this.gBAlumno.Location = new System.Drawing.Point(12, 12);
            this.gBAlumno.Name = "gBAlumno";
            this.gBAlumno.Size = new System.Drawing.Size(216, 185);
            this.gBAlumno.TabIndex = 9;
            this.gBAlumno.TabStop = false;
            this.gBAlumno.Text = "Datos del alumno:";
            this.gBAlumno.Visible = false;
            // 
            // tvShow
            // 
            this.tvShow.Location = new System.Drawing.Point(234, 18);
            this.tvShow.Name = "tvShow";
            treeNode1.Name = "4ºD";
            treeNode1.Text = "4ºD";
            treeNode2.Name = "4ºG";
            treeNode2.Text = "4ºG";
            treeNode3.Name = "4ºK";
            treeNode3.Text = "4ºK";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvShow.Size = new System.Drawing.Size(239, 230);
            this.tvShow.TabIndex = 10;
            this.tvShow.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvShow_NodeMouseDoubleClick);
            // 
            // btnNewAlumno
            // 
            this.btnNewAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewAlumno.Location = new System.Drawing.Point(12, 212);
            this.btnNewAlumno.Name = "btnNewAlumno";
            this.btnNewAlumno.Size = new System.Drawing.Size(80, 36);
            this.btnNewAlumno.TabIndex = 11;
            this.btnNewAlumno.Text = "Agregar Alumno";
            this.btnNewAlumno.UseVisualStyleBackColor = true;
            this.btnNewAlumno.Click += new System.EventHandler(this.btnNewAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 260);
            this.Controls.Add(this.btnNewAlumno);
            this.Controls.Add(this.tvShow);
            this.Controls.Add(this.gBAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBAlumno.ResumeLayout(false);
            this.gBAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txnumCuenta;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.TextBox txProm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gBAlumno;
        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.Button btnNewAlumno;

    }
}

