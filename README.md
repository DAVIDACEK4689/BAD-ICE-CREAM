# Bad Ice Cream - C# Implementation

**Author:** Tadeáš Tomiška

## Overview

This project is a Windows Forms implementation of the classic arcade game *Bad Ice Cream* using C#. The game features 16 levels where the player must collect all the fruit (bananas) in each level. If the player is caught by a monster, they lose. Players can use ice blocks to defend themselves.

## Features

- **Game Levels:** 16 levels with progressively challenging gameplay.
- **Controls:** 
  - **Arrow keys** for movement.
  - **Space bar** to create ice blocks.
- **Files Used:**
  - `plan.txt` - for loading the game map.
  - `ikonky.png` - for game element graphics.
  - `song.wav` - for background music.
  - `pocet_odemcenych_levelu.txt` - tracks unlocked levels.

## Game Logic

- **Main Classes:**
  - **Hero** and **Monster**: Derived from `PohyblivyPrvek`, with the `UdelejKrok` method to handle movement.
  - **Map**: Manages levels and game state, with methods for loading maps, drawing elements, and handling interactions.
    - **Methods:**
      - `NactiMapu`: Loads map data from `plan.txt`.
      - `NactiIkonky`: Loads icons from `ikonky.png`.
      - `VykresliSe`: Draws the current state of the map.
      - `PriseryTahnete`, `PohniHrdinou`: Handle object movement and level updates.
      - `Seber_Banan`: Collects bananas and updates the count.
      - `PostavKostku`, `SmazKostku`: Modifies map elements.

## Form1.cs

- **Start Button**: Initiates the game and displays levels.
- **Level Buttons**: Unlock and display level buttons.
- **Timer1_Tick**: Manages game actions during level play.
- **Mute/Unmute Button**: Controls background music.
- **Continue Victory**: Displays upon winning a level.
- **Game Over**: Displays upon losing a level.

## Icons

- **a** - Hero moving down
- **b** - Hero moving left
- **c** - Hero moving right
- **d** - Hero moving up
- **v** - Monster moving down
- **<** - Monster moving left
- **>** - Monster moving right
- **^** - Monster moving up
- **i** - Ice block
- **X** - Obstacle
- **B** - Banana
- **r** - Melting ice block
- **n** - New ice block
- **?** - Banana covered by ice

## Conclusion

Developing this simple game was a valuable experience in game development. While there are areas for improvement, such as graphics and code clarity, I am pleased with the functionality of my first game project. I look forward to refining the game and addressing any issues.