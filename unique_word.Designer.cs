namespace WordsApp
{
    partial class unique_word
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
            this.label1 = new System.Windows.Forms.Label();
            this.most_unique = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.get_words = new System.Windows.Forms.Button();
            this.words_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Most Unique Word:";
            // 
            // most_unique
            // 
            this.most_unique.AutoSize = true;
            this.most_unique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.most_unique.Location = new System.Drawing.Point(312, 73);
            this.most_unique.Name = "most_unique";
            this.most_unique.Size = new System.Drawing.Size(124, 25);
            this.most_unique.TabIndex = 1;
            this.most_unique.Text = "...Calculating";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(347, 130);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 22);
            this.count.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Get words with more than Occurence";
            // 
            // get_words
            // 
            this.get_words.Location = new System.Drawing.Point(486, 120);
            this.get_words.Name = "get_words";
            this.get_words.Size = new System.Drawing.Size(88, 32);
            this.get_words.TabIndex = 4;
            this.get_words.Text = "Get Words";
            this.get_words.UseVisualStyleBackColor = true;
            this.get_words.Click += new System.EventHandler(this.get_words_Click);
            // 
            // words_label
            // 
            this.words_label.AutoSize = true;
            this.words_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.words_label.Location = new System.Drawing.Point(110, 190);
            this.words_label.Name = "words_label";
            this.words_label.Size = new System.Drawing.Size(69, 25);
            this.words_label.TabIndex = 5;
            this.words_label.Text = "words";
            this.words_label.Visible = false;
            // 
            // unique_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.words_label);
            this.Controls.Add(this.get_words);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.most_unique);
            this.Controls.Add(this.label1);
            this.Name = "unique_word";
            this.Text = "unique_word";
            this.Load += new System.EventHandler(this.unique_word_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label most_unique;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button get_words;
        private System.Windows.Forms.Label words_label;
    }
}