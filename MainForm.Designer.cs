
namespace SameLineSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchTextControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.SearchButton = new DataJuggler.Win.Controls.Button();
            this.SearchFolder = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.ExtensionsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.InstructionsLabel3 = new System.Windows.Forms.Label();
            this.OffScreenButton = new DataJuggler.Win.Controls.Button();
            this.DoneImage = new System.Windows.Forms.PictureBox();
            this.DoneTimer = new System.Windows.Forms.Timer(this.components);
            this.CopyButton = new DataJuggler.Win.Controls.Button();
            this.CopiedImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CopiedTimer = new System.Windows.Forms.Timer(this.components);
            this.InstructionsLabel2 = new System.Windows.Forms.Label();
            this.ExcludeControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.IgnoreCommentsCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DoneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopiedImage)).BeginInit();
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
            this.SearchTextControl.LabelTopMargin = 4;
            this.SearchTextControl.LabelWidth = 140;
            this.SearchTextControl.Location = new System.Drawing.Point(80, 92);
            this.SearchTextControl.MultiLine = false;
            this.SearchTextControl.Name = "SearchTextControl";
            this.SearchTextControl.OnTextChangedListener = null;
            this.SearchTextControl.PasswordMode = false;
            this.SearchTextControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextControl.Size = new System.Drawing.Size(1135, 32);
            this.SearchTextControl.TabIndex = 1;
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
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SearchButton.Location = new System.Drawing.Point(1071, 665);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(144, 48);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.SearchButton.MouseLeave += new System.EventHandler(this.Button_Leave);
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
            this.SearchFolder.LabelTopMargin = 4;
            this.SearchFolder.LabelWidth = 140;
            this.SearchFolder.Location = new System.Drawing.Point(80, 32);
            this.SearchFolder.Name = "SearchFolder";
            this.SearchFolder.OnTextChangedListener = null;
            this.SearchFolder.OpenCallback = null;
            this.SearchFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchFolder.SelectedPath = null;
            this.SearchFolder.Size = new System.Drawing.Size(1135, 32);
            this.SearchFolder.StartPath = null;
            this.SearchFolder.TabIndex = 0;
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
            this.ResultsListBox.Location = new System.Drawing.Point(46, 322);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ResultsListBox.Size = new System.Drawing.Size(1169, 310);
            this.ResultsListBox.TabIndex = 3;
            this.ResultsListBox.DoubleClick += new System.EventHandler(this.ResultsListBox_DoubleClick);
            // 
            // ExtensionsControl
            // 
            this.ExtensionsControl.BackColor = System.Drawing.Color.Transparent;
            this.ExtensionsControl.BottomMargin = 0;
            this.ExtensionsControl.Editable = true;
            this.ExtensionsControl.Encrypted = false;
            this.ExtensionsControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsControl.LabelBottomMargin = 0;
            this.ExtensionsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ExtensionsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsControl.LabelText = "Extensions:";
            this.ExtensionsControl.LabelTopMargin = 4;
            this.ExtensionsControl.LabelWidth = 140;
            this.ExtensionsControl.Location = new System.Drawing.Point(80, 234);
            this.ExtensionsControl.MultiLine = false;
            this.ExtensionsControl.Name = "ExtensionsControl";
            this.ExtensionsControl.OnTextChangedListener = null;
            this.ExtensionsControl.PasswordMode = false;
            this.ExtensionsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExtensionsControl.Size = new System.Drawing.Size(640, 32);
            this.ExtensionsControl.TabIndex = 3;
            this.ExtensionsControl.TextBoxBottomMargin = 0;
            this.ExtensionsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ExtensionsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ExtensionsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsControl.TextBoxTopMargin = 0;
            this.ExtensionsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InstructionsLabel.Location = new System.Drawing.Point(217, 126);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(884, 20);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Enter search terms separated by a space. All search terms must appear in same lin" +
    "e.";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstructionsLabel3
            // 
            this.InstructionsLabel3.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InstructionsLabel3.Location = new System.Drawing.Point(217, 268);
            this.InstructionsLabel3.Name = "InstructionsLabel3";
            this.InstructionsLabel3.Size = new System.Drawing.Size(667, 20);
            this.InstructionsLabel3.TabIndex = 6;
            this.InstructionsLabel3.Text = "Enter extensions to search separated by a comma. Example: .cs,.cshtml,.js";
            this.InstructionsLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OffScreenButton
            // 
            this.OffScreenButton.BackColor = System.Drawing.Color.Transparent;
            this.OffScreenButton.ButtonText = "Off Screen";
            this.OffScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffScreenButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OffScreenButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.OffScreenButton.Location = new System.Drawing.Point(-766, 583);
            this.OffScreenButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OffScreenButton.Name = "OffScreenButton";
            this.OffScreenButton.Size = new System.Drawing.Size(180, 64);
            this.OffScreenButton.TabIndex = 7;
            this.OffScreenButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DoneImage
            // 
            this.DoneImage.BackgroundImage = global::SameLineSearch.Properties.Resources.Done;
            this.DoneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneImage.Location = new System.Drawing.Point(46, 644);
            this.DoneImage.Name = "DoneImage";
            this.DoneImage.Size = new System.Drawing.Size(128, 64);
            this.DoneImage.TabIndex = 8;
            this.DoneImage.TabStop = false;
            this.DoneImage.Visible = false;
            // 
            // DoneTimer
            // 
            this.DoneTimer.Interval = 3000;
            this.DoneTimer.Tick += new System.EventHandler(this.DoneTimer_Tick);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.ButtonText = "Copy";
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopyButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CopyButton.Location = new System.Drawing.Point(916, 665);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(144, 48);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CopiedImage
            // 
            this.CopiedImage.BackgroundImage = global::SameLineSearch.Properties.Resources.CopiedImage;
            this.CopiedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CopiedImage.Location = new System.Drawing.Point(46, 644);
            this.CopiedImage.Name = "CopiedImage";
            this.CopiedImage.Size = new System.Drawing.Size(128, 64);
            this.CopiedImage.TabIndex = 10;
            this.CopiedImage.TabStop = false;
            this.CopiedImage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // CopiedTimer
            // 
            this.CopiedTimer.Interval = 3000;
            this.CopiedTimer.Tick += new System.EventHandler(this.CopiedTimer_Tick);
            // 
            // InstructionsLabel2
            // 
            this.InstructionsLabel2.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InstructionsLabel2.Location = new System.Drawing.Point(217, 196);
            this.InstructionsLabel2.Name = "InstructionsLabel2";
            this.InstructionsLabel2.Size = new System.Drawing.Size(524, 20);
            this.InstructionsLabel2.TabIndex = 12;
            this.InstructionsLabel2.Text = "Ignore lines with this text, even if the search text matches.";
            this.InstructionsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExcludeControl
            // 
            this.ExcludeControl.BackColor = System.Drawing.Color.Transparent;
            this.ExcludeControl.BottomMargin = 0;
            this.ExcludeControl.Editable = true;
            this.ExcludeControl.Encrypted = false;
            this.ExcludeControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcludeControl.LabelBottomMargin = 0;
            this.ExcludeControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ExcludeControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExcludeControl.LabelText = "Exclude Text:";
            this.ExcludeControl.LabelTopMargin = 4;
            this.ExcludeControl.LabelWidth = 140;
            this.ExcludeControl.Location = new System.Drawing.Point(80, 162);
            this.ExcludeControl.MultiLine = false;
            this.ExcludeControl.Name = "ExcludeControl";
            this.ExcludeControl.OnTextChangedListener = null;
            this.ExcludeControl.PasswordMode = false;
            this.ExcludeControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExcludeControl.Size = new System.Drawing.Size(1135, 32);
            this.ExcludeControl.TabIndex = 2;
            this.ExcludeControl.TextBoxBottomMargin = 0;
            this.ExcludeControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ExcludeControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ExcludeControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcludeControl.TextBoxTopMargin = 0;
            this.ExcludeControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // IgnoreCommentsCheckBox
            // 
            this.IgnoreCommentsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.IgnoreCommentsCheckBox.CheckBoxHorizontalOffSet = 0;
            this.IgnoreCommentsCheckBox.CheckBoxVerticalOffSet = 2;
            this.IgnoreCommentsCheckBox.CheckChangedListener = null;
            this.IgnoreCommentsCheckBox.Checked = false;
            this.IgnoreCommentsCheckBox.Editable = false;
            this.IgnoreCommentsCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IgnoreCommentsCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.IgnoreCommentsCheckBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IgnoreCommentsCheckBox.LabelText = "Ignore Comments:";
            this.IgnoreCommentsCheckBox.LabelWidth = 180;
            this.IgnoreCommentsCheckBox.Location = new System.Drawing.Point(848, 234);
            this.IgnoreCommentsCheckBox.Name = "IgnoreCommentsCheckBox";
            this.IgnoreCommentsCheckBox.Size = new System.Drawing.Size(280, 28);
            this.IgnoreCommentsCheckBox.TabIndex = 13;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(217, 655);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(653, 43);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SameLineSearch.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(1265, 743);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.IgnoreCommentsCheckBox);
            this.Controls.Add(this.InstructionsLabel2);
            this.Controls.Add(this.ExcludeControl);
            this.Controls.Add(this.CopiedImage);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.DoneImage);
            this.Controls.Add(this.OffScreenButton);
            this.Controls.Add(this.InstructionsLabel3);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.ExtensionsControl);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.SearchFolder);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Same Line Search";
            ((System.ComponentModel.ISupportInitialize)(this.DoneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopiedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl SearchTextControl;
        private DataJuggler.Win.Controls.Button SearchButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SearchFolder;
        private System.Windows.Forms.ListBox ResultsListBox;
        private DataJuggler.Win.Controls.LabelTextBoxControl ExtensionsControl;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label InstructionsLabel3;
        private DataJuggler.Win.Controls.Button OffScreenButton;
        private System.Windows.Forms.PictureBox DoneImage;
        private System.Windows.Forms.Timer DoneTimer;
        private DataJuggler.Win.Controls.Button CopyButton;
        private System.Windows.Forms.PictureBox CopiedImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer CopiedTimer;
        private System.Windows.Forms.Label InstructionsLabel2;
        private DataJuggler.Win.Controls.LabelTextBoxControl ExcludeControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl IgnoreCommentsCheckBox;
        private System.Windows.Forms.Label StatusLabel;
    }
}

