# Mini Game

Welcome to the Mini Game repository! This project is a simple and fun game developed using the Unity game engine. The objective of the game is to feed the farm animals and score as high as possible.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Scripts Overview](#scripts-overview)

## Introduction

This mini game is designed to be a quick and enjoyable experience. The goal of the game is to feed the farm animals and achieve the highest score possible. The game includes various mechanics such as player movement, animal spawning, scoring, and a timer.

## Features

- Simple and intuitive gameplay
- Feed various farm animals
- Scoring system to track your high scores
- Timer to challenge the player
- Dynamic difficulty adjustment

## Installation

To get a local copy up and running, follow these simple steps:

1. **Clone the repository:**

    ```sh
    git clone https://github.com/sarvinshrivastava/Mini-Game.git
    ```

2. **Navigate to the project directory:**

    ```sh
    cd Mini-Game
    ```

3. **Open the project in Unity:**

    Open Unity Hub, click on "Add", and select the project directory.

## Usage

To start the game, open the project in Unity and press the play button in the Unity Editor. Follow the on-screen instructions to feed the animals and score as high as possible.

## Scripts Overview

### ForwardMoveScript.cs

Handles the forward movement of objects and destroys them when they go out of bounds.

### GameManagerScript.cs

Singleton pattern to manage the game state and score.

### PlayerMovementScript.cs

Handles player movement and food throwing mechanics.

### SceneChangeScript.cs

Handles scene transitions such as starting the game, exiting, and continuing.

### ScoreDisplayScript.cs

Displays the current score on the screen.

### SpawningAnimalScript.cs

Spawns animals at random positions and adjusts the spawn rate dynamically.

### TimerScript.cs

Manages the game timer and transitions to the score scene when the time is up.

### FoodAteScript.cs

Handles the collision between food and animals, updates the score, and destroys the objects.

---

Thank you for checking out the Mini Game! If you have any questions or feedback, feel free to open an issue or contact me.
