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
            SuspendLayout();
            // 
            // floor1Call
            // 
            floor1Call.BackColor = SystemColors.ActiveCaptionText;
            floor1Call.BackgroundImage = (Image)resources.GetObject("floor1Call.BackgroundImage");
            floor1Call.Location = new Point(12, 12);
            floor1Call.Name = "floor1Call";
            floor1Call.Size = new Size(100, 100);
            floor1Call.TabIndex = 0;
            floor1Call.UseVisualStyleBackColor = false;
            floor1Call.Click += floor1Call_Click;
            // 
            // FirstFloorRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(120, 123);
            Controls.Add(floor1Call);
            Name = "FirstFloorRequest";
            Text = "FirstFloorRequest";
            ResumeLayout(false);
        }

        #endregion

        private Button floor1Call;
    }
}