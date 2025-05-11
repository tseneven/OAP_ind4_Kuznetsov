
namespace prKol_ind4_Kuznetsov_a
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddInCatalog = new System.Windows.Forms.Button();
            this.DeleteInCatalog = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AddInSet = new System.Windows.Forms.Button();
            this.DeleteInSet = new System.Windows.Forms.Button();
            this.DeleteInCatalogSet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 212);
            this.listBox1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(30, 250);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(104, 47);
            this.Back.TabIndex = 1;
            this.Back.Text = "<<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(151, 250);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(104, 47);
            this.Next.TabIndex = 2;
            this.Next.Text = ">>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 3;
            // 
            // AddInCatalog
            // 
            this.AddInCatalog.Location = new System.Drawing.Point(508, 239);
            this.AddInCatalog.Name = "AddInCatalog";
            this.AddInCatalog.Size = new System.Drawing.Size(101, 39);
            this.AddInCatalog.TabIndex = 4;
            this.AddInCatalog.Text = "Добавить в каталог";
            this.AddInCatalog.UseVisualStyleBackColor = true;
            this.AddInCatalog.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteInCatalog
            // 
            this.DeleteInCatalog.Location = new System.Drawing.Point(631, 239);
            this.DeleteInCatalog.Name = "DeleteInCatalog";
            this.DeleteInCatalog.Size = new System.Drawing.Size(102, 39);
            this.DeleteInCatalog.TabIndex = 5;
            this.DeleteInCatalog.Text = "Удалить из каталога";
            this.DeleteInCatalog.UseVisualStyleBackColor = true;
            this.DeleteInCatalog.Click += new System.EventHandler(this.DeleteInCatalog_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(508, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(225, 160);
            this.listBox2.TabIndex = 6;
            // 
            // AddInSet
            // 
            this.AddInSet.Location = new System.Drawing.Point(508, 356);
            this.AddInSet.Name = "AddInSet";
            this.AddInSet.Size = new System.Drawing.Size(220, 42);
            this.AddInSet.TabIndex = 7;
            this.AddInSet.Text = "Добавить в Сет";
            this.AddInSet.UseVisualStyleBackColor = true;
            this.AddInSet.Click += new System.EventHandler(this.button5_Click);
            // 
            // DeleteInSet
            // 
            this.DeleteInSet.Location = new System.Drawing.Point(30, 356);
            this.DeleteInSet.Name = "DeleteInSet";
            this.DeleteInSet.Size = new System.Drawing.Size(225, 42);
            this.DeleteInSet.TabIndex = 8;
            this.DeleteInSet.Text = "Удалить из Сета";
            this.DeleteInSet.UseVisualStyleBackColor = true;
            this.DeleteInSet.Click += new System.EventHandler(this.DeleteInSet_Click);
            // 
            // DeleteInCatalogSet
            // 
            this.DeleteInCatalogSet.Location = new System.Drawing.Point(30, 308);
            this.DeleteInCatalogSet.Name = "DeleteInCatalogSet";
            this.DeleteInCatalogSet.Size = new System.Drawing.Size(225, 42);
            this.DeleteInCatalogSet.TabIndex = 9;
            this.DeleteInCatalogSet.Text = "Удалить из каталога";
            this.DeleteInCatalogSet.UseVisualStyleBackColor = true;
            this.DeleteInCatalogSet.Click += new System.EventHandler(this.DeleteInCatalogSet_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(508, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название диска/каталога";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Название песни";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DeleteInCatalogSet);
            this.Controls.Add(this.DeleteInSet);
            this.Controls.Add(this.AddInSet);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.DeleteInCatalog);
            this.Controls.Add(this.AddInCatalog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddInCatalog;
        private System.Windows.Forms.Button DeleteInCatalog;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button AddInSet;
        private System.Windows.Forms.Button DeleteInSet;
        private System.Windows.Forms.Button DeleteInCatalogSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

