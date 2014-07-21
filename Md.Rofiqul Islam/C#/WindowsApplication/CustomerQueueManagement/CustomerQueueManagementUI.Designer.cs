namespace CustomerQueueManagement
{
    partial class CustomerQueueManagementUI
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
            this.nameEnTextBox = new System.Windows.Forms.TextBox();
            this.complainDequeueTextBox = new System.Windows.Forms.TextBox();
            this.deQueueButton = new System.Windows.Forms.Button();
            this.waitListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameDequeueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.complainEnTextBox = new System.Windows.Forms.TextBox();
            this.serialDequeueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ebQueueButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameEnTextBox
            // 
            this.nameEnTextBox.Location = new System.Drawing.Point(89, 24);
            this.nameEnTextBox.Name = "nameEnTextBox";
            this.nameEnTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEnTextBox.TabIndex = 0;
            // 
            // complainDequeueTextBox
            // 
            this.complainDequeueTextBox.Location = new System.Drawing.Point(192, 96);
            this.complainDequeueTextBox.Multiline = true;
            this.complainDequeueTextBox.Name = "complainDequeueTextBox";
            this.complainDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainDequeueTextBox.TabIndex = 2;
            // 
            // deQueueButton
            // 
            this.deQueueButton.Location = new System.Drawing.Point(192, 122);
            this.deQueueButton.Name = "deQueueButton";
            this.deQueueButton.Size = new System.Drawing.Size(75, 23);
            this.deQueueButton.TabIndex = 3;
            this.deQueueButton.Text = "Dequeue";
            this.deQueueButton.UseVisualStyleBackColor = true;
            this.deQueueButton.Click += new System.EventHandler(this.deQueueButton_Click);
            // 
            // waitListView
            // 
            this.waitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.waitListView.Location = new System.Drawing.Point(70, 19);
            this.waitListView.Name = "waitListView";
            this.waitListView.Size = new System.Drawing.Size(351, 75);
            this.waitListView.TabIndex = 4;
            this.waitListView.UseCompatibleStateImageBehavior = false;
            this.waitListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "serialNo";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            // 
            // nameDequeueTextBox
            // 
            this.nameDequeueTextBox.Location = new System.Drawing.Point(192, 56);
            this.nameDequeueTextBox.Name = "nameDequeueTextBox";
            this.nameDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameDequeueTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SerialNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Complain";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waitListView);
            this.groupBox1.Location = new System.Drawing.Point(58, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiting";
            // 
            // complainEnTextBox
            // 
            this.complainEnTextBox.Location = new System.Drawing.Point(89, 63);
            this.complainEnTextBox.Name = "complainEnTextBox";
            this.complainEnTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainEnTextBox.TabIndex = 10;
            // 
            // serialDequeueTextBox
            // 
            this.serialDequeueTextBox.Location = new System.Drawing.Point(192, 20);
            this.serialDequeueTextBox.Name = "serialDequeueTextBox";
            this.serialDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialDequeueTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ebQueueButton);
            this.groupBox2.Controls.Add(this.complainEnTextBox);
            this.groupBox2.Controls.Add(this.nameEnTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(39, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 161);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enqueue";
            // 
            // ebQueueButton
            // 
            this.ebQueueButton.Location = new System.Drawing.Point(79, 103);
            this.ebQueueButton.Name = "ebQueueButton";
            this.ebQueueButton.Size = new System.Drawing.Size(75, 23);
            this.ebQueueButton.TabIndex = 11;
            this.ebQueueButton.Text = "Enqueue";
            this.ebQueueButton.UseVisualStyleBackColor = true;
            this.ebQueueButton.Click += new System.EventHandler(this.ebQueueButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.deQueueButton);
            this.groupBox3.Controls.Add(this.serialDequeueTextBox);
            this.groupBox3.Controls.Add(this.nameDequeueTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.complainDequeueTextBox);
            this.groupBox3.Location = new System.Drawing.Point(272, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 173);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dequeue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Complain";
            // 
            // CustomerQueueManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQueueManagementUI";
            this.Text = "Customer Queue Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameEnTextBox;
        private System.Windows.Forms.Button enQueueButton;
        private System.Windows.Forms.TextBox complainDequeueTextBox;
        private System.Windows.Forms.Button deQueueButton;
        private System.Windows.Forms.ListView waitListView;
        private System.Windows.Forms.TextBox nameDequeueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox complainEnTextBox;
        private System.Windows.Forms.TextBox serialDequeueTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ebQueueButton;
    }
}

