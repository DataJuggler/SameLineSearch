

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.IO;
using System.Diagnostics;

#endregion

namespace SameLineSearch
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private string lastSearchResults;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region CopiedTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Copied Timer _ Tick
            /// </summary>
            private void CopiedTimer_Tick(object sender, EventArgs e)
            {
                 // only run once
                CopiedTimer.Enabled = false; 
                
                // Hide the Copied image
                CopiedImage.Visible = false;
            }
            #endregion
            
            #region CopyButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CopyButton' is clicked.
            /// </summary>
            private void CopyButton_Click(object sender, EventArgs e)
            { 
                // remove focus from this button
                OffScreenButton.Focus();

                // if the value for HasLastSearchResults is true
                if (HasLastSearchResults)
                {
                    // copy
                    Clipboard.SetText(LastSearchResults);

                    // Show the DoneImage
                    CopiedImage.Visible = true;

                    // Start the DoneTimer
                    CopiedTimer.Start();
                }
            }
            #endregion
            
            #region DoneTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Done Timer _ Tick
            /// </summary>
            private void DoneTimer_Tick(object sender, EventArgs e)
            {
                // only run once
                DoneTimer.Enabled = false; 
                
                // Hide the Done image
                DoneImage.Visible = false;
            }
            #endregion
            
            #region MainForm_FormClosed(object sender, FormClosedEventArgs e)
            /// <summary>
            /// event is fired when Main Form _ Form Closed
            /// </summary>
            private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                // Close this app
                Application.Exit();
            }
            #endregion
            
            #region ResultsListBox_DoubleClick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Results List Box _ Double Click
            /// </summary>
            private void ResultsListBox_DoubleClick(object sender, EventArgs e)
            {
                StatusLabel.Text = "";

                try
                {
                    if (NullHelper.Exists(ResultsListBox.SelectedItem))
                    {
                        // Get the string
                        string temp = ResultsListBox.SelectedItem.ToString();

                        // If the temp string exists
                        if (TextHelper.Exists(temp))
                        {
                            // Get the last index of the dash
                            int dashIndex = temp.LastIndexOf(" - ");

                            // if the dashIndex was found
                            if (dashIndex >= 0)
                            {
                                // get the fileName
                                string fileName = temp.Substring(0, dashIndex).Trim();

                                // Now shell execute the file
                                FileInfo fileInfo = new FileInfo(fileName);

                                var p = new Process();
                                        
                                p.StartInfo = new ProcessStartInfo();
                                { 
                                    // Set the working directory                                
                                    p.StartInfo.WorkingDirectory = fileInfo.Directory.FullName;
                                    p.StartInfo.UseShellExecute = true;
                                    p.StartInfo.FileName = fileInfo.FullName;
                                };

                                // launch the file
                                p.Start();

                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    StatusLabel.Text = "An error occurred trying to launch the selected file.";

                    // For debugging only
                    DebugHelper.WriteDebugError("ResultsListBox_DoubleClick", "MainForm.cs", error);
                }
            }
            #endregion
            
            #region SearchButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SearchButton' is clicked.
            /// </summary>
            private void SearchButton_Click(object sender, EventArgs e)
            {
                // Erase
                LastSearchResults = "";

                // Show Searching
                ItemsFoundLabel.Text = "Searching...";
                ItemsFoundLabel.Visible = true;
                ItemsFoundLabel.Refresh();
                Refresh();
                Application.DoEvents();

                // local
                bool skipLine = false;

                // Clear any items
                ResultsListBox.Items.Clear();

                // Set Focus to the offscreen button
                OffScreenButton.Focus();

                // create the delimiter to parse the extensions
                char[] delimiter = new char[] { ',' };

                List<string> extensions = TextHelper.GetWordsAsStrings(ExtensionsControl.Text, delimiter);
                
                List<string> files = new List<string>();
                int lineNumber = 0;

                // Get the files recursively
                files = FileHelper.GetFilesRecursively(this.SearchFolder.Text, ref files, extensions);

                // get the searchText
                string searchText = SearchTextControl.Text;
                delimiter = new char[] { ' ' };
                List<Word> searchWords = TextHelper.GetWords(searchText, delimiter);

                // get the excludeText
                string excludeText = ExcludeControl.Text;
                List<Word> excludeWords = TextHelper.GetWords(excludeText, delimiter);

                // Create a new instance of a 'StringBuilder' object.
                StringBuilder sb = new StringBuilder();
                
                // if the files exist
                if (ListHelper.HasOneOrMoreItems(files, searchWords))
                {
                    // Get the number of matches needed
                    int wordsToMatch = searchWords.Count;

                    // local
                    int tempWordsMatched = 0;

                    // Iterate the collection of string objects
                    foreach (string file in files)
                    {
                        // reset the value
                        tempWordsMatched = 0;

                        // Get the fileContent
                        string fileContent = File.ReadAllText(file);

                        // If the fileContent string exists
                        if (TextHelper.Exists(fileContent))
                        {
                            // Iterate the collection of Word objects
                            foreach (Word word in searchWords)
                            {
                                // if this file contains this word
                                if (fileContent.ToLower().Contains(word.Text.ToLower()))
                                {
                                    // Increment the value for tempWordsMatched
                                    tempWordsMatched++;
                                }
                            }

                            // if all the words match
                            if (tempWordsMatched == wordsToMatch)
                            {
                                // this merits a check of getting all the text lines
                                List<TextLine> textLines = TextHelper.GetTextLines(fileContent);

                                // If the textLines collection exists and has one or more items
                                if (ListHelper.HasOneOrMoreItems(textLines))
                                {
                                    // reset
                                    lineNumber = 0;
                                    skipLine = false;

                                    // Iterate the collection of TextLine objects
                                    foreach (TextLine line in textLines)
                                    {
                                        // reset
                                        skipLine = false;

                                        // Increment the value for lineNumber
                                        lineNumber++;

                                        // if Ignore Comments is true and this line is a comment
                                        if ((IgnoreCommentsCheckBox.Checked) && (line.Text.Trim().StartsWith("//")))
                                        {
                                            // set tot rue
                                            skipLine = true;
                                        }

                                        // reset
                                        tempWordsMatched = 0;

                                        // if this not a comment or skip comments is false
                                        if (!skipLine)
                                        {
                                            // Iterate the collection of Word objects
                                            foreach (Word word in searchWords)
                                            {
                                                // if this file contains this word
                                                if (line.Text.ToLower().Contains(word.Text.ToLower()))
                                                {
                                                    // Increment the value for tempWordsMatched
                                                    tempWordsMatched++;
                                                }
                                            }

                                             // if all the words match
                                            if (tempWordsMatched == wordsToMatch)
                                            {
                                                // build a line to show
                                                string temp = file + " - line: " + lineNumber + ".";

                                                // Used to create the SearchResultsText
                                                sb.Append(temp);
                                                sb.Append(Environment.NewLine);

                                                // Add this item
                                                ResultsListBox.Items.Add(temp);

                                                // break out of this loop
                                                break;
                                            }
                                        }
                                    }

                                    // Store the results in case copied
                                    LastSearchResults = sb.ToString();
                                }
                            }
                        }
                    }
                }

                // show the results
                ItemsFoundLabel.Text = "Items Found: " + ResultsListBox.Items.Count;
                ItemsFoundLabel.Visible = true;

                // Show a message done
                DoneImage.Visible = true;

                // Start the timer
                DoneTimer.Start();
            }
            #endregion
            
        #endregion

        #region Methods

            #region DoesFileNameContainPartialGuid(string fileName)
            /// <summary>
            /// method Does File Name Contain Partial Guid
            /// </summary>
            private bool DoesFileNameContainPartialGuid(string fileName)
            {
                // initial value
                bool containsPartialGuid = false;
                
                // if the fileName exists
                if (TextHelper.Exists(fileName))
                {
                    // make sure pdf is not part of this
                    fileName = fileName.Replace(".pdf", "");
                    
                    // get a reverse string
                    string temp = fileName.Reverse().ToString();
                    
                    if (temp.Length > 12)
                    {
                        if ((temp[3] == '-') && (temp[13] == '.'))
                        {
                            // set the return value
                            containsPartialGuid = true;
                        }
                    }
                }
                
                // return value
                return containsPartialGuid;
            }
        #endregion

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Set the default extensions                
                SearchFolder.Text = ConfigurationHelper.ReadAppSetting("DefaultSearchFolder");
                ExtensionsControl.Text = ConfigurationHelper.ReadAppSetting("DefaultExtensions");
                IgnoreCommentsCheckBox.Checked = BooleanHelper.ParseBoolean(ConfigurationHelper.ReadAppSetting("IgnoreComments"), true, true);
            }
        #endregion

        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
        #endregion

            #region HasLastSearchResults
            /// <summary>
            /// This property returns true if the 'LastSearchResults' exists.
            /// </summary>
            public bool HasLastSearchResults
            {
                get
                {
                    // initial value
                    bool hasLastSearchResults = (!String.IsNullOrEmpty(this.LastSearchResults));
                    
                    // return value
                    return hasLastSearchResults;
                }
            }
            #endregion
            
            #region LastSearchResults
            /// <summary>
            /// This property gets or sets the value for 'LastSearchResults'.
            /// </summary>
            public string LastSearchResults
            {
                get { return lastSearchResults; }
                set { lastSearchResults = value; }
            }
        #endregion

        #endregion
    }
    #endregion

}
