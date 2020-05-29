namespace WindowsFormsApp25
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
            this.table = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datapr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Srok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.way = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            this.no_act = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.Datapr,
            this.Srok,
            this.Num,
            this.Com});
            this.table.Location = new System.Drawing.Point(12, 84);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(789, 245);
            this.table.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 101;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Datapr
            // 
            this.Datapr.HeaderText = "Дата производства";
            this.Datapr.MinimumWidth = 6;
            this.Datapr.Name = "Datapr";
            this.Datapr.Width = 125;
            // 
            // Srok
            // 
            this.Srok.HeaderText = "Срок годности";
            this.Srok.MinimumWidth = 6;
            this.Srok.Name = "Srok";
            this.Srok.Width = 125;
            // 
            // Num
            // 
            this.Num.HeaderText = "Количество";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.Width = 125;
            // 
            // Com
            // 
            this.Com.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Com.HeaderText = "Перечень продуктов";
            this.Com.MinimumWidth = 6;
            this.Com.Name = "Com";
            this.Com.Width = 159;
            // 
            // way
            // 
            this.way.Location = new System.Drawing.Point(179, 12);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(471, 22);
            this.way.TabIndex = 1;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(656, 12);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(137, 23);
            this.show.TabIndex = 2;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // no_act
            // 
            this.no_act.Location = new System.Drawing.Point(12, 41);
            this.no_act.Name = "no_act";
            this.no_act.Size = new System.Drawing.Size(789, 37);
            this.no_act.TabIndex = 3;
            this.no_act.Text = "Просроченый товар";
            this.no_act.UseVisualStyleBackColor = true;
            this.no_act.Click += new System.EventHandler(this.no_act_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 335);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(392, 42);
            this.clear.TabIndex = 4;
            this.clear.Text = "Сбросить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите путь к файлу:";
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(409, 335);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(392, 42);
            this.clear_all.TabIndex = 6;
            this.clear_all.Text = "Очистить все";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 395);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.no_act);
            this.Controls.Add(this.show);
            this.Controls.Add(this.way);
            this.Controls.Add(this.table);
           // this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox way;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button no_act;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datapr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com;
        private System.Windows.Forms.Button clear_all;
    }
}

