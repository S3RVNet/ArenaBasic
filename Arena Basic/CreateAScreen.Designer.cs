namespace Arena_Basic
{
    partial class FmCAS
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
            this.btnCASset = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCASname = new System.Windows.Forms.Label();
            this.lblCASwarriorTp = new System.Windows.Forms.Label();
            this.lbxCASenemy = new System.Windows.Forms.ListBox();
            this.lblCASenemySelect = new System.Windows.Forms.Label();
            this.btnCASsave = new System.Windows.Forms.Button();
            this.lblCASWarrior = new System.Windows.Forms.Label();
            this.lblCASArcher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCASset
            // 
            this.btnCASset.Location = new System.Drawing.Point(157, 97);
            this.btnCASset.Name = "btnCASset";
            this.btnCASset.Size = new System.Drawing.Size(56, 30);
            this.btnCASset.TabIndex = 0;
            this.btnCASset.Text = "Set";
            this.btnCASset.UseVisualStyleBackColor = true;
            this.btnCASset.Click += new System.EventHandler(this.btnCASset_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblCASname
            // 
            this.lblCASname.AutoSize = true;
            this.lblCASname.Location = new System.Drawing.Point(12, 87);
            this.lblCASname.Name = "lblCASname";
            this.lblCASname.Size = new System.Drawing.Size(70, 13);
            this.lblCASname.TabIndex = 4;
            this.lblCASname.Text = "Player Name:";
            // 
            // lblCASwarriorTp
            // 
            this.lblCASwarriorTp.AutoSize = true;
            this.lblCASwarriorTp.Location = new System.Drawing.Point(5, 203);
            this.lblCASwarriorTp.Name = "lblCASwarriorTp";
            this.lblCASwarriorTp.Size = new System.Drawing.Size(77, 13);
            this.lblCASwarriorTp.TabIndex = 5;
            this.lblCASwarriorTp.Text = "Select a Class:";
            // 
            // lbxCASenemy
            // 
            this.lbxCASenemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxCASenemy.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCASenemy.FormattingEnabled = true;
            this.lbxCASenemy.ItemHeight = 34;
            this.lbxCASenemy.Items.AddRange(new object[] {
            "Void Knight",
            "Brother",
            "Prince",
            "Warlord"});
            this.lbxCASenemy.Location = new System.Drawing.Point(543, 97);
            this.lbxCASenemy.Name = "lbxCASenemy";
            this.lbxCASenemy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxCASenemy.Size = new System.Drawing.Size(119, 410);
            this.lbxCASenemy.TabIndex = 6;
            this.lbxCASenemy.SelectedValueChanged += new System.EventHandler(this.lbxCASenemy_SelectedValueChanged);
            // 
            // lblCASenemySelect
            // 
            this.lblCASenemySelect.AutoSize = true;
            this.lblCASenemySelect.Location = new System.Drawing.Point(556, 81);
            this.lblCASenemySelect.Name = "lblCASenemySelect";
            this.lblCASenemySelect.Size = new System.Drawing.Size(86, 13);
            this.lblCASenemySelect.TabIndex = 7;
            this.lblCASenemySelect.Text = "Select an enemy";
            // 
            // btnCASsave
            // 
            this.btnCASsave.Location = new System.Drawing.Point(286, 562);
            this.btnCASsave.Name = "btnCASsave";
            this.btnCASsave.Size = new System.Drawing.Size(168, 55);
            this.btnCASsave.TabIndex = 8;
            this.btnCASsave.Text = "Save And Launch";
            this.btnCASsave.UseVisualStyleBackColor = true;
            this.btnCASsave.Click += new System.EventHandler(this.btnCASsave_Click);
            // 
            // lblCASWarrior
            // 
            this.lblCASWarrior.AutoSize = true;
            this.lblCASWarrior.Location = new System.Drawing.Point(15, 232);
            this.lblCASWarrior.Name = "lblCASWarrior";
            this.lblCASWarrior.Size = new System.Drawing.Size(41, 13);
            this.lblCASWarrior.TabIndex = 9;
            this.lblCASWarrior.Text = "Warrior";
            this.lblCASWarrior.Click += new System.EventHandler(this.lblCASWarrior_Click);
            // 
            // lblCASArcher
            // 
            this.lblCASArcher.AutoSize = true;
            this.lblCASArcher.Location = new System.Drawing.Point(12, 269);
            this.lblCASArcher.Name = "lblCASArcher";
            this.lblCASArcher.Size = new System.Drawing.Size(38, 13);
            this.lblCASArcher.TabIndex = 10;
            this.lblCASArcher.Text = "Archer";
            this.lblCASArcher.Click += new System.EventHandler(this.lblCASArcher_Click);
            // 
            // FmCAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 629);
            this.Controls.Add(this.lblCASArcher);
            this.Controls.Add(this.lblCASWarrior);
            this.Controls.Add(this.btnCASsave);
            this.Controls.Add(this.lblCASenemySelect);
            this.Controls.Add(this.lbxCASenemy);
            this.Controls.Add(this.lblCASwarriorTp);
            this.Controls.Add(this.lblCASname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCASset);
            this.Name = "FmCAS";
            this.Text = "Create A Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCASset;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCASname;
        private System.Windows.Forms.Label lblCASwarriorTp;
        private System.Windows.Forms.ListBox lbxCASenemy;
        private System.Windows.Forms.Label lblCASenemySelect;
        private System.Windows.Forms.Button btnCASsave;
        private System.Windows.Forms.Label lblCASWarrior;
        private System.Windows.Forms.Label lblCASArcher;
    }
}