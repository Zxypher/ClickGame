namespace WindowsFormsApplication5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.add = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.invest = new System.Windows.Forms.Button();
            this.reward = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reward)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 137);
            this.add.TabIndex = 0;
            this.add.Text = "make it raaaiiin";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(163, 71);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(10, 13);
            this.count.TabIndex = 1;
            this.count.Text = " ";
            // 
            // invest
            // 
            this.invest.Location = new System.Drawing.Point(12, 152);
            this.invest.Name = "invest";
            this.invest.Size = new System.Drawing.Size(55, 48);
            this.invest.TabIndex = 2;
            this.invest.Text = "invest";
            this.invest.UseVisualStyleBackColor = true;
            this.invest.Click += new System.EventHandler(this.button2_Click);
            // 
            // reward
            // 
            this.reward.Image = ((System.Drawing.Image)(resources.GetObject("reward.Image")));
            this.reward.Location = new System.Drawing.Point(108, 96);
            this.reward.Name = "reward";
            this.reward.Size = new System.Drawing.Size(179, 169);
            this.reward.TabIndex = 3;
            this.reward.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reward);
            this.Controls.Add(this.invest);
            this.Controls.Add(this.count);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.reward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button invest;
        private System.Windows.Forms.PictureBox reward;
    }
}

