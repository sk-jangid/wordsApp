namespace WordsApp
{
    partial class TreeOperations
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
            this.wordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_word = new System.Windows.Forms.Button();
            this.remove_word = new System.Windows.Forms.Button();
            this.display_collocation = new System.Windows.Forms.Button();
            this.most_unique_word = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Unique words in text:";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCount.ForeColor = System.Drawing.Color.DarkRed;
            this.wordCount.Location = new System.Drawing.Point(413, 36);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(144, 25);
            this.wordCount.TabIndex = 1;
            this.wordCount.Text = "....Calculating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unique words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Count";
            // 
            // edit_word
            // 
            this.edit_word.Location = new System.Drawing.Point(19, 272);
            this.edit_word.Name = "edit_word";
            this.edit_word.Size = new System.Drawing.Size(93, 34);
            this.edit_word.TabIndex = 5;
            this.edit_word.Text = "Edit Word";
            this.edit_word.UseVisualStyleBackColor = true;
            this.edit_word.Click += new System.EventHandler(this.edit_word_Click);
            // 
            // remove_word
            // 
            this.remove_word.Location = new System.Drawing.Point(138, 272);
            this.remove_word.Name = "remove_word";
            this.remove_word.Size = new System.Drawing.Size(110, 34);
            this.remove_word.TabIndex = 6;
            this.remove_word.Text = "Remove Word";
            this.remove_word.UseVisualStyleBackColor = true;
            this.remove_word.Click += new System.EventHandler(this.remove_word_Click);
            // 
            // display_collocation
            // 
            this.display_collocation.Location = new System.Drawing.Point(220, 321);
            this.display_collocation.Name = "display_collocation";
            this.display_collocation.Size = new System.Drawing.Size(192, 34);
            this.display_collocation.TabIndex = 7;
            this.display_collocation.Text = "Display Collocation";
            this.display_collocation.UseVisualStyleBackColor = true;
            this.display_collocation.Click += new System.EventHandler(this.display_collocation_Click);
            // 
            // most_unique_word
            // 
            this.most_unique_word.Location = new System.Drawing.Point(19, 321);
            this.most_unique_word.Name = "most_unique_word";
            this.most_unique_word.Size = new System.Drawing.Size(163, 34);
            this.most_unique_word.TabIndex = 8;
            this.most_unique_word.Text = "Most Unique Word";
            this.most_unique_word.UseVisualStyleBackColor = true;
            this.most_unique_word.Click += new System.EventHandler(this.most_unique_word_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(269, 272);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(143, 34);
            this.search.TabIndex = 9;
            this.search.Text = "Search For a Word";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(137, 381);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(111, 27);
            this.display.TabIndex = 11;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // TreeOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(733, 433);
            this.Controls.Add(this.display);
            this.Controls.Add(this.search);
            this.Controls.Add(this.most_unique_word);
            this.Controls.Add(this.display_collocation);
            this.Controls.Add(this.remove_word);
            this.Controls.Add(this.edit_word);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.label1);
            this.Name = "TreeOperations";
            this.Text = "TreeOperations";
            this.Load += new System.EventHandler(this.TreeOperations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button edit_word;
        private System.Windows.Forms.Button remove_word;
        private System.Windows.Forms.Button display_collocation;
        private System.Windows.Forms.Button most_unique_word;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button display;
    }
}