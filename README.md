# Analyzing-data-in-Array - professional astronomer records
The Application will read the data from a file and store it in an array of the appropriate size (or a list), and then analyze the data in the array.  Sound familiar?  It should – it is a very common thing programmers are called to do.  Of course, we will take it a step further than last week.

This time, our client is a professional astronomer.  He monitors variable stars all night long and logs their brightnesses every few minutes in a data file for a specific star.  The first value in the file is that star name and the rest of the data are the brightness values (type double).  I have supplied you with three sample data files to download and work with (OVBoo.txt, lastnight.txt, fredsobservations.txt) – here is a short sample:

OV Boo
14.98
14.92
14.98
14.95
14.95
14.82
14.91
14.90
14.95
14.99

The numbers listed are part of a brightness system known as ‘magnitude’ values.  Magnitudes work similar to winners in a contest or sport – lower numbers are bigger and more important - like the ‘1’ of ‘1st place’ is better (brighter) than the ‘4’ of ‘4th place’.  So a star with a magnitude of 14.8 is brighter than a star of magnitude 15.1 and a star a magnitude 4.56 is dimmer than a star of magnitude 3.99.  Be careful with this ‘backwards’ system when you are writing the code for the data analysis listed below – it will be easy to write your program backwards and have it showing everything incorrectly.

He has also supplied us with another file called knownvalues.txt which is a comma-separated file with a list of a bunch of stars and their normal brightnesses.  You will manually (type by hand) load this list into a two-dimensional array (star name in one dimension, brightness in the other) so that it is available every time the program runs.

The astronomer wants us to create an app that will allow the user to choose one of the nightly data files, and the program will read it into an array or list. Your app will then compare the contents of that user-chosen file to the list of star names and known brightnesses  to see what the 'normal' value should be for that star and then compare the nightly observations to analyze what the star has been doing.

The app will get the star name from the user data file and find the match in the 2D array.  It will compare all the values stored (the list or array you filled from the data file) to that reference brightness.  It will determine whether the observed value is brighter or dimmer than the known value.  Each brighter value will be displayed in a ListBox labeled ‘Brighter Values’ and each dimmer value will be displayed in another ListBox labeled ‘Dimmer Values’. The program will also compare the total number of values that are brighter or dimmer and compare that to the total number of observations in the data file – a Label on your form will indicate the total number of ‘Exact Matches’ to the known value.

When the analysis is complete, the data in the ‘Dimmer’ and ‘Brighter’ ListBoxes will be sorted by your app.  The ‘Dimmer’ ListBox will have the dimmest values sorted to the top (descending order) and the ‘Brighter’ ListBox will have the brightest values sorted to the top (ascending order).

For example, using the sample observing data shown above, we compare the star ‘OV Boo’ (yes, that is a real variable star name!) to our pre-loaded data and we see that the normal value for OV Boo is 14.95.  We would run through the observing data and see that 14.98 (twice) and 14.99 are dimmer than 14.95 and we would list those three values in the ‘Dimmer’ ListBox, then sort them with 14.99 at the top with the rest in order.  We would see that 14.82, 14.92, 14.91, and 14.90 are lower than 14.95 so we would list those four values in the ‘Brighter’ ListBox with 14.82 at the top and the rest in order.  Our ‘Exact Matches’ Label would say “3”. Of course, the actual data files provided for you are will be much larger – they may hold up to 1,000 observations per night.
