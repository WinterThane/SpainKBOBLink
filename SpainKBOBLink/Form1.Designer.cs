namespace SpainKBOBLink
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupSelectComboBox = new System.Windows.Forms.ComboBox();
            this.spanishGrid = new System.Windows.Forms.DataGridView();
            this.joinedGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteLink = new System.Windows.Forms.Button();
            this.makeLink = new System.Windows.Forms.Button();
            this.kbobGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spanishGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbobGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spanish materials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select material group:";
            // 
            // groupSelectComboBox
            // 
            this.groupSelectComboBox.FormattingEnabled = true;
            this.groupSelectComboBox.Location = new System.Drawing.Point(165, 31);
            this.groupSelectComboBox.Name = "groupSelectComboBox";
            this.groupSelectComboBox.Size = new System.Drawing.Size(67, 21);
            this.groupSelectComboBox.TabIndex = 2;
            this.groupSelectComboBox.SelectedValueChanged += new System.EventHandler(this.groupSelectComboBox_SelectedValueChanged);
            // 
            // spanishGrid
            // 
            this.spanishGrid.AllowUserToAddRows = false;
            this.spanishGrid.AllowUserToDeleteRows = false;
            this.spanishGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spanishGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spanishGrid.Location = new System.Drawing.Point(16, 58);
            this.spanishGrid.MultiSelect = false;
            this.spanishGrid.Name = "spanishGrid";
            this.spanishGrid.ReadOnly = true;
            this.spanishGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.spanishGrid.Size = new System.Drawing.Size(642, 150);
            this.spanishGrid.TabIndex = 3;
            this.spanishGrid.SelectionChanged += new System.EventHandler(this.spanishGrid_SelectionChanged);
            // 
            // joinedGrid
            // 
            this.joinedGrid.AllowUserToAddRows = false;
            this.joinedGrid.AllowUserToDeleteRows = false;
            this.joinedGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.joinedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinedGrid.Location = new System.Drawing.Point(16, 234);
            this.joinedGrid.MultiSelect = false;
            this.joinedGrid.Name = "joinedGrid";
            this.joinedGrid.ReadOnly = true;
            this.joinedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.joinedGrid.Size = new System.Drawing.Size(1043, 173);
            this.joinedGrid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spanish materials linked with KBOB materials";
            // 
            // deleteLink
            // 
            this.deleteLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLink.Location = new System.Drawing.Point(14, 413);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Size = new System.Drawing.Size(110, 25);
            this.deleteLink.TabIndex = 6;
            this.deleteLink.Text = "Remove link";
            this.deleteLink.UseVisualStyleBackColor = true;
            this.deleteLink.Click += new System.EventHandler(this.deleteLink_Click);
            // 
            // makeLink
            // 
            this.makeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLink.Location = new System.Drawing.Point(664, 58);
            this.makeLink.Name = "makeLink";
            this.makeLink.Size = new System.Drawing.Size(75, 25);
            this.makeLink.TabIndex = 7;
            this.makeLink.Text = "Link";
            this.makeLink.UseVisualStyleBackColor = true;
            this.makeLink.Click += new System.EventHandler(this.makeLink_Click);
            // 
            // kbobGrid
            // 
            this.kbobGrid.AllowUserToAddRows = false;
            this.kbobGrid.AllowUserToDeleteRows = false;
            this.kbobGrid.AllowUserToResizeRows = false;
            this.kbobGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kbobGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kbobGrid.Location = new System.Drawing.Point(745, 58);
            this.kbobGrid.MultiSelect = false;
            this.kbobGrid.Name = "kbobGrid";
            this.kbobGrid.ReadOnly = true;
            this.kbobGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kbobGrid.Size = new System.Drawing.Size(314, 150);
            this.kbobGrid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "KBOB materials";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kbobGrid);
            this.Controls.Add(this.makeLink);
            this.Controls.Add(this.deleteLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joinedGrid);
            this.Controls.Add(this.spanishGrid);
            this.Controls.Add(this.groupSelectComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Spanish materials to KBOB materials";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.spanishGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbobGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupSelectComboBox;
        private System.Windows.Forms.DataGridView spanishGrid;
        private System.Windows.Forms.DataGridView joinedGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteLink;
        private System.Windows.Forms.Button makeLink;
        private System.Windows.Forms.DataGridView kbobGrid;
        private System.Windows.Forms.Label label4;
    }
}

