namespace MegaDesk_PokhrelAshish
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchQuoteBtn = new System.Windows.Forms.Button();
            this.displayQuoteBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Location = new System.Drawing.Point(59, 30);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(188, 57);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "Add Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.AddQuoteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(59, 290);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(188, 57);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // searchQuoteBtn
            // 
            this.searchQuoteBtn.Location = new System.Drawing.Point(59, 208);
            this.searchQuoteBtn.Name = "searchQuoteBtn";
            this.searchQuoteBtn.Size = new System.Drawing.Size(188, 57);
            this.searchQuoteBtn.TabIndex = 2;
            this.searchQuoteBtn.Text = "Search Quotes";
            this.searchQuoteBtn.UseVisualStyleBackColor = true;
            this.searchQuoteBtn.Click += new System.EventHandler(this.SearchQuoteBtn_Click);
            // 
            // displayQuoteBtn
            // 
            this.displayQuoteBtn.Location = new System.Drawing.Point(59, 119);
            this.displayQuoteBtn.Name = "displayQuoteBtn";
            this.displayQuoteBtn.Size = new System.Drawing.Size(188, 57);
            this.displayQuoteBtn.TabIndex = 3;
            this.displayQuoteBtn.Text = "Display Quotes";
            this.displayQuoteBtn.UseVisualStyleBackColor = true;
            this.displayQuoteBtn.Click += new System.EventHandler(this.DisplayQuoteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 317);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayQuoteBtn);
            this.Controls.Add(this.searchQuoteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.Name = "mainMenu";
            this.Text = "menMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button searchQuoteBtn;
        private System.Windows.Forms.Button displayQuoteBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

