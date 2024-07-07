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
            button1 = new Button();
            button2 = new Button();
            ButtonShoes = new Button();
            SuspendLayout();
            // 
            // ButtonGenres
            // 
            ButtonGenres.Location = new Point(170, 158);
            ButtonGenres.Margin = new Padding(3, 4, 3, 4);
            ButtonGenres.Name = "ButtonGenres";
            ButtonGenres.Size = new Size(126, 90);
            ButtonGenres.TabIndex = 7;
            ButtonGenres.Text = "Generos";
            ButtonGenres.UseVisualStyleBackColor = true;
            // 
            // ButtonBrands
            // 
            ButtonBrands.Location = new Point(38, 158);
            ButtonBrands.Margin = new Padding(3, 4, 3, 4);
            ButtonBrands.Name = "ButtonBrands";
            ButtonBrands.Size = new Size(126, 90);
            ButtonBrands.TabIndex = 6;
            ButtonBrands.Text = "Marcas";
            ButtonBrands.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(566, 158);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 90);
            button1.TabIndex = 8;
            button1.Text = "Colores";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(434, 158);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 90);
            button2.TabIndex = 9;
            button2.Text = "Deportes";
            button2.UseVisualStyleBackColor = true;
            // 
            // ButtonShoes
            // 
            ButtonShoes.Location = new Point(302, 158);
            ButtonShoes.Margin = new Padding(3, 4, 3, 4);
            ButtonShoes.Name = "ButtonShoes";
            ButtonShoes.Size = new Size(126, 90);
            ButtonShoes.TabIndex = 10;
            ButtonShoes.Text = "Zapatillas";
            ButtonShoes.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonShoes);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ButtonGenres);
            Controls.Add(ButtonBrands);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonGenres;
        private Button ButtonBrands;
        private Button button1;
        private Button button2;
        private Button ButtonShoes;
    }
}