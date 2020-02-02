namespace MegaDesk_PokhrelAshish
{
    partial class AddQuotes
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cusNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthUpDwnBtn = new System.Windows.Forms.NumericUpDown();
            this.heightUpDwnBtn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numOfDrawUpDwn = new System.Windows.Forms.NumericUpDown();
            this.surfaceMateComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.getQuoteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDwnBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDwnBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrawUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(419, 334);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(142, 33);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // cusNameTxtBox
            // 
            this.cusNameTxtBox.Location = new System.Drawing.Point(194, 37);
            this.cusNameTxtBox.Name = "cusNameTxtBox";
            this.cusNameTxtBox.Size = new System.Drawing.Size(185, 20);
            this.cusNameTxtBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.heightUpDwnBtn);
            this.groupBox1.Controls.Add(this.widthUpDwnBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            // 
            // widthUpDwnBtn
            // 
            this.widthUpDwnBtn.Location = new System.Drawing.Point(97, 30);
            this.widthUpDwnBtn.Name = "widthUpDwnBtn";
            this.widthUpDwnBtn.Size = new System.Drawing.Size(110, 23);
            this.widthUpDwnBtn.TabIndex = 6;
            // 
            // heightUpDwnBtn
            // 
            this.heightUpDwnBtn.Location = new System.Drawing.Point(97, 61);
            this.heightUpDwnBtn.Name = "heightUpDwnBtn";
            this.heightUpDwnBtn.Size = new System.Drawing.Size(110, 23);
            this.heightUpDwnBtn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delivery";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Drawers";
            // 
            // numOfDrawUpDwn
            // 
            this.numOfDrawUpDwn.Location = new System.Drawing.Point(513, 100);
            this.numOfDrawUpDwn.Name = "numOfDrawUpDwn";
            this.numOfDrawUpDwn.Size = new System.Drawing.Size(56, 20);
            this.numOfDrawUpDwn.TabIndex = 8;
            // 
            // surfaceMateComboBox
            // 
            this.surfaceMateComboBox.FormattingEnabled = true;
            this.surfaceMateComboBox.Location = new System.Drawing.Point(513, 133);
            this.surfaceMateComboBox.Name = "surfaceMateComboBox";
            this.surfaceMateComboBox.Size = new System.Drawing.Size(121, 21);
            this.surfaceMateComboBox.TabIndex = 11;
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Location = new System.Drawing.Point(513, 166);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(121, 21);
            this.deliveryComboBox.TabIndex = 12;
            // 
            // getQuoteBtn
            // 
            this.getQuoteBtn.Location = new System.Drawing.Point(237, 334);
            this.getQuoteBtn.Name = "getQuoteBtn";
            this.getQuoteBtn.Size = new System.Drawing.Size(142, 33);
            this.getQuoteBtn.TabIndex = 13;
            this.getQuoteBtn.Text = "Get Quote";
            this.getQuoteBtn.UseVisualStyleBackColor = true;
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getQuoteBtn);
            this.Controls.Add(this.deliveryComboBox);
            this.Controls.Add(this.surfaceMateComboBox);
            this.Controls.Add(this.numOfDrawUpDwn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cusNameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Name = "AddQuotes";
            this.Text = "AddQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuotes_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDwnBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDwnBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrawUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusNameTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown heightUpDwnBtn;
        private System.Windows.Forms.NumericUpDown widthUpDwnBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numOfDrawUpDwn;
        private System.Windows.Forms.ComboBox surfaceMateComboBox;
        private System.Windows.Forms.ComboBox deliveryComboBox;
        private System.Windows.Forms.Button getQuoteBtn;
    }
}