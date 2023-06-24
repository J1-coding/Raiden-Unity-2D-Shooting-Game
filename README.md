# Raiden: A Unity 2D Shooting Game 🚀

### Raiden Gameplay Video (Click)
<a href="https://youtu.be/aI9E4yKLZ2Y">
<img src="http://img.youtube.com/vi/aI9E4yKLZ2Y/maxresdefault.jpg" alt="raiden thumbnail image">
</a>

* ### Introduction
Remember the nostalgic game Raiden? Take a trip back to your childhood and try out this remake I've crafted!

* ### Core Features
  * 들여쓰기 2
       
 - Scrolling Background: The background continuously moves on the y-axis, providing an illusion of the player's ship advancing in space.

 + Player Control: The player's movements are controlled through keyboard or mouse input. The character can move in all directions (left, right, up, down) within the screen boundaries.

 + Shooting Mechanic: The player's character shoots bullets upwards. The bullets are pooled and reused for performance optimization, ensuring smoother gameplay even with a large number of bullets on the screen.

 + Enemy Behaviour: Enemies move downwards and possibly target the player. They explode on being hit, leading to an increase in the player's score.

 + Score Management: The game maintains a record of the current score and the top score. The score increases when an enemy is defeated, and the top score is saved and can be accessed in future sessions.

 + Game States Management: The game flow is managed through different states like 'Ready', 'Start', 'Playing', and 'GameOver', providing a well-structured game experience.

 + Object Destruction: A 'DestroyZone' ensures that any objects leaving the play area are properly handled. This helps in maintaining performance and ensuring there are no redundant objects.

 + UI Interactions: The project includes a script for managing UI interactions like starting the game, retrying after a game over, and loading settings.

These features combined create an engaging space shooter game, where the player navigates their ship, shoots at enemies, avoids enemy bullets, and competes for the highest score.

* ### Installation
Follow these steps to get Raiden up and running:

Clone the repository:
```bash
git clone https://github.com/J1-coding/Raiden-Unity-2D-Shooting-Game.git
```
Open the project in Unity: Launch Unity, then click on Open and navigate to the directory where you cloned the repository.

Build the game: To create your own executable, click on File > Build Settings, select your platform, then click Build.

Enjoy Raiden on your machine!


* ### Gameplay
To master Raiden, use the 'W', 'A', 'S', 'D' keys to navigate your spaceship up, left, down and right, respectively. Use the left mouse click to fire missiles at incoming enemies. For each enemy you defeat, you rack up points. However, if you come in contact with enemies more than 7 times, your game ends - it's game over.

* ### Contributing
We appreciate contributions of any kind and value them highly.
Submit bug reports or suggest new features by opening an issue.
Improve existing features or add new ones by submitting a pull request.

* ### Contact
Have questions or suggestions? Feel free to open an issue on GitHub or send us an email(gjeus0707@gmail.com).

Happy gaming! 🎮
