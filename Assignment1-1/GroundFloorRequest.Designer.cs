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
            SuspendLayout();
            // 
            // floorGndCall
            // 
            floorGndCall.BackColor = SystemColors.ActiveCaptionText;
            floorGndCall.BackgroundImage = (Image)resources.GetObject("floorGndCall.BackgroundImage");
            floorGndCall.Location = new Point(12, 12);
            floorGndCall.Name = "floorGndCall";
            floorGndCall.Size = new Size(100, 100);
            floorGndCall.TabIndex = 1;
            floorGndCall.UseVisualStyleBackColor = false;
            floorGndCall.Click += floorGndCall_Click;
            // 
            // GroundFloorRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(121, 121);
            Controls.Add(floorGndCall);
            Name = "GroundFloorRequest";
            Text = "GroundFloorRequest";
            ResumeLayout(false);
        }

        #endregion

        private Button floorGndCall;
    }
}