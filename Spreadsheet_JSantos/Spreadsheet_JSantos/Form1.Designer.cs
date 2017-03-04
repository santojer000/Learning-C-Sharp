namespace Spreadsheet_JSantos
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
            this.infoDataGridView = new System.Windows.Forms.DataGridView();
            this.demoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDataGridView
            // 
            this.infoDataGridView.AllowUserToAddRows = false;
            this.infoDataGridView.AllowUserToDeleteRows = false;
            this.infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.infoDataGridView.Name = "infoDataGridView";
            this.infoDataGridView.Size = new System.Drawing.Size(284, 262);
            this.infoDataGridView.TabIndex = 0;
            // 
            // demoButton
            // 
            this.demoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoButton.Location = new System.Drawing.Point(0, 239);
            this.demoButton.Name = "demoButton";
            this.demoButton.Size = new System.Drawing.Size(284, 23);
            this.demoButton.TabIndex = 1;
            this.demoButton.Text = "Demo Button";
            this.demoButton.UseVisualStyleBackColor = true;
            this.demoButton.Click += new System.EventHandler(this.demoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.demoButton);
            this.Controls.Add(this.infoDataGridView);
            this.Name = "Form1";
            this.Text = "Spreadsheet Cpt_S 321";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDataGridView;
        private System.Windows.Forms.Button demoButton;
    }
}

