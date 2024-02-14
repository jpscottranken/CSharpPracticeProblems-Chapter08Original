namespace Practice8_1
{
    partial class frmOddsAndEvens
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnFillArray = new System.Windows.Forms.Button();
            this.btnShowOddNumbers = new System.Windows.Forms.Button();
            this.btnShowEvenNumbers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHeading.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(55, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(692, 55);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "Click the Fill Array Button To Show Odd Or Even #s";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.White;
            this.txtResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(58, 107);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(689, 210);
            this.txtResults.TabIndex = 5;
            // 
            // btnFillArray
            // 
            this.btnFillArray.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillArray.Location = new System.Drawing.Point(58, 336);
            this.btnFillArray.Name = "btnFillArray";
            this.btnFillArray.Size = new System.Drawing.Size(166, 69);
            this.btnFillArray.TabIndex = 0;
            this.btnFillArray.Text = "&Fill Array";
            this.btnFillArray.UseVisualStyleBackColor = true;
            this.btnFillArray.Click += new System.EventHandler(this.btnFillArray_Click);
            // 
            // btnShowOddNumbers
            // 
            this.btnShowOddNumbers.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOddNumbers.Location = new System.Drawing.Point(310, 336);
            this.btnShowOddNumbers.Name = "btnShowOddNumbers";
            this.btnShowOddNumbers.Size = new System.Drawing.Size(166, 69);
            this.btnShowOddNumbers.TabIndex = 1;
            this.btnShowOddNumbers.Text = "Show Odd #s";
            this.btnShowOddNumbers.UseVisualStyleBackColor = true;
            this.btnShowOddNumbers.Click += new System.EventHandler(this.btnShowOddNumbers_Click);
            // 
            // btnShowEvenNumbers
            // 
            this.btnShowEvenNumbers.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEvenNumbers.Location = new System.Drawing.Point(569, 336);
            this.btnShowEvenNumbers.Name = "btnShowEvenNumbers";
            this.btnShowEvenNumbers.Size = new System.Drawing.Size(178, 69);
            this.btnShowEvenNumbers.TabIndex = 2;
            this.btnShowEvenNumbers.Text = "Show Even #s";
            this.btnShowEvenNumbers.UseVisualStyleBackColor = true;
            this.btnShowEvenNumbers.Click += new System.EventHandler(this.btnShowEvenNumbers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(581, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 69);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(310, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 69);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmOddsAndEvens
            // 
            this.AcceptButton = this.btnFillArray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowEvenNumbers);
            this.Controls.Add(this.btnShowOddNumbers);
            this.Controls.Add(this.btnFillArray);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmOddsAndEvens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odds And Evens - Practice 8-1";
            this.Load += new System.EventHandler(this.frmOddsAndEvens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnFillArray;
        private System.Windows.Forms.Button btnShowOddNumbers;
        private System.Windows.Forms.Button btnShowEvenNumbers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

