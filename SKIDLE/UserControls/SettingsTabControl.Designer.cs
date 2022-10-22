
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
            this.general = new System.Windows.Forms.Button();
            this.txteditor = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
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
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(152, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(587, 421);
            this.main.TabIndex = 1;
            // 
            // general
            // 
            this.general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.general.FlatAppearance.BorderSize = 0;
            this.general.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.general.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.general.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.general.Location = new System.Drawing.Point(3, 149);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(146, 35);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = false;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // txteditor
            // 
            this.txteditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.txteditor.FlatAppearance.BorderSize = 0;
            this.txteditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txteditor.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txteditor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txteditor.Location = new System.Drawing.Point(3, 190);
            this.txteditor.Name = "txteditor";
            this.txteditor.Size = new System.Drawing.Size(146, 35);
            this.txteditor.TabIndex = 1;
            this.txteditor.Text = "Text Editor";
            this.txteditor.UseVisualStyleBackColor = false;
            this.txteditor.Click += new System.EventHandler(this.txteditor_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.about.Location = new System.Drawing.Point(3, 231);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(146, 35);
            this.about.TabIndex = 2;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button txteditor;
        private System.Windows.Forms.Button general;
        private System.Windows.Forms.Panel main;
    }
}
