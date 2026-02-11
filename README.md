This is a scorekeeper for 2 players to play snooker or straight pool. This is a console app inded to be used for 2 player billiards scoring. I created this as me and my friends needed a better way to score our billiards games.
This scorekeeper will keep a history of each unique players wins using SQLite. It will also keep track of wins per session and display those after each game. It does not differentiate between snooker and straight pool wins. 
In the future I will continually add to this here and there, as I use this as a practice repository for when I learn new skills that can be relevant for this project. One thing I will add is validation for names, as currently if two people
with the same name play, they will count under the same win column. 

During this project I improved my skills with:
C#
SQLite
OOP - A special focus was taken on making sure there was proper separation of concerns within this project. It is something I have not done great with in the past, so I am working on improving that. 
I think it could be better, specifically in the StraightPool.cs file.  

Feb 2026 update: Added a singular unit test for win condition of straight pool with several test cases. I also added Spectre Console to dispaly a visual scoreboard in straight pool. I left snooker untouched. 







--- You do not need to understand the rules to understand the functionality of this, but these might help if using the program --- 
An example of the rules for straight pool can be found here: https://www.cuesight.com/wpa/14-1-straight-pool-rules/
Snooker rules can be found here: https://wpbsa.com/wp-content/uploads/Rulebook-Website-Updated-May-2022-2.pdf
