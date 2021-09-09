
namespace Temp962021
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchTextControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.SearchButton = new DataJuggler.Win.Controls.Button();
            this.SearchFolder = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SearchTextControl
            // 
            this.SearchTextControl.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextControl.BottomMargin = 0;
            this.SearchTextControl.Editable = true;
            this.SearchTextControl.Encrypted = false;
            this.SearchTextControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextControl.LabelBottomMargin = 0;
            this.SearchTextControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SearchTextControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchTextControl.LabelText = "Search Text:";
            this.SearchTextControl.LabelTopMargin = 0;
            this.SearchTextControl.LabelWidth = 140;
            this.SearchTextControl.Location = new System.Drawing.Point(80, 98);
            this.SearchTextControl.MultiLine = false;
            this.SearchTextControl.Name = "SearchTextControl";
            this.SearchTextControl.OnTextChangedListener = null;
            this.SearchTextControl.PasswordMode = false;
            this.SearchTextControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextControl.Size = new System.Drawing.Size(1135, 32);
            this.SearchTextControl.TabIndex = 0;
            this.SearchTextControl.TextBoxBottomMargin = 0;
            this.SearchTextControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SearchTextControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.SearchTextControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextControl.TextBoxTopMargin = 0;
            this.SearchTextControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.ButtonText = "Search";
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SearchButton.Location = new System.Drawing.Point(1035, 503);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(180, 64);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchFolder
            // 
            this.SearchFolder.BackColor = System.Drawing.Color.Transparent;
            this.SearchFolder.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.SearchFolder.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SearchFolder.ButtonImage")));
            this.SearchFolder.ButtonWidth = 48;
            this.SearchFolder.DarkMode = false;
            this.SearchFolder.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SearchFolder.Editable = true;
            this.SearchFolder.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SearchFolder.Filter = null;
            this.SearchFolder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchFolder.HideBrowseButton = false;
            this.SearchFolder.LabelBottomMargin = 0;
            this.SearchFolder.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SearchFolder.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchFolder.LabelText = "Source Folder:";
            this.SearchFolder.LabelTopMargin = 0;
            this.SearchFolder.LabelWidth = 140;
            this.SearchFolder.Location = new System.Drawing.Point(80, 35);
            this.SearchFolder.Name = "SearchFolder";
            this.SearchFolder.OnTextChangedListener = null;
            this.SearchFolder.OpenCallback = null;
            this.SearchFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchFolder.SelectedPath = null;
            this.SearchFolder.Size = new System.Drawing.Size(1135, 32);
            this.SearchFolder.StartPath = null;
            this.SearchFolder.TabIndex = 2;
            this.SearchFolder.TextBoxBottomMargin = 0;
            this.SearchFolder.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SearchFolder.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SearchFolder.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchFolder.TextBoxTopMargin = 0;
            this.SearchFolder.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 18;
            this.ResultsListBox.Location = new System.Drawing.Point(46, 168);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(1169, 292);
            this.ResultsListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SameLineSearch.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(1265, 597);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.SearchFolder);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Same Line Search";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl SearchTextControl;
        private DataJuggler.Win.Controls.Button SearchButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SearchFolder;
        private System.Windows.Forms.ListBox ResultsListBox;
    }
}

