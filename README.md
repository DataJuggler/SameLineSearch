# SameLineSearch
This simple Windows Forms .Net 5 project recursively searches a given directory, for a set of search terms that all must exist in the same line for it be counted.

Here is a short video demonstrating how to use it. I find it faster than Visual Studio search:

https://youtu.be/NM2-_tE0iak

To run this program after cloning
1. Start Program
2. Browse for top level of your project
3. Entension is prepopulated in the app.config for ".cs";. Change this to your own liking.
4. Type in one or more search terms separated by a space.

This program already helped me, because I was looking for how to return a JSon message so I searched for:
return new json

Visual Studio search would have turned up 100's of results on my solution for any of the above. Commbined into one search, I found 6 examples to look at.

I find this to be a valuable search, I made adopt this into Visual Studio, as Visual Studio search is bad on a web project with libraries imported.

Nuget packages used:
DataJuggler.Win.Controls
DataJuggler.UltimateHelper

Currently I am adding new features for 'Ignore Comments' and 'Ignore Text' that will ignore a result, even if the search text matches. Searching large projects for code you only vaguely remember is what this project was designed for.
