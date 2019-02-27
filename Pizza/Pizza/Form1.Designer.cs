namespace Pizza
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
            this.gbAlegere = new System.Windows.Forms.GroupBox();
            this.chkPui = new System.Windows.Forms.CheckBox();
            this.chkPorumb = new System.Windows.Forms.CheckBox();
            this.chkCiuperci = new System.Windows.Forms.CheckBox();
            this.chkTon = new System.Windows.Forms.CheckBox();
            this.gbDimensiune = new System.Windows.Forms.GroupBox();
            this.rbMedie = new System.Windows.Forms.RadioButton();
            this.rbMare = new System.Windows.Forms.RadioButton();
            this.rbMica = new System.Windows.Forms.RadioButton();
            this.cboSortiment = new System.Windows.Forms.ComboBox();
            this.pbPizza = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.lbPret = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbComanda = new System.Windows.Forms.Label();
            this.lstPret = new System.Windows.Forms.ListBox();
            this.gbAlegere.SuspendLayout();
            this.gbDimensiune.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlegere
            // 
            this.gbAlegere.Controls.Add(this.chkPui);
            this.gbAlegere.Controls.Add(this.chkPorumb);
            this.gbAlegere.Controls.Add(this.chkCiuperci);
            this.gbAlegere.Controls.Add(this.chkTon);
            this.gbAlegere.Location = new System.Drawing.Point(423, 73);
            this.gbAlegere.Name = "gbAlegere";
            this.gbAlegere.Size = new System.Drawing.Size(208, 216);
            this.gbAlegere.TabIndex = 0;
            this.gbAlegere.TabStop = false;
            this.gbAlegere.Text = "Alegeti ingredientele";
            // 
            // chkPui
            // 
            this.chkPui.AutoSize = true;
            this.chkPui.Location = new System.Drawing.Point(22, 112);
            this.chkPui.Name = "chkPui";
            this.chkPui.Size = new System.Drawing.Size(145, 21);
            this.chkPui.TabIndex = 3;
            this.chkPui.Text = "Pui                5 Lei";
            this.chkPui.UseVisualStyleBackColor = true;
            // 
            // chkPorumb
            // 
            this.chkPorumb.AutoSize = true;
            this.chkPorumb.Location = new System.Drawing.Point(22, 151);
            this.chkPorumb.Name = "chkPorumb";
            this.chkPorumb.Size = new System.Drawing.Size(142, 21);
            this.chkPorumb.TabIndex = 2;
            this.chkPorumb.Text = "Porumb        3 Lei";
            this.chkPorumb.UseVisualStyleBackColor = true;
            // 
            // chkCiuperci
            // 
            this.chkCiuperci.AutoSize = true;
            this.chkCiuperci.Location = new System.Drawing.Point(22, 73);
            this.chkCiuperci.Name = "chkCiuperci";
            this.chkCiuperci.Size = new System.Drawing.Size(164, 21);
            this.chkCiuperci.TabIndex = 1;
            this.chkCiuperci.Text = "Ciuperci        3.50 Lei";
            this.chkCiuperci.UseVisualStyleBackColor = true;
            this.chkCiuperci.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkTon
            // 
            this.chkTon.AutoSize = true;
            this.chkTon.Location = new System.Drawing.Point(22, 36);
            this.chkTon.Name = "chkTon";
            this.chkTon.Size = new System.Drawing.Size(166, 21);
            this.chkTon.TabIndex = 0;
            this.chkTon.Text = "Ton               6.50 Lei";
            this.chkTon.UseVisualStyleBackColor = true;
            this.chkTon.CheckedChanged += new System.EventHandler(this.chkTon_CheckedChanged);
            // 
            // gbDimensiune
            // 
            this.gbDimensiune.Controls.Add(this.rbMedie);
            this.gbDimensiune.Controls.Add(this.rbMare);
            this.gbDimensiune.Controls.Add(this.rbMica);
            this.gbDimensiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDimensiune.Location = new System.Drawing.Point(423, 317);
            this.gbDimensiune.Name = "gbDimensiune";
            this.gbDimensiune.Size = new System.Drawing.Size(208, 129);
            this.gbDimensiune.TabIndex = 4;
            this.gbDimensiune.TabStop = false;
            this.gbDimensiune.Text = "Dimensiune";
            // 
            // rbMedie
            // 
            this.rbMedie.AutoSize = true;
            this.rbMedie.Location = new System.Drawing.Point(22, 48);
            this.rbMedie.Name = "rbMedie";
            this.rbMedie.Size = new System.Drawing.Size(67, 21);
            this.rbMedie.TabIndex = 2;
            this.rbMedie.TabStop = true;
            this.rbMedie.Text = "Medie";
            this.rbMedie.UseVisualStyleBackColor = true;
            // 
            // rbMare
            // 
            this.rbMare.AutoSize = true;
            this.rbMare.Location = new System.Drawing.Point(22, 75);
            this.rbMare.Name = "rbMare";
            this.rbMare.Size = new System.Drawing.Size(61, 21);
            this.rbMare.TabIndex = 1;
            this.rbMare.TabStop = true;
            this.rbMare.Text = "Mare";
            this.rbMare.UseVisualStyleBackColor = true;
            // 
            // rbMica
            // 
            this.rbMica.AutoSize = true;
            this.rbMica.Location = new System.Drawing.Point(22, 21);
            this.rbMica.Name = "rbMica";
            this.rbMica.Size = new System.Drawing.Size(58, 21);
            this.rbMica.TabIndex = 0;
            this.rbMica.TabStop = true;
            this.rbMica.Text = "Mica";
            this.rbMica.UseVisualStyleBackColor = true;
            // 
            // cboSortiment
            // 
            this.cboSortiment.FormattingEnabled = true;
            this.cboSortiment.Items.AddRange(new object[] {
            "Margherita",
            "Palermo",
            "Roma",
            "Vegetariana"});
            this.cboSortiment.Location = new System.Drawing.Point(119, 32);
            this.cboSortiment.Name = "cboSortiment";
            this.cboSortiment.Size = new System.Drawing.Size(257, 24);
            this.cboSortiment.TabIndex = 5;
            this.cboSortiment.Text = "Sortimente....";
            this.cboSortiment.SelectedIndexChanged += new System.EventHandler(this.cboSortiment_SelectedIndexChanged);
            // 
            // pbPizza
            // 
            this.pbPizza.Location = new System.Drawing.Point(119, 146);
            this.pbPizza.Name = "pbPizza";
            this.pbPizza.Size = new System.Drawing.Size(257, 240);
            this.pbPizza.TabIndex = 6;
            this.pbPizza.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(116, 429);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 17);
            this.label.TabIndex = 7;
            this.label.Text = "Pret:";
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPret.Location = new System.Drawing.Point(160, 429);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(16, 17);
            this.lbPret.TabIndex = 8;
            this.lbPret.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lei";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Comanda!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbComanda
            // 
            this.lbComanda.AutoSize = true;
            this.lbComanda.BackColor = System.Drawing.SystemColors.Control;
            this.lbComanda.Location = new System.Drawing.Point(116, 495);
            this.lbComanda.Name = "lbComanda";
            this.lbComanda.Size = new System.Drawing.Size(130, 17);
            this.lbComanda.TabIndex = 11;
            this.lbComanda.Text = "Comanda in curs....";
            // 
            // lstPret
            // 
            this.lstPret.FormattingEnabled = true;
            this.lstPret.ItemHeight = 16;
            this.lstPret.Items.AddRange(new object[] {
            "16",
            "18.50",
            "20",
            "17.50"});
            this.lstPret.Location = new System.Drawing.Point(12, 157);
            this.lstPret.Name = "lstPret";
            this.lstPret.Size = new System.Drawing.Size(59, 212);
            this.lstPret.TabIndex = 12;
            this.lstPret.Visible = false;
            this.lstPret.SelectedIndexChanged += new System.EventHandler(this.lstPret_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 530);
            this.Controls.Add(this.lstPret);
            this.Controls.Add(this.lbComanda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPret);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pbPizza);
            this.Controls.Add(this.cboSortiment);
            this.Controls.Add(this.gbDimensiune);
            this.Controls.Add(this.gbAlegere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAlegere.ResumeLayout(false);
            this.gbAlegere.PerformLayout();
            this.gbDimensiune.ResumeLayout(false);
            this.gbDimensiune.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlegere;
        private System.Windows.Forms.CheckBox chkPui;
        private System.Windows.Forms.CheckBox chkPorumb;
        private System.Windows.Forms.CheckBox chkCiuperci;
        private System.Windows.Forms.CheckBox chkTon;
        private System.Windows.Forms.GroupBox gbDimensiune;
        private System.Windows.Forms.RadioButton rbMedie;
        private System.Windows.Forms.RadioButton rbMare;
        private System.Windows.Forms.RadioButton rbMica;
        private System.Windows.Forms.ComboBox cboSortiment;
        private System.Windows.Forms.PictureBox pbPizza;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbComanda;
        private System.Windows.Forms.ListBox lstPret;
    }
}

