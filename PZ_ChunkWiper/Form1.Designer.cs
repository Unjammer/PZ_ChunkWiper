namespace PZ_ChunkWiper
{
    partial class PZ_ChunkWiper
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbx_ChunkY2 = new System.Windows.Forms.NumericUpDown();
            this.tbx_ChunkX2 = new System.Windows.Forms.NumericUpDown();
            this.tbx_ChunkY = new System.Windows.Forms.NumericUpDown();
            this.tbx_ChunkX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_Zone = new System.Windows.Forms.RadioButton();
            this.rb_SingleCell = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChunkPath = new System.Windows.Forms.Button();
            this.btn_ChunkReset = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbx_Zombies = new System.Windows.Forms.CheckBox();
            this.cbx_Vehicles = new System.Windows.Forms.CheckBox();
            this.lbl_ChunkPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Save = new System.Windows.Forms.RadioButton();
            this.rb_Wipe = new System.Windows.Forms.RadioButton();
            this.cbx_Age = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_ChunkPath);
            this.groupBox4.Controls.Add(this.tbx_ChunkY2);
            this.groupBox4.Controls.Add(this.tbx_ChunkX2);
            this.groupBox4.Controls.Add(this.tbx_ChunkY);
            this.groupBox4.Controls.Add(this.tbx_ChunkX);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rb_Zone);
            this.groupBox4.Controls.Add(this.rb_SingleCell);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_ChunkPath);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 102);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Map";
            // 
            // tbx_ChunkY2
            // 
            this.tbx_ChunkY2.Enabled = false;
            this.tbx_ChunkY2.Location = new System.Drawing.Point(347, 74);
            this.tbx_ChunkY2.Name = "tbx_ChunkY2";
            this.tbx_ChunkY2.Size = new System.Drawing.Size(62, 20);
            this.tbx_ChunkY2.TabIndex = 7;
            this.tbx_ChunkY2.ValueChanged += new System.EventHandler(this.tbx_ChunkY2_ValueChanged);
            // 
            // tbx_ChunkX2
            // 
            this.tbx_ChunkX2.Enabled = false;
            this.tbx_ChunkX2.Location = new System.Drawing.Point(252, 74);
            this.tbx_ChunkX2.Name = "tbx_ChunkX2";
            this.tbx_ChunkX2.Size = new System.Drawing.Size(62, 20);
            this.tbx_ChunkX2.TabIndex = 6;
            this.tbx_ChunkX2.ValueChanged += new System.EventHandler(this.tbx_ChunkX2_ValueChanged);
            // 
            // tbx_ChunkY
            // 
            this.tbx_ChunkY.Location = new System.Drawing.Point(347, 48);
            this.tbx_ChunkY.Name = "tbx_ChunkY";
            this.tbx_ChunkY.Size = new System.Drawing.Size(62, 20);
            this.tbx_ChunkY.TabIndex = 5;
            this.tbx_ChunkY.ValueChanged += new System.EventHandler(this.tbx_ChunkY_ValueChanged);
            // 
            // tbx_ChunkX
            // 
            this.tbx_ChunkX.Location = new System.Drawing.Point(252, 48);
            this.tbx_ChunkX.Name = "tbx_ChunkX";
            this.tbx_ChunkX.Size = new System.Drawing.Size(62, 20);
            this.tbx_ChunkX.TabIndex = 4;
            this.tbx_ChunkX.ValueChanged += new System.EventHandler(this.tbx_ChunkX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "To Cell :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "X:";
            // 
            // rb_Zone
            // 
            this.rb_Zone.AutoSize = true;
            this.rb_Zone.Location = new System.Drawing.Point(11, 75);
            this.rb_Zone.Name = "rb_Zone";
            this.rb_Zone.Size = new System.Drawing.Size(50, 17);
            this.rb_Zone.TabIndex = 3;
            this.rb_Zone.Text = "Zone";
            this.rb_Zone.UseVisualStyleBackColor = true;
            this.rb_Zone.CheckedChanged += new System.EventHandler(this.rb_Zone_CheckedChanged);
            // 
            // rb_SingleCell
            // 
            this.rb_SingleCell.AutoSize = true;
            this.rb_SingleCell.Checked = true;
            this.rb_SingleCell.Location = new System.Drawing.Point(11, 49);
            this.rb_SingleCell.Name = "rb_SingleCell";
            this.rb_SingleCell.Size = new System.Drawing.Size(74, 17);
            this.rb_SingleCell.TabIndex = 2;
            this.rb_SingleCell.TabStop = true;
            this.rb_SingleCell.Text = "Single Cell";
            this.rb_SingleCell.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(167, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "From Cell :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Y:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(229, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "X:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Map directory :";
            // 
            // btn_ChunkPath
            // 
            this.btn_ChunkPath.Location = new System.Drawing.Point(100, 19);
            this.btn_ChunkPath.Name = "btn_ChunkPath";
            this.btn_ChunkPath.Size = new System.Drawing.Size(41, 23);
            this.btn_ChunkPath.TabIndex = 1;
            this.btn_ChunkPath.Text = "...";
            this.btn_ChunkPath.UseVisualStyleBackColor = true;
            this.btn_ChunkPath.Click += new System.EventHandler(this.btn_ChunkPath_Click);
            // 
            // btn_ChunkReset
            // 
            this.btn_ChunkReset.Enabled = false;
            this.btn_ChunkReset.Location = new System.Drawing.Point(11, 126);
            this.btn_ChunkReset.Name = "btn_ChunkReset";
            this.btn_ChunkReset.Size = new System.Drawing.Size(187, 40);
            this.btn_ChunkReset.TabIndex = 8;
            this.btn_ChunkReset.Text = "Reset";
            this.btn_ChunkReset.UseVisualStyleBackColor = true;
            this.btn_ChunkReset.Click += new System.EventHandler(this.btn_ChunkReset_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 295);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(415, 454);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // cbx_Zombies
            // 
            this.cbx_Zombies.AutoSize = true;
            this.cbx_Zombies.Checked = true;
            this.cbx_Zombies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_Zombies.Enabled = false;
            this.cbx_Zombies.Location = new System.Drawing.Point(12, 80);
            this.cbx_Zombies.Name = "cbx_Zombies";
            this.cbx_Zombies.Size = new System.Drawing.Size(96, 17);
            this.cbx_Zombies.TabIndex = 27;
            this.cbx_Zombies.Text = "Clean Zombies";
            this.cbx_Zombies.UseVisualStyleBackColor = true;
            // 
            // cbx_Vehicles
            // 
            this.cbx_Vehicles.AutoSize = true;
            this.cbx_Vehicles.Enabled = false;
            this.cbx_Vehicles.Location = new System.Drawing.Point(12, 103);
            this.cbx_Vehicles.Name = "cbx_Vehicles";
            this.cbx_Vehicles.Size = new System.Drawing.Size(96, 17);
            this.cbx_Vehicles.TabIndex = 28;
            this.cbx_Vehicles.Text = "Clean Vehicles";
            this.cbx_Vehicles.UseVisualStyleBackColor = true;
            // 
            // lbl_ChunkPath
            // 
            this.lbl_ChunkPath.Location = new System.Drawing.Point(147, 21);
            this.lbl_ChunkPath.Name = "lbl_ChunkPath";
            this.lbl_ChunkPath.ReadOnly = true;
            this.lbl_ChunkPath.Size = new System.Drawing.Size(262, 20);
            this.lbl_ChunkPath.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Age);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.rb_Save);
            this.groupBox1.Controls.Add(this.rb_Wipe);
            this.groupBox1.Controls.Add(this.cbx_Zombies);
            this.groupBox1.Controls.Add(this.cbx_Vehicles);
            this.groupBox1.Controls.Add(this.btn_ChunkReset);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 178);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // rb_Save
            // 
            this.rb_Save.AutoSize = true;
            this.rb_Save.Checked = true;
            this.rb_Save.Location = new System.Drawing.Point(246, 19);
            this.rb_Save.Name = "rb_Save";
            this.rb_Save.Size = new System.Drawing.Size(95, 17);
            this.rb_Save.TabIndex = 30;
            this.rb_Save.TabStop = true;
            this.rb_Save.Text = "Save Chunk(s)";
            this.rb_Save.UseVisualStyleBackColor = true;
            this.rb_Save.CheckedChanged += new System.EventHandler(this.rb_Save_CheckedChanged);
            // 
            // rb_Wipe
            // 
            this.rb_Wipe.AutoSize = true;
            this.rb_Wipe.Location = new System.Drawing.Point(70, 19);
            this.rb_Wipe.Name = "rb_Wipe";
            this.rb_Wipe.Size = new System.Drawing.Size(95, 17);
            this.rb_Wipe.TabIndex = 29;
            this.rb_Wipe.Text = "Wipe Chunk(s)";
            this.rb_Wipe.UseVisualStyleBackColor = true;
            this.rb_Wipe.CheckedChanged += new System.EventHandler(this.rb_Wipe_CheckedChanged);
            // 
            // cbx_Age
            // 
            this.cbx_Age.AutoSize = true;
            this.cbx_Age.Checked = true;
            this.cbx_Age.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_Age.Location = new System.Drawing.Point(222, 103);
            this.cbx_Age.Name = "cbx_Age";
            this.cbx_Age.Size = new System.Drawing.Size(103, 17);
            this.cbx_Age.TabIndex = 32;
            this.cbx_Age.Text = "Save World age";
            this.cbx_Age.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(222, 126);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(187, 40);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // PZ_ChunkWiper
            // 
            this.AcceptButton = this.btn_ChunkReset;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(439, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(455, 800);
            this.MinimumSize = new System.Drawing.Size(455, 538);
            this.Name = "PZ_ChunkWiper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PZ_ChunkWiper";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_ChunkX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChunkPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_Zone;
        private System.Windows.Forms.RadioButton rb_SingleCell;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_ChunkReset;
        private System.Windows.Forms.NumericUpDown tbx_ChunkY2;
        private System.Windows.Forms.NumericUpDown tbx_ChunkX2;
        private System.Windows.Forms.NumericUpDown tbx_ChunkY;
        private System.Windows.Forms.NumericUpDown tbx_ChunkX;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cbx_Zombies;
        private System.Windows.Forms.CheckBox cbx_Vehicles;
        private System.Windows.Forms.TextBox lbl_ChunkPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_Age;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.RadioButton rb_Save;
        private System.Windows.Forms.RadioButton rb_Wipe;
    }
}

