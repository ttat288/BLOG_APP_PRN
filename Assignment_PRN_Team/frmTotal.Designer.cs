namespace BlogWinApp
{
    partial class frmTotal
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
            pieChart = new Sunny.UI.UIPieChart();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            approveLbl = new System.Windows.Forms.Label();
            waitingLbl = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            totalLbl = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pieChart
            // 
            pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            pieChart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pieChart.LegendFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pieChart.Location = new System.Drawing.Point(0, 0);
            pieChart.MinimumSize = new System.Drawing.Size(1, 1);
            pieChart.Name = "pieChart";
            pieChart.Radius = 4;
            pieChart.Size = new System.Drawing.Size(1107, 685);
            pieChart.SubFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pieChart.TabIndex = 9;
            pieChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1107, 90);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1104, 54);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            panel2.Controls.Add(totalLbl);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(approveLbl);
            panel2.Controls.Add(waitingLbl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(858, 93);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(249, 592);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel4.Location = new System.Drawing.Point(0, 162);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(58, 41);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Highlight;
            panel3.Location = new System.Drawing.Point(0, 98);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(58, 41);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(95, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 41);
            label6.TabIndex = 4;
            label6.Text = "Post";
            // 
            // approveLbl
            // 
            approveLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            approveLbl.Location = new System.Drawing.Point(189, 167);
            approveLbl.Name = "approveLbl";
            approveLbl.Size = new System.Drawing.Size(60, 31);
            approveLbl.TabIndex = 3;
            approveLbl.Text = "1";
            approveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitingLbl
            // 
            waitingLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            waitingLbl.Location = new System.Drawing.Point(187, 102);
            waitingLbl.Name = "waitingLbl";
            waitingLbl.Size = new System.Drawing.Size(62, 31);
            waitingLbl.TabIndex = 2;
            waitingLbl.Text = "1";
            waitingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            waitingLbl.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(64, 167);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(131, 31);
            label3.TabIndex = 1;
            label3.Text = "Approved :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(64, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 31);
            label2.TabIndex = 0;
            label2.Text = "Waiting : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(64, 227);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 31);
            label4.TabIndex = 7;
            label4.Text = "Total :";
            // 
            // totalLbl
            // 
            totalLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            totalLbl.Location = new System.Drawing.Point(189, 227);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new System.Drawing.Size(60, 31);
            totalLbl.TabIndex = 8;
            totalLbl.Text = "1";
            totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTotal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Teal;
            ClientSize = new System.Drawing.Size(1107, 685);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pieChart);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmTotal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPieChart pieChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label waitingLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label approveLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label4;
    }
}