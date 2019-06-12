# SG-Challenge
Nicholas Jeffers
6/12/2019

I tried to comment my intensions as clearly as possible.

For the data set I used a .txt file where each line is formatted with a name, a birth year, and an end year.
I have created a "list.txt" file that is located in the same directory as the project files. It should automatically be able to find it. If not, please right-click on the "list.txt" file, go ot properties and make sure that the "Copy to Output Directory" is set to "Copy always".

My code reads form list.txt line by line, initializes the start and end years, and then increments the start year, end year, and each year inbetween by one. I use an array of integers to represent all the years (1901 - 1999) and to store the number of living people in each.

I then find the index in the array that represents the year with the most living people.

I did not implement any graphs or charts, but I do print each year with how many people were alive in that year to the console, along with the year with the most number of people alive.

Please contact me if you have any issues running my project.
