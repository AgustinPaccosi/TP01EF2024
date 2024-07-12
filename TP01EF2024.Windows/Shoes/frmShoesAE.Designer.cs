namespace TP01EF2024.Windows.Shoes
{
    partial class frmShoesAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoesAE));
            TexboxModel = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            buttonGuardar = new Button();
            TexboxDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TexboxPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ComboboxBrand = new ComboBox();
            ComboboxGenre = new ComboBox();
            ComboboxSport = new ComboBox();
            ComboboxColor = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TexboxModel
            // 
            TexboxModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxModel.Location = new Point(140, 184);
            TexboxModel.Margin = new Padding(3, 4, 3, 4);
            TexboxModel.MaxLength = 50;
            TexboxModel.Name = "TexboxModel";
            TexboxModel.PlaceholderText = "Ingrese un Modelo";
            TexboxModel.Size = new Size(286, 34);
            TexboxModel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 187);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 10;
            label1.Text = "Modelo:";
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(518, 310);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 74);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = ContentAlignment.BottomCenter;
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Image = (Image)resources.GetObject("buttonGuardar.Image");
            buttonGuardar.Location = new Point(232, 310);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 74);
            buttonGuardar.TabIndex = 8;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextAlign = ContentAlignment.BottomCenter;
            buttonGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // TexboxDescripcion
            // 
            TexboxDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxDescripcion.Location = new Point(568, 184);
            TexboxDescripcion.Margin = new Padding(3, 4, 3, 4);
            TexboxDescripcion.MaxLength = 50;
            TexboxDescripcion.Name = "TexboxDescripcion";
            TexboxDescripcion.PlaceholderText = "Ingrese una Descripcion";
            TexboxDescripcion.Size = new Size(267, 34);
            TexboxDescripcion.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 187);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 12;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 110);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 14;
            label3.Text = "Deporte:";
            // 
            // TexboxPrice
            // 
            TexboxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxPrice.Location = new Point(318, 247);
            TexboxPrice.Margin = new Padding(3, 4, 3, 4);
            TexboxPrice.MaxLength = 50;
            TexboxPrice.Name = "TexboxPrice";
            TexboxPrice.PlaceholderText = "Ingrese el Precio";
            TexboxPrice.Size = new Size(294, 34);
            TexboxPrice.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(232, 250);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 16;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(455, 110);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 18;
            label5.Text = "Color:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(455, 31);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 19;
            label6.Text = "Genero:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 31);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 20;
            label7.Text = "Marca:";
            // 
            // ComboboxBrand
            // 
            ComboboxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxBrand.FormattingEnabled = true;
            ComboboxBrand.Location = new Point(140, 35);
            ComboboxBrand.Name = "ComboboxBrand";
            ComboboxBrand.Size = new Size(286, 28);
            ComboboxBrand.TabIndex = 21;
            ComboboxBrand.SelectedIndexChanged += ComboboxBrand_SelectedIndexChanged;
            // 
            // ComboboxGenre
            // 
            ComboboxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxGenre.FormattingEnabled = true;
            ComboboxGenre.Location = new Point(549, 35);
            ComboboxGenre.Name = "ComboboxGenre";
            ComboboxGenre.Size = new Size(286, 28);
            ComboboxGenre.TabIndex = 22;
            ComboboxGenre.SelectedIndexChanged += ComboboxGenre_SelectedIndexChanged;
            // 
            // ComboboxSport
            // 
            ComboboxSport.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxSport.FormattingEnabled = true;
            ComboboxSport.Location = new Point(140, 114);
            ComboboxSport.Name = "ComboboxSport";
            ComboboxSport.Size = new Size(286, 28);
            ComboboxSport.TabIndex = 23;
            ComboboxSport.SelectedIndexChanged += ComboboxSport_SelectedIndexChanged;
            // 
            // ComboboxColor
            // 
            ComboboxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxColor.FormattingEnabled = true;
            ComboboxColor.Location = new Point(549, 114);
            ComboboxColor.Name = "ComboboxColor";
            ComboboxColor.Size = new Size(286, 28);
            ComboboxColor.TabIndex = 24;
            ComboboxColor.SelectedIndexChanged += ComboboxColor_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmShoesAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 423);
            Controls.Add(ComboboxColor);
            Controls.Add(ComboboxSport);
            Controls.Add(ComboboxGenre);
            Controls.Add(ComboboxBrand);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TexboxPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TexboxDescripcion);
            Controls.Add(label2);
            Controls.Add(TexboxModel);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonGuardar);
            Name = "frmShoesAE";
            Text = "Zapatillas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TexboxModel;
        private Label label1;
        private Button buttonCancel;
        private Button buttonGuardar;
        private TextBox TexboxDescripcion;
        private Label label2;
        private Label label3;
        private TextBox TexboxPrice;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox ComboboxBrand;
        private ComboBox ComboboxGenre;
        private ComboBox ComboboxSport;
        private ComboBox ComboboxColor;
        private ErrorProvider errorProvider1;
    }
}