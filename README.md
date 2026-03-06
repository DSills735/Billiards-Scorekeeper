
# 14.1 Striaght Pool and Snooker Scorekeeper
This is a scorekeeper for 2 players to play snooker or straight pool. This is a console app inded to be used for 2 player billiards scoring. I created this as me and my friends needed a better way to score our billiards games.
This scorekeeper will keep a history of each unique players wins using SQLite. It will also keep track of wins per session and display those after each game. It does not differentiate between snooker and straight pool wins. 

**Tech used:** C#, SpectreConsole, SqlLite
'
Keeping it simple here. This started as a single file app using only c# to what it is currently. This app will be updated as long as me and my friends still use it. 

## Optimizations

I have done a ton of refactoring with this. Initially, this was one program.cs file that went through a game of straight pool until it ended, and it would ask to play again. Now it has a database to save wins, and also a snooker section (I dont actually use that side of things, just built it for fun one day.)


## Lessons Learned

The hardest part of this when I was developing it was trying the best I could to reduce boilerplate code. I think I did a decent job of it, but there is definitely some room for improvement. I also could improve the menus and after game messages to be streamlined. Lastly, I also could improve database operation, as right now if 2 poeple of the same name are playing, it will save under the same name. For my use case I dont need this, but I still think it should be changed in the future. 

I do have one singular unit test. It was the first unit test ive ever written, and done entirely for practice purposes. 

## Optional Future plans / Further Info 

--- You do not need to understand the rules to understand the functionality of this, but these might help if using the program --- 
An example of the rules for straight pool can be found here: https://www.cuesight.com/wpa/14-1-straight-pool-rules/
Snooker rules can be found here: https://wpbsa.com/wp-content/uploads/Rulebook-Website-Updated-May-2022-2.pdf
