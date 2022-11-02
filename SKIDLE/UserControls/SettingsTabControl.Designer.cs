
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    partial class SettingsTabControl
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.general = new MetroFramework.Controls.MetroButton();
            this.txteditor = new MetroFramework.Controls.MetroButton();
            this.about = new MetroFramework.Controls.MetroButton();
            this.title = new MetroFramework.Controls.MetroLabel();
            this.leftPanel.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.leftPanel.Controls.Add(this.about);
            this.leftPanel.Controls.Add(this.txteditor);
            this.leftPanel.Controls.Add(this.general);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(152, 421);
            this.leftPanel.TabIndex = 0;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.main.Controls.Add(this.title);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(152, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(587, 421);
            this.main.TabIndex = 1;
            // 
            // general
            // 
            this.general.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.general.Highlight = true;
            this.general.Location = new System.Drawing.Point(5, 66);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(143, 23);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseCustomBackColor = true;
            this.general.UseCustomForeColor = true;
            this.general.UseSelectable = true;
            this.general.UseStyleColors = true;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // txteditor
            // 
            this.txteditor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txteditor.Highlight = true;
            this.txteditor.Location = new System.Drawing.Point(5, 95);
            this.txteditor.Name = "txteditor";
            this.txteditor.Size = new System.Drawing.Size(143, 23);
            this.txteditor.TabIndex = 1;
            this.txteditor.Text = "Text Editor";
            this.txteditor.UseCustomBackColor = true;
            this.txteditor.UseCustomForeColor = true;
            this.txteditor.UseSelectable = true;
            this.txteditor.UseStyleColors = true;
            this.txteditor.Click += new System.EventHandler(this.txteditor_Click);
            // 
            // about
            // 
            this.about.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.about.Highlight = true;
            this.about.Location = new System.Drawing.Point(4, 124);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(143, 23);
            this.about.TabIndex = 2;
            this.about.Text = "About";
            this.about.UseCustomBackColor = true;
            this.about.UseCustomForeColor = true;
            this.about.UseSelectable = true;
            this.about.UseStyleColors = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.title.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.title.Location = new System.Drawing.Point(220, 162);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(145, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome, User!";
            this.title.UseCustomBackColor = true;
            this.title.UseCustomForeColor = true;
            this.title.WrapToLine = true;
            // 
            // SettingsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main);
            this.Controls.Add(this.leftPanel);
            this.Name = "SettingsTabControl";
            this.Size = new System.Drawing.Size(739, 421);
            this.Load += new System.EventHandler(this.SettingsTabControl_Load);
            this.leftPanel.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel main;
        private MetroFramework.Controls.MetroButton about;
        private MetroFramework.Controls.MetroButton txteditor;
        private MetroFramework.Controls.MetroButton general;
        private MetroFramework.Controls.MetroLabel title;
    }
}
