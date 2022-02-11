
namespace ProjectSQL
{
    partial class MainForm
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
            this.StoreList = new System.Windows.Forms.ListView();
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoreList
            // 
            this.StoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.from,
            this.to,
            this.cost});
            this.StoreList.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoreList.HideSelection = false;
            this.StoreList.Location = new System.Drawing.Point(0, 0);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(706, 311);
            this.StoreList.TabIndex = 0;
            this.StoreList.UseCompatibleStateImageBehavior = false;
            this.StoreList.View = System.Windows.Forms.View.Details;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.StoreList_SelectedIndexChanged);
            // 
            // from
            // 
            this.from.Text = "Откуда";
            this.from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.from.Width = 150;
            // 
            // to
            // 
            this.to.Text = "Куда";
            this.to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.to.Width = 150;
            // 
            // cost
            // 
            this.cost.Text = "Стоимость";
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost.Width = 150;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 330);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(230, 70);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(606, 330);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 33);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(274, 330);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(94, 45);
            this.buttonDo.TabIndex = 3;
            this.buttonDo.Text = "Выполнить";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(390, 350);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StoreList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StoreList;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Label labelResult;
    }
}