namespace AccessControlForm
{
    partial class AccessControlMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBarcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStatus = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTimeIn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTimeOut = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 172);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Log Report";
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(260, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 36);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "George FrankFort";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox2_OnValueChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarcode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBarcode.BorderThickness = 3;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarcode.isPassword = false;
            this.txtBarcode.Location = new System.Drawing.Point(70, 70);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(176, 36);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcode.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox3_OnValueChanged);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // txtStatus
            // 
            this.txtStatus.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStatus.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStatus.BorderThickness = 3;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.isPassword = false;
            this.txtStatus.Location = new System.Drawing.Point(499, 70);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(198, 36);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.Text = "Present";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 70);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 20);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Users";
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTimeIn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeIn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTimeIn.BorderThickness = 3;
            this.txtTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeIn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTimeIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeIn.isPassword = false;
            this.txtTimeIn.Location = new System.Drawing.Point(705, 70);
            this.txtTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(172, 36);
            this.txtTimeIn.TabIndex = 6;
            this.txtTimeIn.Text = "Time In";
            this.txtTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimeIn.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox5_OnValueChanged);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTimeOut.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeOut.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTimeOut.BorderThickness = 3;
            this.txtTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeOut.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeOut.isPassword = false;
            this.txtTimeOut.Location = new System.Drawing.Point(885, 70);
            this.txtTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(181, 36);
            this.txtTimeOut.TabIndex = 7;
            this.txtTimeOut.Text = "Time Out";
            this.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(108, 172);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(958, 305);
            this.bunifuCustomDataGrid1.TabIndex = 8;
            // 
            // AccessControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 549);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.txtTimeIn);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessControlMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessControlMain";
            this.Load += new System.EventHandler(this.AccessControlMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBarcode;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimeIn;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimeOut;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}