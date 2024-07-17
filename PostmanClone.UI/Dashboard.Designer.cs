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
            httpVerpSelection = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyText = new TextBox();
            outputTab = new TabPage();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            outputTab.SuspendLayout();
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
            apiText.Location = new Point(209, 63);
            apiText.Name = "apiText";
            apiText.PlaceholderText = "https://jsonplaceholder.typicode.com/";
            apiText.Size = new Size(601, 47);
            apiText.TabIndex = 2;
            // 
            // resultWindow
            // 
            resultWindow.BackColor = SystemColors.Info;
            resultWindow.BorderStyle = BorderStyle.FixedSingle;
            resultWindow.Dock = DockStyle.Fill;
            resultWindow.Location = new Point(3, 3);
            resultWindow.Multiline = true;
            resultWindow.Name = "resultWindow";
            resultWindow.ReadOnly = true;
            resultWindow.ScrollBars = ScrollBars.Both;
            resultWindow.Size = new Size(754, 495);
            resultWindow.TabIndex = 3;
            // 
            // callAPI
            // 
            callAPI.BackColor = SystemColors.Info;
            callAPI.Location = new Point(855, 62);
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
            // httpVerpSelection
            // 
            httpVerpSelection.BackColor = SystemColors.Info;
            httpVerpSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerpSelection.FormattingEnabled = true;
            httpVerpSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            httpVerpSelection.Location = new Point(42, 63);
            httpVerpSelection.Name = "httpVerpSelection";
            httpVerpSelection.Size = new Size(147, 47);
            httpVerpSelection.TabIndex = 7;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(outputTab);
            callData.Location = new Point(42, 141);
            callData.Multiline = true;
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(768, 539);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.BackColor = SystemColors.Info;
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new Point(4, 48);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(760, 487);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            // 
            // bodyText
            // 
            bodyText.BackColor = SystemColors.Info;
            bodyText.BorderStyle = BorderStyle.FixedSingle;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.ScrollBars = ScrollBars.Both;
            bodyText.Size = new Size(754, 481);
            bodyText.TabIndex = 4;
            // 
            // outputTab
            // 
            outputTab.Controls.Add(resultWindow);
            outputTab.Location = new Point(4, 34);
            outputTab.Name = "outputTab";
            outputTab.Padding = new Padding(3);
            outputTab.Size = new Size(760, 501);
            outputTab.TabIndex = 1;
            outputTab.Text = "Results";
            outputTab.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1013, 736);
            Controls.Add(callData);
            Controls.Add(httpVerpSelection);
            Controls.Add(statusStrip);
            Controls.Add(callAPI);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Font = new Font("Comic Sans MS", 14F);
            Margin = new Padding(5);
            Name = "Dashboard";
            Text = "Dashboard";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            outputTab.ResumeLayout(false);
            outputTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label apiLabel;
        private TextBox apiText;
        private TextBox resultWindow;
        private Button callAPI;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel stripStatus;
        private ComboBox httpVerpSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage outputTab;
        private TextBox bodyText;
    }
}
