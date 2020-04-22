# PRACTICE 2 - INTERACTIVE SYSTEMS
#### Eduard Vergés Franch - u151202
### CONTENT OF THE REPOSITORY
  Lab session of Interactive System course of UPF 2019/2020.
### GOAL
The aim of this practice is to follow two tutorials (link in the ANNEX section) to know techniques and get in touch with Unity framework.
### SCENES
  - ### TITTLE
  In this scene there are three main functionalities and elements to take into account:
    1) Start buttont : Starts the game (changes the scene to game scene).
    2) Quit Button: Quits the game.
    3) Hay Machine: Clicking on the hay machine, you can choose the color of it.
  - ### GAME
  All the models, materials and audios implemented are provided in the practice content.
  Different funcionalities of this scene:
    1) Two windmills that have moving wheels
    2) A Hay Machine that is able to move and shoot Hale Bales to the sheeps.
    3) Sheeps that spawn in three different spwanpoints. If the sheep is not shooted by the Hay Machine is dropped. User loose if 3 sheeps        are dropped.
    4) Counter indicating the number of sheeps you have shooted.
    5) Audio clips to improve the game experience (provided in the practice content).
### PREFABS
This are the 3 main prefabs of the game:
  1) Hay Machine: Implement HayMachine.cs.
  2) Hale Bale: Implement Rotate.cs, Move.cs and DestroyOnTrigger.cs . 
  3) Sheep: Implement Sheep.cs.
### SCRIPTS
  #### Game scene:
    - DestroyOnTrigger.cs: Destroy and object after colliding with a trigger. 
    - DestroyTimer.cs: Destroy an object after some time.
    - HayMachine.cs: Define the functionalities of the Hay Machine object like changin its colour, shooting and moving.
    - Move.cs: Define a transaltion movement. 
    - rotate.cs: Defines a rotation movement.
    - sheep.cs: Define the functionalities of the sheep( what happens when it drops, when it is hitten by a hale bale and defines its         movement).
    - sheepSpawner.cs: Is able to spawn a sheet, control the time between spawns and controll the number of sheeps that are disponible.       The spawn point is choosed randomly between the three disponible.
    - TweenScale.cs: Reduces the scale of the heart,that appears when you shoot a sheep, gradually in time.
   #### Tittle:
    - ChangeColorOnMouseOver.cs: Change the coulour of the button when the mouse is in it.
    - QuitButton.cs: Makes the game stop and exit the application.
    - StartButton.cs: Makes the game start.
   #### Shared:
    - GameSettings.cs: Configures the default colour of the Hay Machine to blue.
    - HayMachineColour.cs: Stablish the three possible clours for Hay Machine.
    - HayMachineSwitcher.cs : Switch the colour of the Hay Machine.
   #### Managers:
    - GameStateManager.cs: Manages the counters and the state of the game.
    - SoundManager.cs: Manages the audio clips.
    - UIManager.cs: Manages the user interface.
### ISSUES
Sheep.cs has a function Drop() that is activated when the sheep collides with the trigger object ("DropSheet"). Theorically, when this happens, a counter located in the GameManager.cs has to be updated summing 1 to its current value. Unfortunately, my implementation sum 2 units to the current value of the counter each time and I couldn't fix it.
### ANNEX
Links for the tutorials:
https://www.raywenderlich.com/4180726-introduction-to-unity-scripting-part-1
https://www.raywenderlich.com/4180726-introduction-to-unity-scripting-part-2
