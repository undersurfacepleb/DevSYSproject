namespace techR
{
    partial class telaLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.tb1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb2 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(289, 211);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(237, 20);
            this.tb1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(289, 331);
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '*';
            this.tb2.Size = new System.Drawing.Size(237, 20);
            this.tb2.TabIndex = 2;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.bt1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bt1.ForeColor = System.Drawing.Color.Navy;
            this.bt1.Location = new System.Drawing.Point(351, 377);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(142, 41);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "&ENTRAR";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::techR.Properties.Resources.login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 511);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "telaLogin";
            this.Text = "GraveTechYard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.telaLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button bt1;
    }
}

