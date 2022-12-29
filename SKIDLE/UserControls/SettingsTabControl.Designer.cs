
using SKIDLE.UI;
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
            this.panel1 = new SKIDLE.UI.RenPanel();
            this.about = new System.Windows.Forms.Button();
            this.general = new System.Windows.Forms.Button();
            this.txteditor = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.ver);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftPanel.Location = new System.Drawing.Point(0, 391);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(739, 30);
            this.leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.general);
            this.panel1.Controls.Add(this.txteditor);
            this.panel1.Location = new System.Drawing.Point(293, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 29);
            this.panel1.TabIndex = 3;
            // 
            // about
            // 
            this.about.BackgroundImage = global::SKIDLE.Properties.Resources.about1;
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.about.Dock = System.Windows.Forms.DockStyle.Left;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.about.Location = new System.Drawing.Point(78, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(39, 29);
            this.about.TabIndex = 2;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // general
            // 
            this.general.BackgroundImage = global::SKIDLE.Properties.Resources.general1;
            this.general.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.general.Dock = System.Windows.Forms.DockStyle.Left;
            this.general.FlatAppearance.BorderSize = 0;
            this.general.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.general.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.general.Location = new System.Drawing.Point(39, 0);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(39, 29);
            this.general.TabIndex = 0;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // txteditor
            // 
            this.txteditor.BackgroundImage = global::SKIDLE.Properties.Resources.exteditor1;
            this.txteditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txteditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txteditor.FlatAppearance.BorderSize = 0;
            this.txteditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txteditor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txteditor.Location = new System.Drawing.Point(0, 0);
            this.txteditor.Name = "txteditor";
            this.txteditor.Size = new System.Drawing.Size(39, 29);
            this.txteditor.TabIndex = 1;
            this.txteditor.Click += new System.EventHandler(this.txteditor_Click);
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ver.Location = new System.Drawing.Point(0, 17);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(22, 13);
            this.ver.TabIndex = 1;
            this.ver.Text = "ver";
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.main.Controls.Add(this.title);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(739, 391);
            this.main.TabIndex = 1;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.title.Location = new System.Drawing.Point(298, 154);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome, User!";
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
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel main;
        private Button about;
        private Button txteditor;
        private Button general;
        private Label title;
        private Label ver;
        private RenPanel panel1;
    }
}
