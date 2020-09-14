namespace WordsApp
{
    partial class edit_word
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
            this.word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.label_location = new System.Windows.Forms.Label();
            this.label_line = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(273, 76);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(215, 22);
            this.word.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word to Edit";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(329, 306);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 40);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Visible = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(273, 114);
            this.count.Name = "count";
            this.count.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.count.Size = new System.Drawing.Size(218, 22);
            this.count.TabIndex = 4;
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_location.Location = new System.Drawing.Point(265, 179);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(217, 25);
            this.label_location.TabIndex = 5;
            this.label_location.Text = "Location Of the Word";
            this.label_location.Visible = false;
            // 
            // label_line
            // 
            this.label_line.AutoSize = true;
            this.label_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_line.Location = new System.Drawing.Point(258, 225);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(35, 17);
            this.label_line.TabIndex = 6;
            this.label_line.Text = "Line";
            this.label_line.Visible = false;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(451, 225);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(58, 17);
            this.label_position.TabIndex = 7;
            this.label_position.Text = "Position";
            this.label_position.Visible = false;
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(295, 153);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(168, 23);
            this.validate.TabIndex = 9;
            this.validate.Text = "Press to validate Details";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // edit_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_line);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Name = "edit_word";
            this.Text = "edit_word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_line;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Button validate;
    }
}