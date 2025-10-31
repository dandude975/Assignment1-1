namespace Assignment1_1
{
    partial class ControlPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            FloorGndRqst = new Button();
            Floor1Rqst = new Button();
            LogRqst = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Floor:";
            label1.Click += label1_Click_1;
            // 
            // FloorGndRqst
            // 
            FloorGndRqst.Location = new Point(38, 65);
            FloorGndRqst.Name = "FloorGndRqst";
            FloorGndRqst.Size = new Size(100, 100);
            FloorGndRqst.TabIndex = 2;
            FloorGndRqst.Text = "Ground Floor";
            FloorGndRqst.UseVisualStyleBackColor = true;
            FloorGndRqst.Click += FloorGndRqst_Click;
            // 
            // Floor1Rqst
            // 
            Floor1Rqst.Location = new Point(38, 171);
            Floor1Rqst.Name = "Floor1Rqst";
            Floor1Rqst.Size = new Size(100, 100);
            Floor1Rqst.TabIndex = 3;
            Floor1Rqst.Text = "1st Floor";
            Floor1Rqst.UseVisualStyleBackColor = true;
            Floor1Rqst.Click += Floor1Rqst_Click;
            // 
            // LogRqst
            // 
            LogRqst.Location = new Point(38, 292);
            LogRqst.Name = "LogRqst";
            LogRqst.Size = new Size(100, 25);
            LogRqst.TabIndex = 4;
            LogRqst.Text = "Log";
            LogRqst.UseVisualStyleBackColor = true;
            LogRqst.Click += LogRqst_Click;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(177, 327);
            Controls.Add(LogRqst);
            Controls.Add(Floor1Rqst);
            Controls.Add(FloorGndRqst);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ControlPanel";
            Text = "Control";
            Load += ControlPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button FloorGndRqst;
        private Button Floor1Rqst;
        private Button LogRqst;
    }
}
