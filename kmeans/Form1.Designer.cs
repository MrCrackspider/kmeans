namespace kmeans
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.bt_draw = new System.Windows.Forms.Button();
            this.nud_clasters = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_init = new System.Windows.Forms.Button();
            this.bt_step = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_clasters)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(367, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(300, 300);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // bt_draw
            // 
            this.bt_draw.Location = new System.Drawing.Point(46, 20);
            this.bt_draw.Name = "bt_draw";
            this.bt_draw.Size = new System.Drawing.Size(78, 35);
            this.bt_draw.TabIndex = 1;
            this.bt_draw.Text = "draw points";
            this.bt_draw.UseVisualStyleBackColor = true;
            this.bt_draw.Click += new System.EventHandler(this.bt_draw_Click);
            // 
            // nud_clasters
            // 
            this.nud_clasters.Location = new System.Drawing.Point(46, 84);
            this.nud_clasters.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_clasters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_clasters.Name = "nud_clasters";
            this.nud_clasters.Size = new System.Drawing.Size(78, 20);
            this.nud_clasters.TabIndex = 2;
            this.nud_clasters.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "amount of clasters:";
            // 
            // bt_init
            // 
            this.bt_init.Location = new System.Drawing.Point(46, 127);
            this.bt_init.Name = "bt_init";
            this.bt_init.Size = new System.Drawing.Size(78, 39);
            this.bt_init.TabIndex = 4;
            this.bt_init.Text = "init kmeans";
            this.bt_init.UseVisualStyleBackColor = true;
            this.bt_init.Click += new System.EventHandler(this.bt_init_Click);
            // 
            // bt_step
            // 
            this.bt_step.Location = new System.Drawing.Point(46, 172);
            this.bt_step.Name = "bt_step";
            this.bt_step.Size = new System.Drawing.Size(78, 39);
            this.bt_step.TabIndex = 5;
            this.bt_step.Text = "step";
            this.bt_step.UseVisualStyleBackColor = true;
            this.bt_step.Click += new System.EventHandler(this.bt_step_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.bt_step);
            this.Controls.Add(this.bt_init);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_clasters);
            this.Controls.Add(this.bt_draw);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "kmeans";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_clasters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button bt_draw;
        private System.Windows.Forms.NumericUpDown nud_clasters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_init;
        private System.Windows.Forms.Button bt_step;
    }
}

