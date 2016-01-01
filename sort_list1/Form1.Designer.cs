namespace sort_list1
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
            this.btnSortName = new System.Windows.Forms.Button();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSortAge = new System.Windows.Forms.Button();
            this.btnSortSalary = new System.Windows.Forms.Button();
            this.btnSortOccupation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(355, 34);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(160, 35);
            this.btnSortName.TabIndex = 1;
            this.btnSortName.Text = "Sort By Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(17, 34);
            this.txbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbData.Multiline = true;
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(321, 240);
            this.txbData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // btnSortAge
            // 
            this.btnSortAge.Location = new System.Drawing.Point(355, 79);
            this.btnSortAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortAge.Name = "btnSortAge";
            this.btnSortAge.Size = new System.Drawing.Size(160, 35);
            this.btnSortAge.TabIndex = 2;
            this.btnSortAge.Text = "Sort By Age";
            this.btnSortAge.UseVisualStyleBackColor = true;
            // 
            // btnSortSalary
            // 
            this.btnSortSalary.Location = new System.Drawing.Point(355, 124);
            this.btnSortSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortSalary.Name = "btnSortSalary";
            this.btnSortSalary.Size = new System.Drawing.Size(160, 35);
            this.btnSortSalary.TabIndex = 3;
            this.btnSortSalary.Text = "Sort By Salary";
            this.btnSortSalary.UseVisualStyleBackColor = true;
            // 
            // btnSortOccupation
            // 
            this.btnSortOccupation.Location = new System.Drawing.Point(355, 169);
            this.btnSortOccupation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortOccupation.Name = "btnSortOccupation";
            this.btnSortOccupation.Size = new System.Drawing.Size(160, 35);
            this.btnSortOccupation.TabIndex = 4;
            this.btnSortOccupation.Text = "Sort By Occupation";
            this.btnSortOccupation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 288);
            this.Controls.Add(this.btnSortOccupation);
            this.Controls.Add(this.btnSortSalary);
            this.Controls.Add(this.btnSortAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.btnSortName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortAge;
        private System.Windows.Forms.Button btnSortSalary;
        private System.Windows.Forms.Button btnSortOccupation;
    }
}

