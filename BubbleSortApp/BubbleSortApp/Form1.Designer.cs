namespace BubbleSortApp
{
    partial class BubbleSortAppGUI
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
            this.BubbleSortGroupBox = new System.Windows.Forms.GroupBox();
            this.ComponentsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.controlsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.genRandArrButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.BubbleSortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentsSplitContainer)).BeginInit();
            this.ComponentsSplitContainer.Panel1.SuspendLayout();
            this.ComponentsSplitContainer.Panel2.SuspendLayout();
            this.ComponentsSplitContainer.SuspendLayout();
            this.controlsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BubbleSortGroupBox
            // 
            this.BubbleSortGroupBox.Controls.Add(this.ComponentsSplitContainer);
            this.BubbleSortGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BubbleSortGroupBox.Location = new System.Drawing.Point(0, 0);
            this.BubbleSortGroupBox.Name = "BubbleSortGroupBox";
            this.BubbleSortGroupBox.Size = new System.Drawing.Size(284, 262);
            this.BubbleSortGroupBox.TabIndex = 0;
            this.BubbleSortGroupBox.TabStop = false;
            this.BubbleSortGroupBox.Text = "Bubble Sort";
            // 
            // ComponentsSplitContainer
            // 
            this.ComponentsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentsSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.ComponentsSplitContainer.Name = "ComponentsSplitContainer";
            this.ComponentsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ComponentsSplitContainer.Panel1
            // 
            this.ComponentsSplitContainer.Panel1.Controls.Add(this.DisplayTextBox);
            // 
            // ComponentsSplitContainer.Panel2
            // 
            this.ComponentsSplitContainer.Panel2.Controls.Add(this.controlsTableLayoutPanel);
            this.ComponentsSplitContainer.Size = new System.Drawing.Size(278, 243);
            this.ComponentsSplitContainer.SplitterDistance = 199;
            this.ComponentsSplitContainer.TabIndex = 0;
            // 
            // controlsTableLayoutPanel
            // 
            this.controlsTableLayoutPanel.ColumnCount = 3;
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.controlsTableLayoutPanel.Controls.Add(this.genRandArrButton, 1, 0);
            this.controlsTableLayoutPanel.Controls.Add(this.sortButton, 2, 0);
            this.controlsTableLayoutPanel.Controls.Add(this.inputTextBox, 0, 0);
            this.controlsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsTableLayoutPanel.Name = "controlsTableLayoutPanel";
            this.controlsTableLayoutPanel.RowCount = 1;
            this.controlsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.Size = new System.Drawing.Size(278, 40);
            this.controlsTableLayoutPanel.TabIndex = 0;
            // 
            // genRandArrButton
            // 
            this.genRandArrButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genRandArrButton.Location = new System.Drawing.Point(97, 3);
            this.genRandArrButton.Name = "genRandArrButton";
            this.genRandArrButton.Size = new System.Drawing.Size(88, 34);
            this.genRandArrButton.TabIndex = 0;
            this.genRandArrButton.Text = "Generate Random Array";
            this.genRandArrButton.UseVisualStyleBackColor = true;
            this.genRandArrButton.Click += new System.EventHandler(this.genRandArrButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortButton.Location = new System.Drawing.Point(191, 3);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(84, 34);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(3, 3);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(88, 34);
            this.inputTextBox.TabIndex = 2;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayTextBox.Location = new System.Drawing.Point(0, 0);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayTextBox.Size = new System.Drawing.Size(278, 199);
            this.DisplayTextBox.TabIndex = 0;
            // 
            // BubbleSortAppGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BubbleSortGroupBox);
            this.Name = "BubbleSortAppGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jerome Santos--Bubble Sort";
            this.Load += new System.EventHandler(this.BubbleSortAppGUI_Load);
            this.BubbleSortGroupBox.ResumeLayout(false);
            this.ComponentsSplitContainer.Panel1.ResumeLayout(false);
            this.ComponentsSplitContainer.Panel1.PerformLayout();
            this.ComponentsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentsSplitContainer)).EndInit();
            this.ComponentsSplitContainer.ResumeLayout(false);
            this.controlsTableLayoutPanel.ResumeLayout(false);
            this.controlsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BubbleSortGroupBox;
        private System.Windows.Forms.SplitContainer ComponentsSplitContainer;
        private System.Windows.Forms.TableLayoutPanel controlsTableLayoutPanel;
        private System.Windows.Forms.Button genRandArrButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox DisplayTextBox;
    }
}

