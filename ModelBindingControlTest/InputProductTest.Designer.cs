namespace ModelBindingControlTest
{
    partial class InputProductTest
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
            this.fastInputProducts1 = new PosSystem.Views.Component.InputProduct.FastInputProducts();
            this.SuspendLayout();
            // 
            // fastInputProducts1
            // 
            this.fastInputProducts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastInputProducts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastInputProducts1.Location = new System.Drawing.Point(0, 0);
            this.fastInputProducts1.Margin = new System.Windows.Forms.Padding(4);
            this.fastInputProducts1.Name = "fastInputProducts1";
            this.fastInputProducts1.Size = new System.Drawing.Size(932, 452);
            this.fastInputProducts1.TabIndex = 0;
            // 
            // InputProductTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 452);
            this.Controls.Add(this.fastInputProducts1);
            this.Name = "InputProductTest";
            this.Text = "InputProductTest";
            this.ResumeLayout(false);

        }

        #endregion

        private PosSystem.Views.Component.InputProduct.FastInputProducts fastInputProducts1;
    }
}