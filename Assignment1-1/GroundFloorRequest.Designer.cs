namespace Assignment1_1
{
    partial class GroundFloorRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroundFloorRequest));
            floorGndCall = new Button();
            display_gfloor = new TextBox();
            SuspendLayout();
            // 
            // floorGndCall
            // 
            floorGndCall.BackColor = SystemColors.ActiveCaptionText;
            floorGndCall.BackgroundImage = (Image)resources.GetObject("floorGndCall.BackgroundImage");
            floorGndCall.Location = new Point(9, 44);
            floorGndCall.Name = "floorGndCall";
            floorGndCall.Size = new Size(100, 100);
            floorGndCall.TabIndex = 1;
            floorGndCall.UseVisualStyleBackColor = false;
            floorGndCall.Click += floorGndCall_Click;
            // 
            // display_gfloor
            // 
            display_gfloor.BackColor = SystemColors.ActiveCaptionText;
            display_gfloor.BorderStyle = BorderStyle.None;
            display_gfloor.ForeColor = SystemColors.Window;
            display_gfloor.Location = new Point(12, 12);
            display_gfloor.Name = "display_gfloor";
            display_gfloor.ReadOnly = true;
            display_gfloor.Size = new Size(100, 16);
            display_gfloor.TabIndex = 2;
            display_gfloor.TabStop = false;
            display_gfloor.TextAlign = HorizontalAlignment.Center;
            display_gfloor.TextChanged += display_gfloor_TextChanged;
            // 
            // GroundFloorRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(121, 156);
            Controls.Add(display_gfloor);
            Controls.Add(floorGndCall);
            Name = "GroundFloorRequest";
            Text = "GroundFloorRequest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button floorGndCall;
        private TextBox display_gfloor;
    }
}