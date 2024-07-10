namespace TP01EF2024.Windows
{
    partial class MenuPrincipal
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
            ButtonGenres = new Button();
            ButtonBrands = new Button();
            ButtonColours = new Button();
            ButtonSports = new Button();
            ButtonShoes = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtonGenres
            // 
            ButtonGenres.Location = new Point(171, 124);
            ButtonGenres.Margin = new Padding(3, 4, 3, 4);
            ButtonGenres.Name = "ButtonGenres";
            ButtonGenres.Size = new Size(169, 90);
            ButtonGenres.TabIndex = 7;
            ButtonGenres.Text = "Generos";
            ButtonGenres.UseVisualStyleBackColor = true;
            ButtonGenres.Click += ButtonGenres_Click;
            // 
            // ButtonBrands
            // 
            ButtonBrands.Location = new Point(2, 222);
            ButtonBrands.Margin = new Padding(3, 4, 3, 4);
            ButtonBrands.Name = "ButtonBrands";
            ButtonBrands.Size = new Size(169, 90);
            ButtonBrands.TabIndex = 6;
            ButtonBrands.Text = "Marcas";
            ButtonBrands.UseVisualStyleBackColor = true;
            ButtonBrands.Click += ButtonBrands_Click;
            // 
            // ButtonColours
            // 
            ButtonColours.Location = new Point(619, 222);
            ButtonColours.Margin = new Padding(3, 4, 3, 4);
            ButtonColours.Name = "ButtonColours";
            ButtonColours.Size = new Size(169, 90);
            ButtonColours.TabIndex = 8;
            ButtonColours.Text = "Colores";
            ButtonColours.UseVisualStyleBackColor = true;
            ButtonColours.Click += ButtonColours_Click;
            // 
            // ButtonSports
            // 
            ButtonSports.Location = new Point(453, 124);
            ButtonSports.Margin = new Padding(3, 4, 3, 4);
            ButtonSports.Name = "ButtonSports";
            ButtonSports.Size = new Size(169, 90);
            ButtonSports.TabIndex = 9;
            ButtonSports.Text = "Deportes";
            ButtonSports.UseVisualStyleBackColor = true;
            ButtonSports.Click += ButtonSports_Click;
            // 
            // ButtonShoes
            // 
            ButtonShoes.Location = new Point(320, 222);
            ButtonShoes.Margin = new Padding(3, 4, 3, 4);
            ButtonShoes.Name = "ButtonShoes";
            ButtonShoes.Size = new Size(169, 90);
            ButtonShoes.TabIndex = 10;
            ButtonShoes.Text = "Zapatillas";
            ButtonShoes.UseVisualStyleBackColor = true;
            ButtonShoes.Click += ButtonShoes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 11;
            label1.Text = "Menu";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtonShoes);
            Controls.Add(ButtonSports);
            Controls.Add(ButtonColours);
            Controls.Add(ButtonGenres);
            Controls.Add(ButtonBrands);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonGenres;
        private Button ButtonBrands;
        private Button ButtonColours;
        private Button ButtonSports;
        private Button ButtonShoes;
        private Label label1;
    }
}