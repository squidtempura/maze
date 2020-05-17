# Normal Adventuare Team

Team member information

Name: Zijing Mu              ID:  D17129502
Name: Yuanpei Teng       ID:  D18124423
Name: Jiyuan Liu             ID:  D17129141 
Name: Xinyang Shao       ID:  D18125179
Name: Hanyue Shi           ID: D16129141


	In this project, we made a maze game. This maze game is based on the 2D platform in Unity. We have a big map which is the main map
	and we need to collect gold coins from this main map to enter other three levels of our maze in this map.

Contribution for each team member:

Zijing Mu:

	1. I was responsible for the main map part which is used to linked to other levels of maze. 
	   Then created prefab folder and put all related objects into the prefab folder. 
	   Then I added collisions and rigid body to character and tile map, create a camera sprite to follow the character.
		PlayerMovement.cs
			It is used to make the character move and jump. In the process, I did some status detections using RaycastHit2D: check character is on the ground, is in the air and is reach the top. 
			Then check the direction of character’s movement. When character moves to the left, the face will face to the left.
		Then I played the demo and redesigned some of the map to make character pass smoothly and increased difficulty in some simple levels. 
		AudioManager.cs 
			Manage the sound of the game.
		GameManager.cs
			Manage the status of door and coin. The coin will be generated on the map when game starts. When character collects a coin, the coin will disappear and the number of collected coin will increase by 1. 
			And the number will update to the UI. The number of the coins will decrease by 1, when the number is 0, the door will appear. 

		Playercollect.cs 
			When the collision of character touches the collision of the coin, it will transfer GameManager and AudioManager to make a sound and the coin will disappear.
		Door.cs
			Set the door disappear at the start of the game. When character collects all the coins on the current floor, it will transfer GameManager to make the door appear. 
		Playerwin.cs
			When player cancels the game, the game will return to the first scene.
			When character collects all the coins on the first floor, the door will appear and when character touches the door, the game will load next scene.

			Playerwin1.cs  Playerwin2.cs  Playerwin3.cs
				3 different scenes of the 3 floors which are used to connect with maze maps of 3 team members. 
				The position of the character in each scene is in front of the current floor which means the character finishes the maze game of the last floor and enter to the next floor through the door. 
		UIManager.cs
			A simple UI to record the number of coins that player collects. 

	2. Test the final version of our maze and linked all the levels of our maze to the main map.

	3. Write some parts of our design document.

	4. Responsible to commit all changes to the github：
		Our team member changed their own part(ie. fixed the bugs, add the fearutes for their own part) on their local computer and my job is to update the change to the github repo to make sure our git repo is up to date.

Jiyuan Liu: 

	1. My main job in this group assignment is to create and implement the second scene, 
	    which is also the first level in the maze game. After collecting 5 coins in the main map, the knight will find a door and come into the first level.  It is a dungeon covered in ice.  
	    In this level, there are two kinds of doors with different colors, as well as two keys match the colors of the doors.  The character can exit using a ladder.
	    I created prefabs including "Player", "Wall", "Floor", "Door" and "Key".  The sprites of the prefabs are implemented with matched images.  Box collider is added to all prefabs except "Floor".  
	    It makes the prefabs be treated as object physically.  So that other objects cannot move through them.  These prefabs can be called when creating objects.

	    I also created four game objects for my first level maze - "Main Camera", "GameManager", "Player", and "CM vcam1".
		"Main Camera" initializes attributes of the camera.  It decides which part of the map can be seen by players.
		"GameManager" is used to implement the map.  There are two scripts in "GameManager", which are "GameManager.cs" and "MapManager.cs".  
			In "GameManager.cs", there are two methods in the class called "Awake()" and "Update()".  They initialize the data and update the changes once per frame.  
			Code in "MapManager.cs" decides the size of the map and the locations of all objects in the map.  Most of them are hard coded because I want them to appear in the right place.
		"Player" is used to implement attributes of the character.  Besides sprite and box collider, it has other components including animator and rigidbody.  
			The animator controller in animator component controls the animations of the character.  A character has two animations, idle and walking. The animations change in different conditions controlled by animator controller. 
			Rigidbody makes it possible for the chararcter to move.  The script "Player.cs" is created to control the rule of movement of the character and the actions of the character when it hits the other objects.
		"CM vcam1" is used to control the camera moving follow the character.
	2. Testing is also my job.  After Zijing and me connecting scenes up using scene manager in Unity engine, I tested the game.  
	    And I found some issues need to be fixed. I modified animator controllers and did simple game balance, so that the game won't be too easy or too hard.
	
	3. I also write some parts of our design document.




Yuanpei Teng:

	1. Participated in the discussion of the design ideas of the entire game, like the layout
	    of our maze and keep to get the update news about the project from teacher.
	    Keep the news up to date is one of my main job.

	2. Because Our team maze contains one main map which linked to three levels of different maze, 
	    My main job is to created the third scene which is also the second levels of our maze. 
	    In my maze, all prefabs and gameobjects are created by myelf, which are the basic coding parts in order to build the maze. 
	    In the logical part of my maze, I created some features, for example, 
	    the key to the next level was generated at a random location on the map, the different between my level and the first level
	    that created by Jiyuan is that the key in my maze is generated at a random location, not always in the same place.
	    there are five keys in total, the door that go back to the main map will appear after player 
	    collected all five keys and obviously also need to pass the maze at the same time.
 
	3. I always communicate with my team member to keep my maze updates, 
	   fixed some bugs that exists in my maze and include some new features in each new version update.

	4. Write two parts with lots of sub-parts for each part of our Design documents. These two parts are Design History part and
	    Game overview part.


Xinyang Shao:

	 1. After discussing with our team members, I was responsible for the design and production of the last small level which is the third level.
		The theme of this game is the maze, so no matter what level, the game will not be changed in the maze way. The first thing I need to do is to design a map of my level maze. 
		Secondly, the level I am responsible for has different elements from other team members, and finally I decided to add the elements of the enemy to my level. Because this is unique to my level, 
		I designed and painted the frame animation of the enemy I needed. 
		After that I wrote the mechanism code for the characters and enemies. I have encountered many bugs and problems, and I need to solve them one by one. 
		After I finished my level, I handed over my scene, code and materials to Zijing, whose job is to linked all the levels of maze to the main map.
		

	2. Writing 4 parts of the design document which are The world Layout,  Game characters, User interface and The game world.  To writing these parts, I need to fully communicate with the team members to understand the work they do
	    and collect those information from our team members.
	
	3. Create the monster characters that need to use in my own maze.
	


Hanyue Shi: 

	1. The main part of my job in the group assignment is create all material and UI we will using for maze game.
		For the material part I used “Sai” and “photo shop” to create the knight, princess, background square, wall square, door, key, coin, and slime. 
		For the knight I create four graphs to make the knight seems as walk when moving. 
		Same as the slime I used bigger and smaller to shows the slime is seems as moving. 
		I used “bosca ceoil” to create music part which include background music and collecting music and open-door music. I created 3 or 4 for each of part trying to get a better feeling.

	2. Create the vedio trailer and poster for our team project.
	
	3. Create the Start menu and end menu for our maze
		MainMenu.cs
		There have two methods one for LoadScene the index will go next page the other one is doing quit for the quit button. When the button was clicked then we have debug for testing which shows “HasQuit”.

		QuitAtTheEnd.cs
		Same as the quit method.



	
