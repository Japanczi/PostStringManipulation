namespace WindowsFormsProject1
{
    partial class Main
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.RegexExecuteButton = new System.Windows.Forms.Button();
            this.RegexResultWindow = new System.Windows.Forms.TextBox();
            this.RegexPatternBox = new System.Windows.Forms.TextBox();
            this.RegexBoxLabel = new System.Windows.Forms.Label();
            this.IncrementLabel = new System.Windows.Forms.Label();
            this.StartOnBox = new System.Windows.Forms.TextBox();
            this.IncrementBoxLabel = new System.Windows.Forms.Label();
            this.IncrementBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTokenManipulatorGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalValueOfRepetitionsBox = new System.Windows.Forms.TextBox();
            this.RepeatControl = new System.Windows.Forms.Label();
            this.RepeatAmountBox = new System.Windows.Forms.TextBox();
            this.DateTokenManipulatorSwitch = new System.Windows.Forms.Button();
            this.postStringSeparatorGroup = new System.Windows.Forms.GroupBox();
            this.postStringVisibilitySwitch = new System.Windows.Forms.Button();
            this.postStringSeparatorMain = new System.Windows.Forms.GroupBox();
            this.FieldsToOutputButton = new System.Windows.Forms.Button();
            this.GenerateFieldsButton = new System.Windows.Forms.Button();
            this.postStringOutput = new System.Windows.Forms.TextBox();
            this.postStringInput = new System.Windows.Forms.TextBox();
            this.DateTokenManipulatorGroup.SuspendLayout();
            this.postStringSeparatorMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(18, 123);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(302, 119);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // RegexExecuteButton
            // 
            this.RegexExecuteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RegexExecuteButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RegexExecuteButton.Location = new System.Drawing.Point(345, 171);
            this.RegexExecuteButton.Name = "RegexExecuteButton";
            this.RegexExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.RegexExecuteButton.TabIndex = 1;
            this.RegexExecuteButton.Text = ">>>";
            this.RegexExecuteButton.UseVisualStyleBackColor = false;
            this.RegexExecuteButton.Click += new System.EventHandler(this.RegexExecuteButton_Click);
            // 
            // RegexResultWindow
            // 
            this.RegexResultWindow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RegexResultWindow.Location = new System.Drawing.Point(453, 123);
            this.RegexResultWindow.Multiline = true;
            this.RegexResultWindow.Name = "RegexResultWindow";
            this.RegexResultWindow.ReadOnly = true;
            this.RegexResultWindow.Size = new System.Drawing.Size(302, 119);
            this.RegexResultWindow.TabIndex = 0;
            this.RegexResultWindow.Text = "Results";
            // 
            // RegexPatternBox
            // 
            this.RegexPatternBox.Location = new System.Drawing.Point(18, 272);
            this.RegexPatternBox.Name = "RegexPatternBox";
            this.RegexPatternBox.Size = new System.Drawing.Size(301, 20);
            this.RegexPatternBox.TabIndex = 2;
            // 
            // RegexBoxLabel
            // 
            this.RegexBoxLabel.AutoSize = true;
            this.RegexBoxLabel.Location = new System.Drawing.Point(15, 256);
            this.RegexBoxLabel.Name = "RegexBoxLabel";
            this.RegexBoxLabel.Size = new System.Drawing.Size(44, 13);
            this.RegexBoxLabel.TabIndex = 3;
            this.RegexBoxLabel.Text = "Pattern:";
            // 
            // IncrementLabel
            // 
            this.IncrementLabel.AutoSize = true;
            this.IncrementLabel.Location = new System.Drawing.Point(15, 308);
            this.IncrementLabel.Name = "IncrementLabel";
            this.IncrementLabel.Size = new System.Drawing.Size(47, 13);
            this.IncrementLabel.TabIndex = 5;
            this.IncrementLabel.Text = "Start on:";
            // 
            // StartOnBox
            // 
            this.StartOnBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartOnBox.Location = new System.Drawing.Point(18, 324);
            this.StartOnBox.Name = "StartOnBox";
            this.StartOnBox.Size = new System.Drawing.Size(67, 20);
            this.StartOnBox.TabIndex = 4;
            this.StartOnBox.Text = "6";
            this.StartOnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StartOnBox.TextChanged += new System.EventHandler(this.StartOnBox_TextChanged);
            // 
            // IncrementBoxLabel
            // 
            this.IncrementBoxLabel.AutoSize = true;
            this.IncrementBoxLabel.Location = new System.Drawing.Point(87, 308);
            this.IncrementBoxLabel.Name = "IncrementBoxLabel";
            this.IncrementBoxLabel.Size = new System.Drawing.Size(71, 13);
            this.IncrementBoxLabel.TabIndex = 7;
            this.IncrementBoxLabel.Text = "Increment by:";
            // 
            // IncrementBox
            // 
            this.IncrementBox.Location = new System.Drawing.Point(96, 324);
            this.IncrementBox.Name = "IncrementBox";
            this.IncrementBox.Size = new System.Drawing.Size(67, 20);
            this.IncrementBox.TabIndex = 6;
            this.IncrementBox.Text = "1";
            this.IncrementBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IncrementBox.TextChanged += new System.EventHandler(this.IncrementBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input";
            // 
            // DateTokenManipulatorGroup
            // 
            this.DateTokenManipulatorGroup.Controls.Add(this.label2);
            this.DateTokenManipulatorGroup.Controls.Add(this.FinalValueOfRepetitionsBox);
            this.DateTokenManipulatorGroup.Controls.Add(this.RepeatControl);
            this.DateTokenManipulatorGroup.Controls.Add(this.RepeatAmountBox);
            this.DateTokenManipulatorGroup.Controls.Add(this.label1);
            this.DateTokenManipulatorGroup.Controls.Add(this.IncrementBoxLabel);
            this.DateTokenManipulatorGroup.Controls.Add(this.IncrementBox);
            this.DateTokenManipulatorGroup.Controls.Add(this.IncrementLabel);
            this.DateTokenManipulatorGroup.Controls.Add(this.StartOnBox);
            this.DateTokenManipulatorGroup.Controls.Add(this.RegexBoxLabel);
            this.DateTokenManipulatorGroup.Controls.Add(this.RegexPatternBox);
            this.DateTokenManipulatorGroup.Controls.Add(this.RegexExecuteButton);
            this.DateTokenManipulatorGroup.Controls.Add(this.RegexResultWindow);
            this.DateTokenManipulatorGroup.Controls.Add(this.InputBox);
            this.DateTokenManipulatorGroup.Location = new System.Drawing.Point(17, 71);
            this.DateTokenManipulatorGroup.Name = "DateTokenManipulatorGroup";
            this.DateTokenManipulatorGroup.Size = new System.Drawing.Size(771, 367);
            this.DateTokenManipulatorGroup.TabIndex = 9;
            this.DateTokenManipulatorGroup.TabStop = false;
            this.DateTokenManipulatorGroup.Text = "ReplaceIncrementGroup";
            this.DateTokenManipulatorGroup.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Will go up to:";
            // 
            // FinalValueOfRepetitionsBox
            // 
            this.FinalValueOfRepetitionsBox.Location = new System.Drawing.Point(252, 324);
            this.FinalValueOfRepetitionsBox.Name = "FinalValueOfRepetitionsBox";
            this.FinalValueOfRepetitionsBox.ReadOnly = true;
            this.FinalValueOfRepetitionsBox.Size = new System.Drawing.Size(67, 20);
            this.FinalValueOfRepetitionsBox.TabIndex = 11;
            // 
            // RepeatControl
            // 
            this.RepeatControl.AutoSize = true;
            this.RepeatControl.Location = new System.Drawing.Point(183, 308);
            this.RepeatControl.Name = "RepeatControl";
            this.RepeatControl.Size = new System.Drawing.Size(42, 13);
            this.RepeatControl.TabIndex = 10;
            this.RepeatControl.Text = "Repeat";
            // 
            // RepeatAmountBox
            // 
            this.RepeatAmountBox.Location = new System.Drawing.Point(174, 324);
            this.RepeatAmountBox.Name = "RepeatAmountBox";
            this.RepeatAmountBox.Size = new System.Drawing.Size(67, 20);
            this.RepeatAmountBox.TabIndex = 9;
            this.RepeatAmountBox.Text = "5";
            this.RepeatAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RepeatAmountBox.TextChanged += new System.EventHandler(this.RepeatAmountBox_TextChanged);
            // 
            // DateTokenManipulatorSwitch
            // 
            this.DateTokenManipulatorSwitch.Location = new System.Drawing.Point(17, 13);
            this.DateTokenManipulatorSwitch.Name = "DateTokenManipulatorSwitch";
            this.DateTokenManipulatorSwitch.Size = new System.Drawing.Size(117, 36);
            this.DateTokenManipulatorSwitch.TabIndex = 10;
            this.DateTokenManipulatorSwitch.Text = "Date Token Manipulator";
            this.DateTokenManipulatorSwitch.UseVisualStyleBackColor = true;
            this.DateTokenManipulatorSwitch.Click += new System.EventHandler(this.DataTokenManipulatorVisibilitySwitchMethod);
            // 
            // postStringSeparatorGroup
            // 
            this.postStringSeparatorGroup.Location = new System.Drawing.Point(6, 0);
            this.postStringSeparatorGroup.Name = "postStringSeparatorGroup";
            this.postStringSeparatorGroup.Size = new System.Drawing.Size(782, 292);
            this.postStringSeparatorGroup.TabIndex = 14;
            this.postStringSeparatorGroup.TabStop = false;
            this.postStringSeparatorGroup.Text = "postStringSeparator";
            // 
            // postStringVisibilitySwitch
            // 
            this.postStringVisibilitySwitch.Location = new System.Drawing.Point(141, 12);
            this.postStringVisibilitySwitch.Name = "postStringVisibilitySwitch";
            this.postStringVisibilitySwitch.Size = new System.Drawing.Size(117, 36);
            this.postStringVisibilitySwitch.TabIndex = 15;
            this.postStringVisibilitySwitch.Text = "Post String Separator";
            this.postStringVisibilitySwitch.UseVisualStyleBackColor = true;
            this.postStringVisibilitySwitch.Click += new System.EventHandler(this.postStringVisibilitySwitchMethod);
            // 
            // postStringSeparatorMain
            // 
            this.postStringSeparatorMain.Controls.Add(this.FieldsToOutputButton);
            this.postStringSeparatorMain.Controls.Add(this.GenerateFieldsButton);
            this.postStringSeparatorMain.Controls.Add(this.postStringOutput);
            this.postStringSeparatorMain.Controls.Add(this.postStringInput);
            this.postStringSeparatorMain.Controls.Add(this.postStringSeparatorGroup);
            this.postStringSeparatorMain.Location = new System.Drawing.Point(0, 55);
            this.postStringSeparatorMain.Name = "postStringSeparatorMain";
            this.postStringSeparatorMain.Size = new System.Drawing.Size(800, 391);
            this.postStringSeparatorMain.TabIndex = 13;
            this.postStringSeparatorMain.TabStop = false;
            // 
            // FieldsToOutputButton
            // 
            this.FieldsToOutputButton.Location = new System.Drawing.Point(367, 347);
            this.FieldsToOutputButton.Name = "FieldsToOutputButton";
            this.FieldsToOutputButton.Size = new System.Drawing.Size(59, 36);
            this.FieldsToOutputButton.TabIndex = 18;
            this.FieldsToOutputButton.Text = "Fields to Output";
            this.FieldsToOutputButton.UseVisualStyleBackColor = true;
            this.FieldsToOutputButton.Click += new System.EventHandler(this.FieldsToOutputButton_Click);
            // 
            // GenerateFieldsButton
            // 
            this.GenerateFieldsButton.Location = new System.Drawing.Point(367, 301);
            this.GenerateFieldsButton.Name = "GenerateFieldsButton";
            this.GenerateFieldsButton.Size = new System.Drawing.Size(59, 36);
            this.GenerateFieldsButton.TabIndex = 17;
            this.GenerateFieldsButton.Text = "Generate Fields";
            this.GenerateFieldsButton.UseVisualStyleBackColor = true;
            this.GenerateFieldsButton.Click += new System.EventHandler(this.GenerateFieldsButton_Click);
            // 
            // postStringOutput
            // 
            this.postStringOutput.BackColor = System.Drawing.Color.Bisque;
            this.postStringOutput.Location = new System.Drawing.Point(433, 299);
            this.postStringOutput.Multiline = true;
            this.postStringOutput.Name = "postStringOutput";
            this.postStringOutput.Size = new System.Drawing.Size(355, 86);
            this.postStringOutput.TabIndex = 16;
            // 
            // postStringInput
            // 
            this.postStringInput.Location = new System.Drawing.Point(6, 299);
            this.postStringInput.Multiline = true;
            this.postStringInput.Name = "postStringInput";
            this.postStringInput.Size = new System.Drawing.Size(355, 86);
            this.postStringInput.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postStringSeparatorMain);
            this.Controls.Add(this.postStringVisibilitySwitch);
            this.Controls.Add(this.DateTokenManipulatorSwitch);
            this.Controls.Add(this.DateTokenManipulatorGroup);
            this.Name = "Main";
            this.Text = "Replace & Increment";
            this.DateTokenManipulatorGroup.ResumeLayout(false);
            this.DateTokenManipulatorGroup.PerformLayout();
            this.postStringSeparatorMain.ResumeLayout(false);
            this.postStringSeparatorMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button RegexExecuteButton;
        private System.Windows.Forms.TextBox RegexResultWindow;
        private System.Windows.Forms.TextBox RegexPatternBox;
        private System.Windows.Forms.Label RegexBoxLabel;
        private System.Windows.Forms.Label IncrementLabel;
        public System.Windows.Forms.TextBox StartOnBox;
        private System.Windows.Forms.Label IncrementBoxLabel;
        public System.Windows.Forms.TextBox IncrementBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DateTokenManipulatorGroup;
        private System.Windows.Forms.Button DateTokenManipulatorSwitch;
        public System.Windows.Forms.TextBox FinalValueOfRepetitionsBox;
        private System.Windows.Forms.Label RepeatControl;
        public System.Windows.Forms.TextBox RepeatAmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox postStringSeparatorGroup;
        private System.Windows.Forms.Button postStringVisibilitySwitch;
        private System.Windows.Forms.GroupBox postStringSeparatorMain;
        private System.Windows.Forms.TextBox postStringInput;
        private System.Windows.Forms.TextBox postStringOutput;
        private System.Windows.Forms.Button FieldsToOutputButton;
        private System.Windows.Forms.Button GenerateFieldsButton;
    }
}

