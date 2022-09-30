namespace Activity_6
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
            this.btnKG = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtNewWeight = new System.Windows.Forms.TextBox();
            this.btnLBS = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblNewWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKG
            // 
            this.btnKG.Location = new System.Drawing.Point(183, 167);
            this.btnKG.Name = "btnKG";
            this.btnKG.Size = new System.Drawing.Size(118, 52);
            this.btnKG.TabIndex = 0;
            this.btnKG.Text = "LBS to KG";
            this.btnKG.UseVisualStyleBackColor = true;
            this.btnKG.Click += new System.EventHandler(this.btnKG_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(140, 99);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(161, 22);
            this.txtWeight.TabIndex = 1;
            // 
            // txtNewWeight
            // 
            this.txtNewWeight.Location = new System.Drawing.Point(140, 128);
            this.txtNewWeight.Name = "txtNewWeight";
            this.txtNewWeight.Size = new System.Drawing.Size(161, 22);
            this.txtNewWeight.TabIndex = 2;
            // 
            // btnLBS
            // 
            this.btnLBS.Location = new System.Drawing.Point(54, 167);
            this.btnLBS.Name = "btnLBS";
            this.btnLBS.Size = new System.Drawing.Size(123, 52);
            this.btnLBS.TabIndex = 3;
            this.btnLBS.Text = "KG to LBS";
            this.btnLBS.UseVisualStyleBackColor = true;
            this.btnLBS.Click += new System.EventHandler(this.btnLBS_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.4F);
            this.lblTitle.Location = new System.Drawing.Point(46, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 33);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Weight Conversion";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(51, 102);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 16);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Your Weight";
            // 
            // lblNewWeight
            // 
            this.lblNewWeight.AutoSize = true;
            this.lblNewWeight.Location = new System.Drawing.Point(51, 131);
            this.lblNewWeight.Name = "lblNewWeight";
            this.lblNewWeight.Size = new System.Drawing.Size(80, 16);
            this.lblNewWeight.TabIndex = 8;
            this.lblNewWeight.Text = "Converts To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(376, 339);
            this.Controls.Add(this.lblNewWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLBS);
            this.Controls.Add(this.txtNewWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnKG);
            this.Name = "Form1";
            this.Text = "Activity 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKG;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtNewWeight;
        private System.Windows.Forms.Button btnLBS;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblNewWeight;
    }
}

