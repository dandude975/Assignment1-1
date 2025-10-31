namespace Assignment1_1
{
    partial class FirstFloorRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstFloorRequest));
            floor1Call = new Button();
            Display_1floor = new TextBox();
            SuspendLayout();
            // 
            // floor1Call
            // 
            floor1Call.BackColor = SystemColors.ActiveCaptionText;
            floor1Call.BackgroundImage = (Image)resources.GetObject("floor1Call.BackgroundImage");
            floor1Call.Location = new Point(12, 55);
            floor1Call.Name = "floor1Call";
            floor1Call.Size = new Size(100, 100);
            floor1Call.TabIndex = 0;
            floor1Call.UseVisualStyleBackColor = false;
            floor1Call.Click += floor1Call_Click;
            // 
            // Display_1floor
            // 
            Display_1floor.BackColor = SystemColors.ActiveCaptionText;
            Display_1floor.BorderStyle = BorderStyle.None;
            Display_1floor.ForeColor = SystemColors.ButtonFace;
            Display_1floor.Location = new Point(12, 12);
            Display_1floor.Name = "Display_1floor";
            Display_1floor.ReadOnly = true;
            Display_1floor.Size = new Size(100, 16);
            Display_1floor.TabIndex = 1;
            Display_1floor.TabStop = false;
            Display_1floor.TextAlign = HorizontalAlignment.Center;
            Display_1floor.TextChanged += Display_1floor_TextChanged;
            // 
            // FirstFloorRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(120, 167);
            Controls.Add(Display_1floor);
            Controls.Add(floor1Call);
            Name = "FirstFloorRequest";
            Text = "FirstFloorRequest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button floor1Call;
        private TextBox Display_1floor;
    }
}