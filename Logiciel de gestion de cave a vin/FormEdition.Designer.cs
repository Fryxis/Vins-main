namespace Logiciel_de_gestion_de_cave_a_vin
{
    partial class FormEdition
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
            components = new System.ComponentModel.Container();
            btnCave = new Button();
            tbxNom = new TextBox();
            btnBouteille = new Button();
            label1 = new Label();
            btnSupprimer = new Button();
            btnAjout = new Button();
            btnModifier = new Button();
            imageList1 = new ImageList(components);
            label_8 = new Label();
            cbbCouleur = new ComboBox();
            label3 = new Label();
            cbbAppelation = new ComboBox();
            tbxAjoutAppelation = new TextBox();
            btnAjoutAppelation = new Button();
            label4 = new Label();
            cbbEmplacemnt = new ComboBox();
            label5 = new Label();
            cbbTiroire = new ComboBox();
            tbxGardeFin = new TextBox();
            tbxGardeDebut = new TextBox();
            label2 = new Label();
            label6 = new Label();
            tbxMillesime = new TextBox();
            label7 = new Label();
            lvGeneral = new ListView();
            label8 = new Label();
            cbbCave = new ComboBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            lbType = new Label();
            tbxType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCave
            // 
            btnCave.BackColor = Color.FromArgb(25, 29, 36);
            btnCave.FlatAppearance.BorderSize = 0;
            btnCave.FlatStyle = FlatStyle.Flat;
            btnCave.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnCave.ForeColor = Color.White;
            btnCave.Location = new Point(18, 123);
            btnCave.Name = "btnCave";
            btnCave.Size = new Size(206, 78);
            btnCave.TabIndex = 0;
            btnCave.Text = "Cave";
            btnCave.UseVisualStyleBackColor = false;
            btnCave.Click += btnCave_Click;
            // 
            // tbxNom
            // 
            tbxNom.BackColor = Color.FromArgb(25, 29, 36);
            tbxNom.BorderStyle = BorderStyle.None;
            tbxNom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNom.ForeColor = Color.White;
            tbxNom.Location = new Point(658, 168);
            tbxNom.Multiline = true;
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(284, 33);
            tbxNom.TabIndex = 3;
            // 
            // btnBouteille
            // 
            btnBouteille.BackColor = Color.FromArgb(25, 29, 36);
            btnBouteille.FlatAppearance.BorderSize = 0;
            btnBouteille.FlatStyle = FlatStyle.Flat;
            btnBouteille.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnBouteille.ForeColor = Color.White;
            btnBouteille.Location = new Point(230, 123);
            btnBouteille.Name = "btnBouteille";
            btnBouteille.Size = new Size(206, 78);
            btnBouteille.TabIndex = 4;
            btnBouteille.Text = "Bouteille";
            btnBouteille.UseVisualStyleBackColor = false;
            btnBouteille.Click += btnBouteille_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(574, 168);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 5;
            label1.Text = "Nom :";
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Maroon;
            btnSupprimer.FlatAppearance.BorderSize = 0;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(451, 563);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(168, 70);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAjout
            // 
            btnAjout.BackColor = Color.FromArgb(37, 195, 76);
            btnAjout.FlatAppearance.BorderSize = 0;
            btnAjout.FlatStyle = FlatStyle.Flat;
            btnAjout.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjout.ForeColor = Color.White;
            btnAjout.Location = new Point(955, 563);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(167, 70);
            btnAjout.TabIndex = 7;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = false;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(26, 117, 188);
            btnModifier.FlatAppearance.BorderSize = 0;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(774, 563);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(168, 70);
            btnModifier.TabIndex = 8;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label_8
            // 
            label_8.AutoSize = true;
            label_8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_8.ForeColor = Color.White;
            label_8.Location = new Point(541, 491);
            label_8.Name = "label_8";
            label_8.Size = new Size(110, 32);
            label_8.TabIndex = 12;
            label_8.Text = "Couleur :";
            // 
            // cbbCouleur
            // 
            cbbCouleur.BackColor = Color.FromArgb(25, 29, 36);
            cbbCouleur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCouleur.FlatStyle = FlatStyle.Flat;
            cbbCouleur.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCouleur.ForeColor = Color.White;
            cbbCouleur.FormattingEnabled = true;
            cbbCouleur.Location = new Point(657, 494);
            cbbCouleur.Name = "cbbCouleur";
            cbbCouleur.Size = new Size(121, 33);
            cbbCouleur.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(508, 439);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 14;
            label3.Text = "Appelation :";
            // 
            // cbbAppelation
            // 
            cbbAppelation.BackColor = Color.FromArgb(25, 29, 36);
            cbbAppelation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAppelation.DropDownWidth = 200;
            cbbAppelation.FlatStyle = FlatStyle.Flat;
            cbbAppelation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbAppelation.ForeColor = Color.White;
            cbbAppelation.FormattingEnabled = true;
            cbbAppelation.Location = new Point(656, 439);
            cbbAppelation.Name = "cbbAppelation";
            cbbAppelation.Size = new Size(121, 33);
            cbbAppelation.TabIndex = 13;
            // 
            // tbxAjoutAppelation
            // 
            tbxAjoutAppelation.BackColor = Color.FromArgb(25, 29, 36);
            tbxAjoutAppelation.BorderStyle = BorderStyle.None;
            tbxAjoutAppelation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAjoutAppelation.ForeColor = Color.White;
            tbxAjoutAppelation.Location = new Point(803, 437);
            tbxAjoutAppelation.Multiline = true;
            tbxAjoutAppelation.Name = "tbxAjoutAppelation";
            tbxAjoutAppelation.Size = new Size(202, 35);
            tbxAjoutAppelation.TabIndex = 15;
            // 
            // btnAjoutAppelation
            // 
            btnAjoutAppelation.BackColor = Color.FromArgb(25, 29, 36);
            btnAjoutAppelation.FlatAppearance.BorderSize = 0;
            btnAjoutAppelation.FlatStyle = FlatStyle.Flat;
            btnAjoutAppelation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjoutAppelation.ForeColor = Color.White;
            btnAjoutAppelation.Location = new Point(1011, 429);
            btnAjoutAppelation.Name = "btnAjoutAppelation";
            btnAjoutAppelation.Size = new Size(111, 48);
            btnAjoutAppelation.TabIndex = 16;
            btnAjoutAppelation.Text = "Ajouter";
            btnAjoutAppelation.UseVisualStyleBackColor = false;
            btnAjoutAppelation.Click += btnAjoutAppelation_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(737, 385);
            label4.Name = "label4";
            label4.Size = new Size(251, 30);
            label4.TabIndex = 18;
            label4.Text = "Emplacement Bouteille : ";
            // 
            // cbbEmplacemnt
            // 
            cbbEmplacemnt.BackColor = Color.FromArgb(25, 29, 36);
            cbbEmplacemnt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEmplacemnt.FlatStyle = FlatStyle.Flat;
            cbbEmplacemnt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbEmplacemnt.ForeColor = Color.White;
            cbbEmplacemnt.FormattingEnabled = true;
            cbbEmplacemnt.Location = new Point(994, 383);
            cbbEmplacemnt.Name = "cbbEmplacemnt";
            cbbEmplacemnt.Size = new Size(152, 33);
            cbbEmplacemnt.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(556, 383);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 19;
            label5.Text = "Tiroire :";
            // 
            // cbbTiroire
            // 
            cbbTiroire.BackColor = Color.FromArgb(25, 29, 36);
            cbbTiroire.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTiroire.FlatStyle = FlatStyle.Flat;
            cbbTiroire.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTiroire.ForeColor = Color.White;
            cbbTiroire.FormattingEnabled = true;
            cbbTiroire.Location = new Point(656, 386);
            cbbTiroire.Name = "cbbTiroire";
            cbbTiroire.Size = new Size(75, 33);
            cbbTiroire.TabIndex = 20;
            cbbTiroire.SelectedIndexChanged += cbbTiroire_SelectedIndexChanged;
            // 
            // tbxGardeFin
            // 
            tbxGardeFin.BackColor = Color.FromArgb(25, 29, 36);
            tbxGardeFin.BorderStyle = BorderStyle.None;
            tbxGardeFin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGardeFin.ForeColor = Color.White;
            tbxGardeFin.Location = new Point(753, 276);
            tbxGardeFin.Multiline = true;
            tbxGardeFin.Name = "tbxGardeFin";
            tbxGardeFin.Size = new Size(64, 33);
            tbxGardeFin.TabIndex = 21;
            // 
            // tbxGardeDebut
            // 
            tbxGardeDebut.BackColor = Color.FromArgb(25, 29, 36);
            tbxGardeDebut.BorderStyle = BorderStyle.None;
            tbxGardeDebut.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGardeDebut.ForeColor = Color.White;
            tbxGardeDebut.Location = new Point(659, 276);
            tbxGardeDebut.Multiline = true;
            tbxGardeDebut.Name = "tbxGardeDebut";
            tbxGardeDebut.Size = new Size(64, 34);
            tbxGardeDebut.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(452, 276);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 23;
            label2.Text = "Garde Conseiller :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(728, 275);
            label6.Name = "label6";
            label6.Size = new Size(19, 32);
            label6.TabIndex = 24;
            label6.Text = ":";
            // 
            // tbxMillesime
            // 
            tbxMillesime.BackColor = Color.FromArgb(25, 29, 36);
            tbxMillesime.BorderStyle = BorderStyle.None;
            tbxMillesime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMillesime.ForeColor = Color.White;
            tbxMillesime.Location = new Point(659, 222);
            tbxMillesime.Multiline = true;
            tbxMillesime.Name = "tbxMillesime";
            tbxMillesime.Size = new Size(158, 33);
            tbxMillesime.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(524, 222);
            label7.Name = "label7";
            label7.Size = new Size(129, 32);
            label7.TabIndex = 26;
            label7.Text = "Millésime :";
            // 
            // lvGeneral
            // 
            lvGeneral.BackColor = Color.White;
            lvGeneral.BorderStyle = BorderStyle.None;
            lvGeneral.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvGeneral.ForeColor = Color.Black;
            lvGeneral.Location = new Point(18, 207);
            lvGeneral.Name = "lvGeneral";
            lvGeneral.Size = new Size(418, 426);
            lvGeneral.TabIndex = 27;
            lvGeneral.UseCompatibleStateImageBehavior = false;
            lvGeneral.Click += lvGeneral_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(572, 329);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 29;
            label8.Text = "Cave :";
            // 
            // cbbCave
            // 
            cbbCave.BackColor = Color.FromArgb(25, 29, 36);
            cbbCave.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCave.FlatStyle = FlatStyle.Flat;
            cbbCave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCave.ForeColor = Color.White;
            cbbCave.FormattingEnabled = true;
            cbbCave.Location = new Point(658, 332);
            cbbCave.Margin = new Padding(0);
            cbbCave.Name = "cbbCave";
            cbbCave.Size = new Size(240, 33);
            cbbCave.TabIndex = 28;
            cbbCave.SelectedIndexChanged += cbbCave_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Maroon;
            label9.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(19, 47);
            label9.Name = "label9";
            label9.Size = new Size(153, 65);
            label9.TabIndex = 30;
            label9.Text = "WineVault";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1171, 80);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1120, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 29);
            btnClose.TabIndex = 32;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbType.ForeColor = Color.White;
            lbType.Location = new Point(572, 332);
            lbType.Name = "lbType";
            lbType.Size = new Size(77, 32);
            lbType.TabIndex = 34;
            lbType.Text = "Type :";
            // 
            // tbxType
            // 
            tbxType.BackColor = Color.FromArgb(25, 29, 36);
            tbxType.BorderStyle = BorderStyle.None;
            tbxType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxType.ForeColor = Color.White;
            tbxType.Location = new Point(656, 332);
            tbxType.Multiline = true;
            tbxType.Name = "tbxType";
            tbxType.Size = new Size(284, 33);
            tbxType.TabIndex = 33;
            // 
            // FormEdition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 18, 23);
            ClientSize = new Size(1162, 665);
            Controls.Add(lbType);
            Controls.Add(tbxType);
            Controls.Add(btnClose);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(cbbCave);
            Controls.Add(lvGeneral);
            Controls.Add(label7);
            Controls.Add(tbxMillesime);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(tbxGardeDebut);
            Controls.Add(tbxGardeFin);
            Controls.Add(cbbTiroire);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbbEmplacemnt);
            Controls.Add(btnAjoutAppelation);
            Controls.Add(tbxAjoutAppelation);
            Controls.Add(label3);
            Controls.Add(cbbAppelation);
            Controls.Add(label_8);
            Controls.Add(cbbCouleur);
            Controls.Add(btnModifier);
            Controls.Add(btnAjout);
            Controls.Add(btnSupprimer);
            Controls.Add(label1);
            Controls.Add(btnBouteille);
            Controls.Add(tbxNom);
            Controls.Add(btnCave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEdition";
            Text = "WineVault - Edition";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCave;
        private TextBox tbxNom;
        private Button btnBouteille;
        private Label label1;
        private Button btnSupprimer;
        private Button btnAjout;
        private Button btnModifier;
        private ImageList imageList1;
        private Label label_8;
        private ComboBox cbbCouleur;
        private Label label3;
        private ComboBox cbbAppelation;
        private TextBox tbxAjoutAppelation;
        private Button btnAjoutAppelation;
        private Label label4;
        private ComboBox cbbEmplacemnt;
        private Label label5;
        private TextBox tbxGardeFin;
        private TextBox tbxGardeDebut;
        private Label label2;
        private Label label6;
        private TextBox tbxMillesime;
        private Label label7;
        private ListView lvGeneral;
        private Label label8;
        private ComboBox cbbCave;
        private Label label9;
        private PictureBox pictureBox1;
        protected ComboBox cbbTiroire;
        private Button btnClose;
        private Label lbType;
        private TextBox tbxType;
    }
}