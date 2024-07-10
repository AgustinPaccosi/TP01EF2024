namespace TP01EF2024.Windows.Genres
{
    partial class frmGenresAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenresAE));
            TextBoxGenreName = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            buttonGuardar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxGenreName
            // 
            TextBoxGenreName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxGenreName.Location = new Point(133, 65);
            TextBoxGenreName.Margin = new Padding(3, 4, 3, 4);
            TextBoxGenreName.Name = "TextBoxGenreName";
            TextBoxGenreName.PlaceholderText = "Nombre del Genero";
            TextBoxGenreName.Size = new Size(294, 34);
            TextBoxGenreName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 68);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 6;
            label1.Text = "Genero:";
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(322, 137);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 74);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = ContentAlignment.BottomCenter;
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Image = (Image)resources.GetObject("buttonGuardar.Image");
            buttonGuardar.Location = new Point(76, 137);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 74);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextAlign = ContentAlignment.BottomCenter;
            buttonGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGenresAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 272);
            Controls.Add(TextBoxGenreName);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonGuardar);
            MaximumSize = new Size(527, 319);
            MinimumSize = new Size(527, 319);
            Name = "frmGenresAE";
            Text = "Generos";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxGenreName;
        private Label label1;
        private Button buttonCancel;
        private Button buttonGuardar;
        private ErrorProvider errorProvider1;
    }
}