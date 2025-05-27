namespace WouldYouSurvive_Horror
{
    partial class WouldYouSurviveInteractive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WouldYouSurviveInteractive));
            this.Title = new System.Windows.Forms.Label();
            this.lblSQ = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Chiller", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Snow;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Title.Location = new System.Drawing.Point(324, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(617, 71);
            this.Title.TabIndex = 0;
            this.Title.Text = "Would you Survive?";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSQ
            // 
            this.lblSQ.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQ.ForeColor = System.Drawing.Color.Snow;
            this.lblSQ.Location = new System.Drawing.Point(113, 80);
            this.lblSQ.Name = "lblSQ";
            this.lblSQ.Size = new System.Drawing.Size(1034, 308);
            this.lblSQ.TabIndex = 1;
            this.lblSQ.Text = "label1";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Red;
            this.btnYes.ForeColor = System.Drawing.Color.Snow;
            this.btnYes.Location = new System.Drawing.Point(119, 429);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(253, 65);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.ForeColor = System.Drawing.Color.Snow;
            this.btnNo.Location = new System.Drawing.Point(894, 429);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(253, 65);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(496, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Over";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WouldYouSurviveInteractive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblSQ);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "WouldYouSurviveInteractive";
            this.Text = "Would You Survive?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblSQ;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button button1;
    }
}

