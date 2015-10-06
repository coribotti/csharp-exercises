namespace Inventario
{
    partial class Inv
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
            this.txCode = new System.Windows.Forms.TextBox();
            this.txCant = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.gbInv = new System.Windows.Forms.GroupBox();
            this.txInv = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txSearchCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txHowMany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbProduct.SuspendLayout();
            this.gbInv.SuspendLayout();
            this.SuspendLayout();
            // 
            // txCode
            // 
            this.txCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCode.Location = new System.Drawing.Point(103, 101);
            this.txCode.Name = "txCode";
            this.txCode.Size = new System.Drawing.Size(49, 22);
            this.txCode.TabIndex = 3;
            this.txCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txCant
            // 
            this.txCant.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCant.Location = new System.Drawing.Point(103, 75);
            this.txCant.Name = "txCant";
            this.txCant.Size = new System.Drawing.Size(49, 22);
            this.txCant.TabIndex = 2;
            this.txCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txName.Location = new System.Drawing.Point(59, 24);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(93, 22);
            this.txName.TabIndex = 0;
            this.txName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txPrice
            // 
            this.txPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.Location = new System.Drawing.Point(103, 50);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(49, 22);
            this.txPrice.TabIndex = 1;
            this.txPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:                 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(42, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.txName);
            this.gbProduct.Controls.Add(this.txCode);
            this.gbProduct.Controls.Add(this.btnAdd);
            this.gbProduct.Controls.Add(this.label4);
            this.gbProduct.Controls.Add(this.txCant);
            this.gbProduct.Controls.Add(this.label3);
            this.gbProduct.Controls.Add(this.label2);
            this.gbProduct.Controls.Add(this.label1);
            this.gbProduct.Controls.Add(this.txPrice);
            this.gbProduct.Location = new System.Drawing.Point(12, 11);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(167, 211);
            this.gbProduct.TabIndex = 9;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Producto";
            // 
            // gbInv
            // 
            this.gbInv.Controls.Add(this.label6);
            this.gbInv.Controls.Add(this.txHowMany);
            this.gbInv.Controls.Add(this.btnBuy);
            this.gbInv.Controls.Add(this.btnSell);
            this.gbInv.Controls.Add(this.txInv);
            this.gbInv.Controls.Add(this.btnDelete);
            this.gbInv.Controls.Add(this.btnSearch);
            this.gbInv.Controls.Add(this.txSearchCode);
            this.gbInv.Controls.Add(this.label5);
            this.gbInv.Controls.Add(this.btnShow);
            this.gbInv.Location = new System.Drawing.Point(185, 12);
            this.gbInv.Name = "gbInv";
            this.gbInv.Size = new System.Drawing.Size(417, 210);
            this.gbInv.TabIndex = 10;
            this.gbInv.TabStop = false;
            this.gbInv.Text = "Inventario";
            // 
            // txInv
            // 
            this.txInv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInv.Location = new System.Drawing.Point(127, 19);
            this.txInv.Multiline = true;
            this.txInv.Name = "txInv";
            this.txInv.ReadOnly = true;
            this.txInv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txInv.Size = new System.Drawing.Size(286, 136);
            this.txInv.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(6, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(6, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txSearchCode
            // 
            this.txSearchCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearchCode.Location = new System.Drawing.Point(55, 20);
            this.txSearchCode.Name = "txSearchCode";
            this.txSearchCode.Size = new System.Drawing.Size(49, 22);
            this.txSearchCode.TabIndex = 5;
            this.txSearchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Código:";
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(336, 181);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Mostrar lista";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(9, 152);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Vender";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(9, 181);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Adquirir";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txHowMany
            // 
            this.txHowMany.Location = new System.Drawing.Point(186, 183);
            this.txHowMany.Name = "txHowMany";
            this.txHowMany.Size = new System.Drawing.Size(68, 20);
            this.txHowMany.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad:";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 234);
            this.Controls.Add(this.gbInv);
            this.Controls.Add(this.gbProduct);
            this.Name = "Window1";
            this.Text = "Inventario";
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.gbInv.ResumeLayout(false);
            this.gbInv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txCode;
        private System.Windows.Forms.TextBox txCant;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.GroupBox gbInv;
        private System.Windows.Forms.TextBox txInv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txSearchCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txHowMany;
    }
}

