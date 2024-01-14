namespace Logiciel_de_gestion_de_cave_a_vin
{
    partial class FormAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ilBouteille = new ImageList(components);
            btnAjouter = new Button();
            btnApogee = new Button();
            tbxRecherche = new TextBox();
            label1 = new Label();
            lvBouteille = new ListView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ilBouteille
            // 
            ilBouteille.ColorDepth = ColorDepth.Depth8Bit;
            ilBouteille.ImageSize = new Size(16, 16);
            ilBouteille.TransparentColor = Color.Transparent;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(37, 195, 76);
            btnAjouter.BackgroundImageLayout = ImageLayout.None;
            btnAjouter.FlatAppearance.BorderSize = 0;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(595, 484);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(254, 91);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnApogee
            // 
            btnApogee.BackColor = Color.FromArgb(26, 117, 188);
            btnApogee.FlatAppearance.BorderSize = 0;
            btnApogee.FlatStyle = FlatStyle.Flat;
            btnApogee.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnApogee.ForeColor = Color.White;
            btnApogee.Location = new Point(881, 484);
            btnApogee.Name = "btnApogee";
            btnApogee.Size = new Size(254, 91);
            btnApogee.TabIndex = 3;
            btnApogee.Text = "Apogée";
            btnApogee.UseVisualStyleBackColor = false;
            btnApogee.Click += btnApogee_Click;
            // 
            // tbxRecherche
            // 
            tbxRecherche.BackColor = Color.FromArgb(25, 29, 36);
            tbxRecherche.BorderStyle = BorderStyle.None;
            tbxRecherche.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRecherche.ForeColor = Color.White;
            tbxRecherche.Location = new Point(744, 151);
            tbxRecherche.Multiline = true;
            tbxRecherche.Name = "tbxRecherche";
            tbxRecherche.Size = new Size(391, 36);
            tbxRecherche.TabIndex = 4;
            tbxRecherche.TextChanged += tbxRecherche_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(16, 18, 23);
            label1.Font = new Font("Gabriola", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(582, 140);
            label1.Name = "label1";
            label1.Size = new Size(143, 59);
            label1.TabIndex = 5;
            label1.Text = "Recherche : ";
            // 
            // lvBouteille
            // 
            lvBouteille.BackColor = Color.White;
            lvBouteille.BorderStyle = BorderStyle.None;
            lvBouteille.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvBouteille.ForeColor = Color.Black;
            lvBouteille.Location = new Point(14, 140);
            lvBouteille.Name = "lvBouteille";
            lvBouteille.Size = new Size(541, 435);
            lvBouteille.TabIndex = 6;
            lvBouteille.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 47);
            label2.Name = "label2";
            label2.Size = new Size(153, 65);
            label2.TabIndex = 7;
            label2.Text = "WineVault";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.Location = new Point(1, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1167, 80);
            pictureBox1.TabIndex = 8;
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
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.noir;
            ClientSize = new Size(1162, 665);
            Controls.Add(btnClose);
            Controls.Add(btnAjouter);
            Controls.Add(label2);
            Controls.Add(lvBouteille);
            Controls.Add(label1);
            Controls.Add(tbxRecherche);
            Controls.Add(btnApogee);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormAccueil";
            Text = "WineVault - Accueil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ilBouteille;
        private Button btnAjouter;
        private Button btnApogee;
        private TextBox tbxRecherche;
        private Label label1;
        private ListView lvBouteille;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnClose;
    }
}