
namespace techR
{
    partial class frFinado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFinado));
            this.btSave = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvReadData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(239, 307);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(139, 54);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(303, 387);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(222, 387);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(141, 387);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(239, 247);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(157, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(239, 202);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(157, 20);
            this.tbAdress.TabIndex = 6;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(239, 155);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(157, 20);
            this.tbDate.TabIndex = 7;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(239, 113);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(157, 20);
            this.tbCPF.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(239, 72);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(157, 20);
            this.tbName.TabIndex = 9;
            // 
            // dgvReadData
            // 
            this.dgvReadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadData.Location = new System.Drawing.Point(414, 72);
            this.dgvReadData.Name = "dgvReadData";
            this.dgvReadData.Size = new System.Drawing.Size(360, 338);
            this.dgvReadData.TabIndex = 10;
            this.dgvReadData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReadData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Morte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::techR.Properties.Resources.Grim_Reaper_PNG_Clipart;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frFinado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvReadData);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frFinado";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dgvReadData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}