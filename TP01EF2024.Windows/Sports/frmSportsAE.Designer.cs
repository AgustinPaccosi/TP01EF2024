namespace TP01EF2024.Windows.Sports
{
    partial class frmSportsAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSportsAE));
            TextBoxSportName = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // TextBoxSportName
            // 
            TextBoxSportName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSportName.Location = new Point(147, 51);
            TextBoxSportName.Margin = new Padding(3, 4, 3, 4);
            TextBoxSportName.Name = "TextBoxSportName";
            TextBoxSportName.PlaceholderText = "Nombre del Deporte";
            TextBoxSportName.Size = new Size(294, 34);
            TextBoxSportName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 14;
            label1.Text = "Deporte:";
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(328, 123);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 74);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = ContentAlignment.BottomCenter;
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Image = (Image)resources.GetObject("buttonGuardar.Image");
            buttonGuardar.Location = new Point(82, 123);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 74);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextAlign = ContentAlignment.BottomCenter;
            buttonGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // frmSportsAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 272);
            Controls.Add(TextBoxSportName);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonGuardar);
            MaximumSize = new Size(527, 319);
            MinimumSize = new Size(527, 319);
            Name = "frmSportsAE";
            Text = "Deportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxSportName;
        private Label label1;
        private Button buttonCancel;
        private Button buttonGuardar;
    }
}