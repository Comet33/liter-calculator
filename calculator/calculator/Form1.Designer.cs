namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.liquidList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.developer = new System.Windows.Forms.Button();
            this.addNewLiquid = new System.Windows.Forms.Button();
            this.inputLitters = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Button();
            this.littersText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liquidList
            // 
            this.liquidList.Dock = System.Windows.Forms.DockStyle.Left;
            this.liquidList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liquidList.FormattingEnabled = true;
            this.liquidList.ItemHeight = 24;
            this.liquidList.Location = new System.Drawing.Point(0, 0);
            this.liquidList.MaximumSize = new System.Drawing.Size(300, 2000);
            this.liquidList.MinimumSize = new System.Drawing.Size(250, 4);
            this.liquidList.Name = "liquidList";
            this.liquidList.Size = new System.Drawing.Size(250, 461);
            this.liquidList.TabIndex = 0;
            this.liquidList.SelectedIndexChanged += new System.EventHandler(this.liquidList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.developer);
            this.panel1.Controls.Add(this.addNewLiquid);
            this.panel1.Controls.Add(this.inputLitters);
            this.panel1.Controls.Add(this.resultText);
            this.panel1.Controls.Add(this.resultBtn);
            this.panel1.Controls.Add(this.littersText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 461);
            this.panel1.TabIndex = 1;
            // 
            // developer
            // 
            this.developer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer.Location = new System.Drawing.Point(391, 391);
            this.developer.Name = "developer";
            this.developer.Padding = new System.Windows.Forms.Padding(5);
            this.developer.Size = new System.Drawing.Size(143, 70);
            this.developer.TabIndex = 5;
            this.developer.Text = "Разработчик";
            this.developer.UseVisualStyleBackColor = true;
            this.developer.Click += new System.EventHandler(this.developer_Click);
            // 
            // addNewLiquid
            // 
            this.addNewLiquid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewLiquid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewLiquid.Location = new System.Drawing.Point(0, 391);
            this.addNewLiquid.Name = "addNewLiquid";
            this.addNewLiquid.Padding = new System.Windows.Forms.Padding(5);
            this.addNewLiquid.Size = new System.Drawing.Size(143, 70);
            this.addNewLiquid.TabIndex = 4;
            this.addNewLiquid.Text = "Добавить\r\nжидкость";
            this.addNewLiquid.UseVisualStyleBackColor = true;
            this.addNewLiquid.Click += new System.EventHandler(this.addNewLiquid_Click);
            // 
            // inputLitters
            // 
            this.inputLitters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLitters.Location = new System.Drawing.Point(183, 175);
            this.inputLitters.Name = "inputLitters";
            this.inputLitters.Size = new System.Drawing.Size(160, 35);
            this.inputLitters.TabIndex = 3;
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultText.Location = new System.Drawing.Point(116, 312);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(290, 29);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "Result";
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultBtn
            // 
            this.resultBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBtn.Location = new System.Drawing.Point(183, 245);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Padding = new System.Windows.Forms.Padding(5);
            this.resultBtn.Size = new System.Drawing.Size(160, 45);
            this.resultBtn.TabIndex = 1;
            this.resultBtn.Text = "Посчитать";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // littersText
            // 
            this.littersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.littersText.Location = new System.Drawing.Point(116, 100);
            this.littersText.Name = "littersText";
            this.littersText.Size = new System.Drawing.Size(290, 29);
            this.littersText.TabIndex = 0;
            this.littersText.Text = "Плотность: 0";
            this.littersText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liquidList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox liquidList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputLitters;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Label littersText;
        private System.Windows.Forms.Button addNewLiquid;
        private System.Windows.Forms.Button developer;
    }
}

