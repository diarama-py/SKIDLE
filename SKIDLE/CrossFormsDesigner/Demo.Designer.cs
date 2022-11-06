
namespace SKIDLE.CrossFormsDesigner
{
    partial class Demo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.window = new System.Windows.Forms.Panel();
            this.titleBorder = new System.Windows.Forms.Panel();
            this.TitleForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.window.SuspendLayout();
            this.titleBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.window.Controls.Add(this.titleBorder);
            this.window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.window.Location = new System.Drawing.Point(3, 3);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(566, 401);
            this.window.TabIndex = 0;
            // 
            // titleBorder
            // 
            this.titleBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleBorder.Controls.Add(this.label2);
            this.titleBorder.Controls.Add(this.TitleForm);
            this.titleBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBorder.Location = new System.Drawing.Point(0, 0);
            this.titleBorder.Name = "titleBorder";
            this.titleBorder.Size = new System.Drawing.Size(566, 19);
            this.titleBorder.TabIndex = 0;
            this.titleBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBorder_Paint);
            // 
            // TitleForm
            // 
            this.TitleForm.AutoSize = true;
            this.TitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleForm.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleForm.Location = new System.Drawing.Point(14, 0);
            this.TitleForm.Name = "TitleForm";
            this.TitleForm.Size = new System.Drawing.Size(93, 18);
            this.TitleForm.TabIndex = 0;
            this.TitleForm.Text = "CrossForms";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(549, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.window);
            this.Name = "Demo";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(572, 407);
            this.window.ResumeLayout(false);
            this.titleBorder.ResumeLayout(false);
            this.titleBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titleBorder;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel window;
        public System.Windows.Forms.Label TitleForm;
    }
}
