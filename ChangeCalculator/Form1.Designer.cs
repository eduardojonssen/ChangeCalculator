namespace ChangeCalculator {
    partial class FormChangeCalculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbValorProduto = new System.Windows.Forms.Label();
            this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
            this.UxTxtPaidAmount = new System.Windows.Forms.TextBox();
            this.UxTxtChange = new System.Windows.Forms.TextBox();
            this.lbValorMontante = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.UxBtnCalculate = new System.Windows.Forms.Button();
            this.UxTxtChangeLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbValorProduto
            // 
            this.lbValorProduto.AutoSize = true;
            this.lbValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorProduto.Location = new System.Drawing.Point(39, 55);
            this.lbValorProduto.Name = "lbValorProduto";
            this.lbValorProduto.Size = new System.Drawing.Size(269, 37);
            this.lbValorProduto.TabIndex = 0;
            this.lbValorProduto.Text = "Valor do Produto:";
            // 
            // UxTxtProductAmount
            // 
            this.UxTxtProductAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxTxtProductAmount.Location = new System.Drawing.Point(345, 52);
            this.UxTxtProductAmount.Name = "UxTxtProductAmount";
            this.UxTxtProductAmount.Size = new System.Drawing.Size(881, 44);
            this.UxTxtProductAmount.TabIndex = 1;
            // 
            // UxTxtPaidAmount
            // 
            this.UxTxtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxTxtPaidAmount.Location = new System.Drawing.Point(345, 113);
            this.UxTxtPaidAmount.Name = "UxTxtPaidAmount";
            this.UxTxtPaidAmount.Size = new System.Drawing.Size(881, 44);
            this.UxTxtPaidAmount.TabIndex = 2;
            // 
            // UxTxtChange
            // 
            this.UxTxtChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxTxtChange.Location = new System.Drawing.Point(345, 182);
            this.UxTxtChange.Multiline = true;
            this.UxTxtChange.Name = "UxTxtChange";
            this.UxTxtChange.ReadOnly = true;
            this.UxTxtChange.Size = new System.Drawing.Size(881, 170);
            this.UxTxtChange.TabIndex = 3;
            // 
            // lbValorMontante
            // 
            this.lbValorMontante.AutoSize = true;
            this.lbValorMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorMontante.Location = new System.Drawing.Point(39, 120);
            this.lbValorMontante.Name = "lbValorMontante";
            this.lbValorMontante.Size = new System.Drawing.Size(186, 37);
            this.lbValorMontante.TabIndex = 4;
            this.lbValorMontante.Text = "Valor Pago:";
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroco.Location = new System.Drawing.Point(39, 189);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(109, 37);
            this.lbTroco.TabIndex = 5;
            this.lbTroco.Text = "Troco:";
            // 
            // UxBtnCalculate
            // 
            this.UxBtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxBtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxBtnCalculate.Location = new System.Drawing.Point(167, 566);
            this.UxBtnCalculate.Name = "UxBtnCalculate";
            this.UxBtnCalculate.Size = new System.Drawing.Size(876, 50);
            this.UxBtnCalculate.TabIndex = 6;
            this.UxBtnCalculate.Text = "Calcular";
            this.UxBtnCalculate.UseVisualStyleBackColor = true;
            this.UxBtnCalculate.Click += new System.EventHandler(this.UxBtnCalculate_Click);
            // 
            // UxTxtChangeLog
            // 
            this.UxTxtChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtChangeLog.Location = new System.Drawing.Point(345, 377);
            this.UxTxtChangeLog.Multiline = true;
            this.UxTxtChangeLog.Name = "UxTxtChangeLog";
            this.UxTxtChangeLog.Size = new System.Drawing.Size(881, 159);
            this.UxTxtChangeLog.TabIndex = 7;
            // 
            // FormChangeCalculator
            // 
            this.AcceptButton = this.UxBtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 656);
            this.Controls.Add(this.UxTxtChangeLog);
            this.Controls.Add(this.UxBtnCalculate);
            this.Controls.Add(this.lbTroco);
            this.Controls.Add(this.lbValorMontante);
            this.Controls.Add(this.UxTxtChange);
            this.Controls.Add(this.UxTxtPaidAmount);
            this.Controls.Add(this.UxTxtProductAmount);
            this.Controls.Add(this.lbValorProduto);
            this.Name = "FormChangeCalculator";
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValorProduto;
        private System.Windows.Forms.TextBox UxTxtProductAmount;
        private System.Windows.Forms.TextBox UxTxtPaidAmount;
        private System.Windows.Forms.TextBox UxTxtChange;
        private System.Windows.Forms.Label lbValorMontante;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Button UxBtnCalculate;
        private System.Windows.Forms.TextBox UxTxtChangeLog;
    }
}

