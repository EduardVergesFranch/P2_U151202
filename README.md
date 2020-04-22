# P2_U151202
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
  In this scene, I have implemented models,materials... provided to us in the content of the practice.
  1) Two windmills that have moving 
  2) A Hay Machine that is able to move and shoot Hale Bales to the sheeps.
  3) Sheeps that spawn in three different spwanpoints. If the Hay Machine is not able to shoot one sheep, this sheep will be dropped. You loose if 3 sheeps are dropped.
  4)
### ISSUES
Sheep.cs has a function Drop() that is activated when the sheep collides with the trigger object ("DropSheet"). Theorically, when this happens, a counter located in the GameManager.cs has to be updated summing 1 to its current value. Unfortunately, my implementation sum 2 units to the current value of the counter each time and I couldn't fix it.
### ANNEX
Links for the tutorials:
