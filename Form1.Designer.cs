namespace ADFGVX_cipher
{
    partial class Form1
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
            this.button_mode_ADFGX_EN = new System.Windows.Forms.Button();
            this.button_mode_ADFGX_CZ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_language_current = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.textBox_text_input = new System.Windows.Forms.TextBox();
            this.textBox_text_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_keyword_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_keyword_filtered = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_table_generate = new System.Windows.Forms.Button();
            this.button_text_encrypt = new System.Windows.Forms.Button();
            this.button_text_filter = new System.Windows.Forms.Button();
            this.button_text_decrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_keyword_use = new System.Windows.Forms.Button();
            this.button_keyword_change = new System.Windows.Forms.Button();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.button_mode_ADFGVX = new System.Windows.Forms.Button();
            this.button_table_input_manual = new System.Windows.Forms.Button();
            this.textBox_table_input_manual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_keyword_sorted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button_mode_ADFGX_EN
            // 
            this.button_mode_ADFGX_EN.Location = new System.Drawing.Point(161, 12);
            this.button_mode_ADFGX_EN.Name = "button_mode_ADFGX_EN";
            this.button_mode_ADFGX_EN.Size = new System.Drawing.Size(119, 23);
            this.button_mode_ADFGX_EN.TabIndex = 0;
            this.button_mode_ADFGX_EN.Text = "ADFGX (EN)";
            this.button_mode_ADFGX_EN.UseVisualStyleBackColor = true;
            this.button_mode_ADFGX_EN.Click += new System.EventHandler(this.button_mode_ADFGX_EN_Click);
            // 
            // button_mode_ADFGX_CZ
            // 
            this.button_mode_ADFGX_CZ.Location = new System.Drawing.Point(286, 12);
            this.button_mode_ADFGX_CZ.Name = "button_mode_ADFGX_CZ";
            this.button_mode_ADFGX_CZ.Size = new System.Drawing.Size(119, 23);
            this.button_mode_ADFGX_CZ.TabIndex = 1;
            this.button_mode_ADFGX_CZ.Text = "ADFGX (CZ)";
            this.button_mode_ADFGX_CZ.UseVisualStyleBackColor = true;
            this.button_mode_ADFGX_CZ.Click += new System.EventHandler(this.button_mode_ADFGX_CZ_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose language:";
            // 
            // label_language_current
            // 
            this.label_language_current.Location = new System.Drawing.Point(26, 35);
            this.label_language_current.Name = "label_language_current";
            this.label_language_current.Size = new System.Drawing.Size(227, 23);
            this.label_language_current.TabIndex = 3;
            this.label_language_current.Text = "Current language:";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(700, 404);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_info
            // 
            this.button_info.Location = new System.Drawing.Point(619, 404);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(75, 23);
            this.button_info.TabIndex = 5;
            this.button_info.Text = "Info";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // textBox_text_input
            // 
            this.textBox_text_input.Location = new System.Drawing.Point(72, 224);
            this.textBox_text_input.Multiline = true;
            this.textBox_text_input.Name = "textBox_text_input";
            this.textBox_text_input.Size = new System.Drawing.Size(254, 165);
            this.textBox_text_input.TabIndex = 6;
            // 
            // textBox_text_output
            // 
            this.textBox_text_output.Location = new System.Drawing.Point(488, 224);
            this.textBox_text_output.Multiline = true;
            this.textBox_text_output.Name = "textBox_text_output";
            this.textBox_text_output.Size = new System.Drawing.Size(254, 165);
            this.textBox_text_output.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Keyword:";
            // 
            // textBox_keyword_input
            // 
            this.textBox_keyword_input.Location = new System.Drawing.Point(104, 76);
            this.textBox_keyword_input.Name = "textBox_keyword_input";
            this.textBox_keyword_input.Size = new System.Drawing.Size(176, 22);
            this.textBox_keyword_input.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filtered keyword:";
            // 
            // label_keyword_filtered
            // 
            this.label_keyword_filtered.Location = new System.Drawing.Point(150, 101);
            this.label_keyword_filtered.Name = "label_keyword_filtered";
            this.label_keyword_filtered.Size = new System.Drawing.Size(267, 23);
            this.label_keyword_filtered.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(509, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Table:";
            // 
            // button_table_generate
            // 
            this.button_table_generate.Location = new System.Drawing.Point(459, 84);
            this.button_table_generate.Name = "button_table_generate";
            this.button_table_generate.Size = new System.Drawing.Size(106, 52);
            this.button_table_generate.TabIndex = 14;
            this.button_table_generate.Text = "Generate random";
            this.button_table_generate.UseVisualStyleBackColor = true;
            this.button_table_generate.Click += new System.EventHandler(this.button_table_generate_Click);
            // 
            // button_text_encrypt
            // 
            this.button_text_encrypt.Location = new System.Drawing.Point(370, 283);
            this.button_text_encrypt.Name = "button_text_encrypt";
            this.button_text_encrypt.Size = new System.Drawing.Size(75, 28);
            this.button_text_encrypt.TabIndex = 15;
            this.button_text_encrypt.Text = "Encrypt";
            this.button_text_encrypt.UseVisualStyleBackColor = true;
            this.button_text_encrypt.Click += new System.EventHandler(this.button_text_encrypt_Click);
            // 
            // button_text_filter
            // 
            this.button_text_filter.Location = new System.Drawing.Point(370, 317);
            this.button_text_filter.Name = "button_text_filter";
            this.button_text_filter.Size = new System.Drawing.Size(75, 28);
            this.button_text_filter.TabIndex = 16;
            this.button_text_filter.Text = "Filter";
            this.button_text_filter.UseVisualStyleBackColor = true;
            this.button_text_filter.Click += new System.EventHandler(this.button_text_filter_Click);
            // 
            // button_text_decrypt
            // 
            this.button_text_decrypt.Location = new System.Drawing.Point(370, 351);
            this.button_text_decrypt.Name = "button_text_decrypt";
            this.button_text_decrypt.Size = new System.Drawing.Size(75, 28);
            this.button_text_decrypt.TabIndex = 17;
            this.button_text_decrypt.Text = "Decrypt";
            this.button_text_decrypt.UseVisualStyleBackColor = true;
            this.button_text_decrypt.Click += new System.EventHandler(this.button_text_decrypt_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(342, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "------------------------->";
            // 
            // button_keyword_use
            // 
            this.button_keyword_use.Location = new System.Drawing.Point(286, 75);
            this.button_keyword_use.Name = "button_keyword_use";
            this.button_keyword_use.Size = new System.Drawing.Size(51, 23);
            this.button_keyword_use.TabIndex = 19;
            this.button_keyword_use.Text = "Use";
            this.button_keyword_use.UseVisualStyleBackColor = true;
            this.button_keyword_use.Click += new System.EventHandler(this.button_keyword_use_Click);
            // 
            // button_keyword_change
            // 
            this.button_keyword_change.Location = new System.Drawing.Point(342, 75);
            this.button_keyword_change.Name = "button_keyword_change";
            this.button_keyword_change.Size = new System.Drawing.Size(75, 23);
            this.button_keyword_change.TabIndex = 20;
            this.button_keyword_change.Text = "Change";
            this.button_keyword_change.UseVisualStyleBackColor = true;
            this.button_keyword_change.Click += new System.EventHandler(this.button_keyword_change_Click);
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Location = new System.Drawing.Point(571, 12);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.RowTemplate.Height = 24;
            this.dataGridView_table.Size = new System.Drawing.Size(160, 148);
            this.dataGridView_table.TabIndex = 21;
            // 
            // button_mode_ADFGVX
            // 
            this.button_mode_ADFGVX.Location = new System.Drawing.Point(411, 12);
            this.button_mode_ADFGVX.Name = "button_mode_ADFGVX";
            this.button_mode_ADFGVX.Size = new System.Drawing.Size(78, 23);
            this.button_mode_ADFGVX.TabIndex = 22;
            this.button_mode_ADFGVX.Text = "ADFGVX";
            this.button_mode_ADFGVX.UseVisualStyleBackColor = true;
            this.button_mode_ADFGVX.Click += new System.EventHandler(this.button_mode_ADFGVX_Click);
            // 
            // button_table_input_manual
            // 
            this.button_table_input_manual.Location = new System.Drawing.Point(459, 142);
            this.button_table_input_manual.Name = "button_table_input_manual";
            this.button_table_input_manual.Size = new System.Drawing.Size(106, 48);
            this.button_table_input_manual.TabIndex = 23;
            this.button_table_input_manual.Text = "Generate using string:";
            this.button_table_input_manual.UseVisualStyleBackColor = true;
            this.button_table_input_manual.Click += new System.EventHandler(this.button_table_input_manual_Click);
            // 
            // textBox_table_input_manual
            // 
            this.textBox_table_input_manual.Location = new System.Drawing.Point(459, 196);
            this.textBox_table_input_manual.Name = "textBox_table_input_manual";
            this.textBox_table_input_manual.Size = new System.Drawing.Size(272, 22);
            this.textBox_table_input_manual.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sorted keyword:";
            // 
            // label_keyword_sorted
            // 
            this.label_keyword_sorted.Location = new System.Drawing.Point(150, 124);
            this.label_keyword_sorted.Name = "label_keyword_sorted";
            this.label_keyword_sorted.Size = new System.Drawing.Size(267, 23);
            this.label_keyword_sorted.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_keyword_sorted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_table_input_manual);
            this.Controls.Add(this.button_table_input_manual);
            this.Controls.Add(this.button_mode_ADFGVX);
            this.Controls.Add(this.dataGridView_table);
            this.Controls.Add(this.button_keyword_change);
            this.Controls.Add(this.button_keyword_use);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_text_decrypt);
            this.Controls.Add(this.button_text_filter);
            this.Controls.Add(this.button_text_encrypt);
            this.Controls.Add(this.button_table_generate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_keyword_filtered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_keyword_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_text_output);
            this.Controls.Add(this.textBox_text_input);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_language_current);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_mode_ADFGX_CZ);
            this.Controls.Add(this.button_mode_ADFGX_EN);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_keyword_sorted;

        private System.Windows.Forms.Button button_table_input_manual;
        private System.Windows.Forms.TextBox textBox_table_input_manual;

        private System.Windows.Forms.Button button_mode_ADFGVX;

        private System.Windows.Forms.DataGridView dataGridView_table;

        private System.Windows.Forms.Button button_keyword_use;
        private System.Windows.Forms.Button button_keyword_change;

        private System.Windows.Forms.Button button_table_generate;
        private System.Windows.Forms.Button button_text_encrypt;
        private System.Windows.Forms.Button button_text_filter;
        private System.Windows.Forms.Button button_text_decrypt;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_keyword_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_keyword_filtered;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBox_text_output;

        private System.Windows.Forms.TextBox textBox_text_input;

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_info;

        private System.Windows.Forms.Button button_mode_ADFGX_EN;
        private System.Windows.Forms.Button button_mode_ADFGX_CZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_language_current;

        #endregion
    }
}