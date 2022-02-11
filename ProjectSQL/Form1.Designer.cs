
namespace ProjectSQL
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBaseList = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(26, 170);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(137, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.Location = new System.Drawing.Point(26, 40);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(311, 21);
            this.serverList.TabIndex = 2;
            this.serverList.Click += new System.EventHandler(this.serverList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "База данных";
            // 
            // dataBaseList
            // 
            this.dataBaseList.FormattingEnabled = true;
            this.dataBaseList.Location = new System.Drawing.Point(26, 106);
            this.dataBaseList.Name = "dataBaseList";
            this.dataBaseList.Size = new System.Drawing.Size(311, 21);
            this.dataBaseList.TabIndex = 4;
            this.dataBaseList.Click += new System.EventHandler(this.dataBaseList_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(200, 170);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(137, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 228);
            this.Controls.Add(this.dataBaseList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox serverList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dataBaseList;
        private System.Windows.Forms.Button closeButton;
    }
}

