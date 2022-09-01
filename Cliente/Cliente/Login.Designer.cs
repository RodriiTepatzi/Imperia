namespace Cliente
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.puertoBox = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.conectarbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.White;
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(145, 261);
            this.userBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userBox.MaxLength = 15;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(200, 21);
            this.userBox.TabIndex = 1;
            this.userBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Puerto:";
            // 
            // ipBox
            // 
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipBox.Location = new System.Drawing.Point(145, 309);
            this.ipBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ipBox.MaxLength = 15;
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(200, 22);
            this.ipBox.TabIndex = 2;
            this.ipBox.Text = "127.0.0.1";
            this.ipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipBox_KeyPress);
            this.ipBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ipBox_KeyUp);
            // 
            // puertoBox
            // 
            this.puertoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puertoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puertoBox.Location = new System.Drawing.Point(145, 350);
            this.puertoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.puertoBox.MaxLength = 5;
            this.puertoBox.Name = "puertoBox";
            this.puertoBox.Size = new System.Drawing.Size(200, 22);
            this.puertoBox.TabIndex = 3;
            this.puertoBox.Text = "8000";
            this.puertoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.puertoBox_KeyPress);
            this.puertoBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.puertoBox_KeyUp);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(415, 610);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.MidnightBlue;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.SelectionColor = System.Drawing.Color.Transparent;
            this.lineShape3.X1 = 108;
            this.lineShape3.X2 = 260;
            this.lineShape3.Y1 = 303;
            this.lineShape3.Y2 = 303;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.Transparent;
            this.lineShape2.X1 = 108;
            this.lineShape2.X2 = 260;
            this.lineShape2.Y1 = 271;
            this.lineShape2.Y2 = 271;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.lineShape1.X1 = 108;
            this.lineShape1.X2 = 260;
            this.lineShape1.Y1 = 232;
            this.lineShape1.Y2 = 232;
            // 
            // conectarbtn
            // 
            this.conectarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conectarbtn.FlatAppearance.BorderSize = 0;
            this.conectarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.conectarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.conectarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conectarbtn.Image = global::Cliente.Properties.Resources.conectar;
            this.conectarbtn.Location = new System.Drawing.Point(105, 394);
            this.conectarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conectarbtn.Name = "conectarbtn";
            this.conectarbtn.Size = new System.Drawing.Size(200, 43);
            this.conectarbtn.TabIndex = 4;
            this.conectarbtn.UseVisualStyleBackColor = true;
            this.conectarbtn.Click += new System.EventHandler(this.conectarbtn_Click);
            this.conectarbtn.MouseEnter += new System.EventHandler(this.conectarbtn_MouseEnter);
            this.conectarbtn.MouseLeave += new System.EventHandler(this.conectarbtn_MouseLeave);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Cliente.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(369, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cliente.Properties.Resources.cbtis_logo;
            this.pictureBox1.InitialImage = global::Cliente.Properties.Resources.cbtis_logo;
            this.pictureBox1.Location = new System.Drawing.Point(105, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 610);
            this.Controls.Add(this.puertoBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.conectarbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button conectarbtn;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox puertoBox;
        private System.Windows.Forms.ToolTip Tip;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
    }
}