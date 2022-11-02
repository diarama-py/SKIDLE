
namespace SKIDLE.UserControls
{
    partial class StructureControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructureControl));
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.treeView = new SKIDLE.BufferedTreeView();
            this.SuspendLayout();
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "classes.png");
            this.icons.Images.SetKeyName(1, "vars.png");
            this.icons.Images.SetKeyName(2, "fragment.png");
            this.icons.Images.SetKeyName(3, "functions.png");
            this.icons.Images.SetKeyName(4, "local vars.png");
            // 
            // treeView
            // 
            this.treeView.BackColor = this.BackColor;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeView.FullRowSelect = true;
            this.treeView.imageList = null;
            this.treeView.LineColor = System.Drawing.Color.Silver;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(260, 406);
            this.treeView.TabIndex = 0;
            // 
            // StructureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.treeView);
            this.Name = "StructureControl";
            this.Size = new System.Drawing.Size(260, 406);
            this.Load += new System.EventHandler(this.StructureControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public SKIDLE.BufferedTreeView treeView;
        private System.Windows.Forms.ImageList icons;
    }
}
