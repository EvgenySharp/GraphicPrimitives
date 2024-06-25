namespace GraphicPrimitives
{
    partial class MainForm
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
            primitiveCanvas1 = new PrimitiveCanvas();
            primitiveCanvas2 = new PrimitiveCanvas();
            SuspendLayout();
            // 
            // primitiveCanvas1
            // 
            primitiveCanvas1.BackColor = SystemColors.Control;
            primitiveCanvas1.Location = new Point(23, 21);
            primitiveCanvas1.Name = "primitiveCanvas1";
            primitiveCanvas1.Size = new Size(884, 215);
            primitiveCanvas1.TabIndex = 0;
            // 
            // primitiveCanvas2
            // 
            primitiveCanvas2.BackColor = SystemColors.Control;
            primitiveCanvas2.Location = new Point(23, 287);
            primitiveCanvas2.Name = "primitiveCanvas2";
            primitiveCanvas2.Size = new Size(884, 241);
            primitiveCanvas2.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(928, 560);
            Controls.Add(primitiveCanvas2);
            Controls.Add(primitiveCanvas1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private PrimitiveCanvas primitiveCanvas1;
        private PrimitiveCanvas primitiveCanvas2;
    }
}
