# UPWEGO : AP_Final_Project 

### Created by: AmirReza Safari (404521426) & Sina Motamedi Nejad (404522088)

## Introduction 
UPWEGO is a 2D space shooting game inspired by the legendary game **Space Invaders**. In this game, you control a spaceship and fight enemy spaceships appearing 
from the top of the screen. There are plenty of dangerous enemies with various abilities, each with its own health, speed, and unique characteristics.

### Enemies

- **Standard Enemy** – Moves linearly toward the player.
- **Scout Enemy** – Similar to the Standard Enemy but moves in a zigzag pattern.
- **Terrorist Enemy** – Tracks the player's movements.
- **Shooter Enemy** – Attacks from a distance by firing bullets.
- **Tank Enemy** – The final boss with enormous health and the ability to shoot in eight directions.

These are the enemies you will face throughout the game!

There is an in-game guide explaining how to play, but as a quick guide: Your spaceship moves with the arrow keys on your keyboard and you can shoot by either pressing or holding the space bar. 
That's it! Now you're ready to explore and advance through the perilous depths of space in front of you. Good luck, **Captain**!

## Features List

- **Resource Control (both pixel and generated)** (GameAssets & AssetManager classes and Resources.resx)
- **Player & Enemy Implementing** (Player.cs , Enemy.cs)
- **Game Environment & Logic** (Game.cs , ProfileManager.cs , LootManager.cs and etc)
- **Shooting Logic** (Bullet.cs , GameObject.cs)
- **Coin Pickup** (Coin.cs , LootManager.cs)
- **Power Up Implementing** (PowerUps.cs , Player.cs)
- **Sounds and Musics Management** (MusicPlayer.cs , SoundEffects.cs , GameSettings.cs)
- **Sounds Control** (Sounds.cs , MusicPlayer.cs , SoundEffects.cs )
- **Making the Uis and Forms** (MainMenu.cs , SelectForm.cs , Options.cs , etc)
- **DataBase and Shop Section** (Shop.cs , DatabaseModels.cs , ShopManager.cs , etc)
- **Wave Management for game stages** (WaveManager.cs , Game.cs)
- **Head-Up Display with extra features like player's health** (Game.cs , Player.cs)
- **pixel mode and normal mode** (choose.cs , AssetManager.cs)

## Play Guide

Before Playing the game, There are some prerequisites that you must install: after cloning the files into your visual studio, you should choose the NuGet Package Manager (Manage NuGet Packages for Solution) from the tools tab located on the top bar of visual studio, then you must search and install Microsoft.EntityFrameworkCore.SQLite and Microsoft.EntityFrameworkCore.Tools from the Browse Part. Now You're ready to play! (You can also right click on the Arcade Game in your solution Explorer and apply the installations by choosing Manage NuGet Packages for Solution)

For Opening the Solution (to installing the required packages from previous section or managing the forms), there are two common ways: You can choose it by clicking on the Solution Explorer from the view tab on the top of the visual studio (tabs section) or you can use the Combined keys Ctrl and w on your keyboard and then press s, so you can see the Solution Explorer is opened. After that, you must build the project and it's usually done by clicking on green icon (Next to Realese and CPU part on the top), but it also can be done by choosing the Build Solution from the Build tab on the top of Visual Studio or pressing F6 on the keyboard. After that, the game is ready to play! Build Your Profile at the SelectForm Opened and Play after checking Guide from Options!

---

### Thanks for reading this ReadMe!
#### Represented by SINA MOTAMEDI NEJAD & AMIRREZA SAFARI
