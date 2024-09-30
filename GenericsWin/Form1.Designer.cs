namespace GenericsWin
{
    partial class Form1
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
            listBoxMenu = new ListBox();
            panelAddAcc = new Panel();
            btnAddAcc = new Button();
            comboBoxAcctype = new ComboBox();
            txtAccNo = new TextBox();
            txtboxinitamt = new TextBox();
            txtCName = new TextBox();
            lblDisplayData = new Label();
            panelsrcdata = new Panel();
            buttonSearch = new Button();
            txtAccSrc = new TextBox();
            paneldelete = new Panel();
            buttondelete = new Button();
            txtboxdelete = new TextBox();
            lblDisplay = new Label();
            panelAddAcc.SuspendLayout();
            panelsrcdata.SuspendLayout();
            paneldelete.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.ItemHeight = 15;
            listBoxMenu.Items.AddRange(new object[] { "Menu", "1. Add Account", "2. Display Account Details", "3.Display Deatils for a specific Account", "4. Calculate Intrest for all Account", "5. Delete Account" });
            listBoxMenu.Location = new Point(12, 12);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(222, 94);
            listBoxMenu.TabIndex = 0;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // panelAddAcc
            // 
            panelAddAcc.Controls.Add(btnAddAcc);
            panelAddAcc.Controls.Add(comboBoxAcctype);
            panelAddAcc.Controls.Add(txtAccNo);
            panelAddAcc.Controls.Add(txtboxinitamt);
            panelAddAcc.Controls.Add(txtCName);
            panelAddAcc.Location = new Point(11, 128);
            panelAddAcc.Name = "panelAddAcc";
            panelAddAcc.Size = new Size(281, 142);
            panelAddAcc.TabIndex = 1;
            // 
            // btnAddAcc
            // 
            btnAddAcc.Location = new Point(86, 104);
            btnAddAcc.Name = "btnAddAcc";
            btnAddAcc.Size = new Size(87, 23);
            btnAddAcc.TabIndex = 4;
            btnAddAcc.Text = "Add Account";
            btnAddAcc.UseVisualStyleBackColor = true;
            btnAddAcc.Click += btnAddAcc_Click;
            // 
            // comboBoxAcctype
            // 
            comboBoxAcctype.FormattingEnabled = true;
            comboBoxAcctype.Items.AddRange(new object[] { "Savings", "Current" });
            comboBoxAcctype.Location = new Point(161, 55);
            comboBoxAcctype.Name = "comboBoxAcctype";
            comboBoxAcctype.Size = new Size(101, 23);
            comboBoxAcctype.TabIndex = 3;
            // 
            // txtAccNo
            // 
            txtAccNo.Location = new Point(161, 12);
            txtAccNo.Name = "txtAccNo";
            txtAccNo.PlaceholderText = "Acc No";
            txtAccNo.Size = new Size(101, 23);
            txtAccNo.TabIndex = 2;
            // 
            // txtboxinitamt
            // 
            txtboxinitamt.Location = new Point(14, 55);
            txtboxinitamt.Name = "txtboxinitamt";
            txtboxinitamt.PlaceholderText = "Initial Balance";
            txtboxinitamt.Size = new Size(91, 23);
            txtboxinitamt.TabIndex = 1;
            // 
            // txtCName
            // 
            txtCName.Location = new Point(13, 12);
            txtCName.Name = "txtCName";
            txtCName.PlaceholderText = "Name";
            txtCName.Size = new Size(92, 23);
            txtCName.TabIndex = 0;
            // 
            // lblDisplayData
            // 
            lblDisplayData.AutoSize = true;
            lblDisplayData.Location = new Point(392, 12);
            lblDisplayData.Name = "lblDisplayData";
            lblDisplayData.Size = new Size(69, 15);
            lblDisplayData.TabIndex = 2;
            lblDisplayData.Text = "DisplayData";
            // 
            // panelsrcdata
            // 
            panelsrcdata.Controls.Add(buttonSearch);
            panelsrcdata.Controls.Add(txtAccSrc);
            panelsrcdata.Location = new Point(12, 287);
            panelsrcdata.Name = "panelsrcdata";
            panelsrcdata.Size = new Size(280, 57);
            panelsrcdata.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(174, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(84, 29);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // txtAccSrc
            // 
            txtAccSrc.Location = new Point(9, 16);
            txtAccSrc.Name = "txtAccSrc";
            txtAccSrc.PlaceholderText = "Acc No";
            txtAccSrc.Size = new Size(108, 23);
            txtAccSrc.TabIndex = 3;
            // 
            // paneldelete
            // 
            paneldelete.Controls.Add(buttondelete);
            paneldelete.Controls.Add(txtboxdelete);
            paneldelete.Location = new Point(12, 367);
            paneldelete.Name = "paneldelete";
            paneldelete.Size = new Size(280, 57);
            paneldelete.TabIndex = 4;
            // 
            // buttondelete
            // 
            buttondelete.Location = new Point(174, 12);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(84, 29);
            buttondelete.TabIndex = 4;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = true;
            // 
            // txtboxdelete
            // 
            txtboxdelete.Location = new Point(9, 16);
            txtboxdelete.Name = "txtboxdelete";
            txtboxdelete.PlaceholderText = "Acc No";
            txtboxdelete.Size = new Size(108, 23);
            txtboxdelete.TabIndex = 3;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(317, 409);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 15);
            lblDisplay.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 508);
            Controls.Add(lblDisplay);
            Controls.Add(paneldelete);
            Controls.Add(panelsrcdata);
            Controls.Add(lblDisplayData);
            Controls.Add(panelAddAcc);
            Controls.Add(listBoxMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelAddAcc.ResumeLayout(false);
            panelAddAcc.PerformLayout();
            panelsrcdata.ResumeLayout(false);
            panelsrcdata.PerformLayout();
            paneldelete.ResumeLayout(false);
            paneldelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMenu;
        private Panel panelAddAcc;
        private TextBox txtCName;
        private ComboBox comboBoxAcctype;
        private TextBox txtAccNo;
        private TextBox txtboxinitamt;
        private Button btnAddAcc;
        private Label lblDisplayData;
        private Panel panelsrcdata;
        private Button buttonSearch;
        private TextBox txtAccSrc;
        private Panel paneldelete;
        private Button buttondelete;
        private TextBox txtboxdelete;
        private Label lblDisplay;
    }
}
