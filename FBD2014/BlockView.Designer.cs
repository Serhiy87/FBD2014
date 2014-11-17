namespace FBD2014
{
    partial class BlockView
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.LabelPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // LabelPriority
            // 
            this.LabelPriority.AutoSize = true;
            this.LabelPriority.Location = new System.Drawing.Point(27, 24);
            this.LabelPriority.Name = "LabelPriority";
            this.LabelPriority.Size = new System.Drawing.Size(38, 13);
            this.LabelPriority.TabIndex = 1;
            this.LabelPriority.Text = "Priority";
            // 
            // BlockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelPriority);
            this.Controls.Add(this.labelName);
            this.Name = "BlockView";
            this.Size = new System.Drawing.Size(100, 200);
            this.DoubleClick += new System.EventHandler(this.BlockView_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlockView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlockView_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlockView_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label LabelPriority;


    }
}
