namespace CPTS350__HW5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.findLCSButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.limitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.limitLabel = new System.Windows.Forms.Label();
            this.limitTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.string2LableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DNA2Label = new System.Windows.Forms.Label();
            this.string2TextBox = new System.Windows.Forms.TextBox();
            this.string1TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DNA1Label = new System.Windows.Forms.Label();
            this.string1TextBox = new System.Windows.Forms.TextBox();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.controlsGroupBox.SuspendLayout();
            this.controlsTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.limitTableLayoutPanel.SuspendLayout();
            this.inputTableLayoutPanel.SuspendLayout();
            this.string2LableLayoutPanel.SuspendLayout();
            this.string1TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.controlsTableLayoutPanel);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsGroupBox.Location = new System.Drawing.Point(0, 230);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(385, 160);
            this.controlsGroupBox.TabIndex = 0;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "LCS";
            // 
            // controlsTableLayoutPanel
            // 
            this.controlsTableLayoutPanel.ColumnCount = 1;
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 1);
            this.controlsTableLayoutPanel.Controls.Add(this.inputTableLayoutPanel, 0, 0);
            this.controlsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsTableLayoutPanel.Name = "controlsTableLayoutPanel";
            this.controlsTableLayoutPanel.RowCount = 2;
            this.controlsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.Size = new System.Drawing.Size(379, 141);
            this.controlsTableLayoutPanel.TabIndex = 0;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 2;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTableLayoutPanel.Controls.Add(this.findLCSButton, 1, 1);
            this.buttonsTableLayoutPanel.Controls.Add(this.clearButton, 0, 1);
            this.buttonsTableLayoutPanel.Controls.Add(this.limitTableLayoutPanel, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.generateButton, 1, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 73);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 2;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(373, 65);
            this.buttonsTableLayoutPanel.TabIndex = 0;
            // 
            // findLCSButton
            // 
            this.findLCSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findLCSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findLCSButton.Location = new System.Drawing.Point(189, 35);
            this.findLCSButton.Name = "findLCSButton";
            this.findLCSButton.Size = new System.Drawing.Size(181, 27);
            this.findLCSButton.TabIndex = 3;
            this.findLCSButton.Text = "&Find LCS";
            this.findLCSButton.UseVisualStyleBackColor = true;
            this.findLCSButton.Click += new System.EventHandler(this.findLCSButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(3, 35);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(180, 27);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // limitTableLayoutPanel
            // 
            this.limitTableLayoutPanel.ColumnCount = 2;
            this.limitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitTableLayoutPanel.Controls.Add(this.limitLabel, 0, 0);
            this.limitTableLayoutPanel.Controls.Add(this.limitTextBox, 1, 0);
            this.limitTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.limitTableLayoutPanel.Name = "limitTableLayoutPanel";
            this.limitTableLayoutPanel.RowCount = 1;
            this.limitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.limitTableLayoutPanel.Size = new System.Drawing.Size(180, 26);
            this.limitTableLayoutPanel.TabIndex = 0;
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitLabel.Location = new System.Drawing.Point(3, 0);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(84, 26);
            this.limitLabel.TabIndex = 0;
            this.limitLabel.Text = "DNA Limit: ";
            this.limitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limitTextBox
            // 
            this.limitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitTextBox.Location = new System.Drawing.Point(93, 3);
            this.limitTextBox.Name = "limitTextBox";
            this.limitTextBox.Size = new System.Drawing.Size(84, 20);
            this.limitTextBox.TabIndex = 1;
            this.limitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generateButton
            // 
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(189, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(181, 26);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "&Generate DNA";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.ColumnCount = 1;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.Controls.Add(this.string2LableLayoutPanel, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.string1TableLayoutPanel, 0, 0);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 2;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(373, 64);
            this.inputTableLayoutPanel.TabIndex = 1;
            // 
            // string2LableLayoutPanel
            // 
            this.string2LableLayoutPanel.ColumnCount = 2;
            this.string2LableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.38677F));
            this.string2LableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.61323F));
            this.string2LableLayoutPanel.Controls.Add(this.DNA2Label, 0, 0);
            this.string2LableLayoutPanel.Controls.Add(this.string2TextBox, 1, 0);
            this.string2LableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.string2LableLayoutPanel.Location = new System.Drawing.Point(3, 35);
            this.string2LableLayoutPanel.Name = "string2LableLayoutPanel";
            this.string2LableLayoutPanel.RowCount = 1;
            this.string2LableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.string2LableLayoutPanel.Size = new System.Drawing.Size(367, 26);
            this.string2LableLayoutPanel.TabIndex = 1;
            // 
            // DNA2Label
            // 
            this.DNA2Label.AutoSize = true;
            this.DNA2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DNA2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNA2Label.Location = new System.Drawing.Point(3, 0);
            this.DNA2Label.Name = "DNA2Label";
            this.DNA2Label.Size = new System.Drawing.Size(127, 26);
            this.DNA2Label.TabIndex = 0;
            this.DNA2Label.Text = "DNA Strand 2: ";
            this.DNA2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // string2TextBox
            // 
            this.string2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.string2TextBox.Location = new System.Drawing.Point(136, 3);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new System.Drawing.Size(228, 20);
            this.string2TextBox.TabIndex = 1;
            // 
            // string1TableLayoutPanel
            // 
            this.string1TableLayoutPanel.ColumnCount = 2;
            this.string1TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.38677F));
            this.string1TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.61323F));
            this.string1TableLayoutPanel.Controls.Add(this.DNA1Label, 0, 0);
            this.string1TableLayoutPanel.Controls.Add(this.string1TextBox, 1, 0);
            this.string1TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.string1TableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.string1TableLayoutPanel.Name = "string1TableLayoutPanel";
            this.string1TableLayoutPanel.RowCount = 1;
            this.string1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.string1TableLayoutPanel.Size = new System.Drawing.Size(367, 26);
            this.string1TableLayoutPanel.TabIndex = 0;
            // 
            // DNA1Label
            // 
            this.DNA1Label.AutoSize = true;
            this.DNA1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DNA1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNA1Label.Location = new System.Drawing.Point(3, 0);
            this.DNA1Label.Name = "DNA1Label";
            this.DNA1Label.Size = new System.Drawing.Size(127, 26);
            this.DNA1Label.TabIndex = 0;
            this.DNA1Label.Text = "DNA Strand 1: ";
            this.DNA1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // string1TextBox
            // 
            this.string1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.string1TextBox.Location = new System.Drawing.Point(136, 3);
            this.string1TextBox.Name = "string1TextBox";
            this.string1TextBox.Size = new System.Drawing.Size(228, 20);
            this.string1TextBox.TabIndex = 1;
            // 
            // displayTextBox
            // 
            this.displayTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTextBox.Location = new System.Drawing.Point(0, 0);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(385, 230);
            this.displayTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 390);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.controlsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPTS350--HW5";
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.limitTableLayoutPanel.ResumeLayout(false);
            this.limitTableLayoutPanel.PerformLayout();
            this.inputTableLayoutPanel.ResumeLayout(false);
            this.string2LableLayoutPanel.ResumeLayout(false);
            this.string2LableLayoutPanel.PerformLayout();
            this.string1TableLayoutPanel.ResumeLayout(false);
            this.string1TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TableLayoutPanel controlsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel string2LableLayoutPanel;
        private System.Windows.Forms.Label DNA2Label;
        private System.Windows.Forms.TextBox string2TextBox;
        private System.Windows.Forms.TableLayoutPanel string1TableLayoutPanel;
        private System.Windows.Forms.Label DNA1Label;
        private System.Windows.Forms.TextBox string1TextBox;
        private System.Windows.Forms.TableLayoutPanel limitTableLayoutPanel;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.TextBox limitTextBox;
        private System.Windows.Forms.Button findLCSButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

