namespace PostmanClone.UI
{
    partial class Dashboard
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
            apiLabel = new Label();
            apiText = new TextBox();
            resultWindow = new TextBox();
            callAPI = new Button();
            statusStrip = new StatusStrip();
            stripStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(42, 21);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(127, 39);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API Url:";
            // 
            // apiText
            // 
            apiText.BackColor = SystemColors.Info;
            apiText.Location = new Point(42, 63);
            apiText.Name = "apiText";
            apiText.Size = new Size(768, 47);
            apiText.TabIndex = 2;
            // 
            // resultWindow
            // 
            resultWindow.BackColor = SystemColors.Info;
            resultWindow.BorderStyle = BorderStyle.FixedSingle;
            resultWindow.Location = new Point(42, 229);
            resultWindow.Multiline = true;
            resultWindow.Name = "resultWindow";
            resultWindow.ReadOnly = true;
            resultWindow.ScrollBars = ScrollBars.Both;
            resultWindow.Size = new Size(768, 439);
            resultWindow.TabIndex = 3;
            // 
            // callAPI
            // 
            callAPI.BackColor = SystemColors.Info;
            callAPI.Location = new Point(854, 92);
            callAPI.Name = "callAPI";
            callAPI.Size = new Size(112, 47);
            callAPI.TabIndex = 4;
            callAPI.Text = "GO";
            callAPI.UseVisualStyleBackColor = false;
            callAPI.Click += callAPI_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = SystemColors.Info;
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { stripStatus });
            statusStrip.Location = new Point(0, 696);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1013, 40);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // stripStatus
            // 
            stripStatus.BackColor = SystemColors.Info;
            stripStatus.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stripStatus.Name = "stripStatus";
            stripStatus.Size = new Size(82, 33);
            stripStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(42, 187);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(122, 39);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1013, 736);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(callAPI);
            Controls.Add(resultWindow);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Font = new Font("Comic Sans MS", 14F);
            Margin = new Padding(5);
            Name = "Dashboard";
            Text = "Dashboard";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label apiLabel;
        private TextBox apiText;
        private TextBox resultWindow;
        private Button callAPI;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel stripStatus;
    }
}
