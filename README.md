<h1 align="center">Hi 👋, I'm Tyler Wiggins</h1>
<h3 align="center">I have a passion for full stack development and I am always thriving to learn more programming languages and frameworks.</h3>
<br>

<h3 align="left">How to Install my Minesweeper Game:</h3>
<p>Go to https://visualstudio.microsoft.com/ and install the community edition of Visual Studio.
  
  ![image](https://user-images.githubusercontent.com/46502423/166826135-779c4b61-48c5-4622-a8c9-14cbc619417c.png)


<p>Once you install the Visual Studio installer, the community edition of visual studios will start installing.
  
  ![image](https://user-images.githubusercontent.com/46502423/166827278-68a7ff57-745a-475e-ac88-26ceb633f328.png)

  <p>Once Visual Studios is installed, launch it to ensure that it was installed correctly.</p>
 
  ![image](https://user-images.githubusercontent.com/46502423/166835544-d2249a60-7940-4ef5-b752-fc37410f0669.png)

<p>Next step is to clone the Minesweeper game from GitHub. Click the green "Code🔻" button and choose the "Open with Visual Studios" option.
  
![image](https://user-images.githubusercontent.com/46502423/166841855-1de2a068-da6c-4dcb-83c2-d8216970db72.png)
























<h3 align="left">Project Description:</h3>
<p>I wanted to challeng myself and learn a new programming language that I've never used before, so I developed a fully functional Minesweeper game in C#.Net Core. </p>
<p>In this minesweeper game, you start by choosing the difficulty </p>
<p>Then click the Play Button.</p>
<p>Then a game board will pop up with a grid that is sized based off the difficulty you chose.</p>
<p>Next you will click a square and it will reveal a open space or a mine.<p>
<p>If you know the square is a mine, right click to flag it.</p>
<p>Check out the "How to Play Minsweeper" section to learn the game rules.</p>




<h3 align="left">How to Play Minesweeper:</h3>
Minesweeper is a game about learning patterns and using process of elimination.

Your first square is completely random, as there is no info to go on, though I suggest picking one near the middle. The edges give you less info to work with.
Most games will auto-mine if a blank square is revealed, but the principle is this: if you find a square with no numbers, all eight adjacent squares are safe so mine. Do so until you have a whole outer wall of numbered squares. If you get a numbered square on your first try, start over.
Ideally you'd have a sprawling concave shape to work with. If you have a 9x9 square start again from the beginning. This is where your pattern recognition will have to kick in. Look at this example:

The first thing to recognize is that if there is an inside corner, there is a mine. Second, a 1,2,1 pattern always has the mines on the 1’s. Put flags down where you think the mines are.
Now for the logic game. Those numbers mean something. They tell you how many mines are in the eight adjacent squares to it.

That's a lot of new info to look through. I can see another 1,2,1 pattern and a few new patterns I haven't mentioned yet, though I'm sure you'll see them quickly.

I'm not going to tell you all the patterns I've learned because that's part of the fun. But I suggest you start with the biggest board size you can to learn the patterns and just accept you're gonna lose your first several games.
A word of warning: there are certain times where there simply isn't enough information to figure out which of two squares a mine could be in(usually on the edge of the map). I suggest you follow a simple process.

Save it for the very end. This will give you time to finish the rest of the map and make the next step a viable solution.
Consider the number of mines left in the game. Often, there is one solution to this issue when there is one mine left, and another when there is two, or none.
Guess. Sometimes there's nothing you can do but guess. Alas, a 50/50 shot is all you're gonna get.
