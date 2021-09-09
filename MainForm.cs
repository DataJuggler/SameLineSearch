

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

#endregion

namespace Temp962021
{

    #region class MainForm
    /// <summary>
    /// method [Enter Method Description]
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

            #region SearchButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SearchButton' is clicked.
            /// </summary>
            private void SearchButton_Click(object sender, EventArgs e)
            {
                string extension = ".cs";
                List<string> extensions = new List<string>();
                extensions.Add(extension);
                List<string> files = new List<string>();
                int lineNumber = 0;

                // Get the files recursively
                files = FileHelper.GetFilesRecursively(this.SearchFolder.Text, ref files, extensions);

                string searchText = SearchTextControl.Text;
                char[] delimiter = new char[] { ' ' };
                List<Word> searchWords = TextHelper.GetWords(searchText, delimiter);
                
                // if the files exist
                if ((ListHelper.HasOneOrMoreItems(files)) && (ListHelper.HasOneOrMoreItems(searchWords)))
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

                                    // Iterate the collection of TextLine objects
                                    foreach (TextLine line in textLines)
                                    {
                                        // Increment the value for lineNumber
                                        lineNumber++;

                                        // reset
                                        tempWordsMatched = 0;

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

                                            // Add this item
                                            ResultsListBox.Items.Add(temp);

                                            // break out of this loop
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // Show a message done
                MessageBox.Show("Done");
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

        #endregion

    }
    #endregion

}
