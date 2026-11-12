# Ponk

A Godot C# starting project for a two-player Pong-style game. The starter
scene provides a court, paddles, a ball, walls, collision shapes and a
placeholder score. **It is not a playable game yet.** Implementing the game
is the exercise.

## Getting started

1. Fork the repository on GitHub and clone your fork to your computer.
2. Install **Godot 4.7.2 with .NET support** and a .NET SDK that supports
   `net8.0`.
   The standard Godot editor without .NET support cannot run the C# project.
3. In a terminal, run `dotnet build Ponk.csproj` from the project directory.
   The first build may need internet access to restore dependencies.
4. Open `project.godot` in Godot.
5. Run the project. You should see a stationary court with two paddles,
   a ball and a score.
6. Commit and push your work to your fork as you develop it.

The project is configured for a 960 × 540 viewport. It uses simple shapes
defined in the scenes as its artwork; no external art assets are needed.

## Project layout

- `Scenes/Game.tscn` is the main scene and contains the court and placeholder HUD.
- `Scenes/Paddle.tscn`, `Scenes/Ball.tscn` and `Scenes/Wall.tscn` are
  reusable scenes with visuals and collision shapes.
- `Code/GameManager.cs` is an existing autoload with a placeholder for game
  data. It does not yet implement scoring or lives.
- `project.godot` contains the project settings.

The ball and paddles are `CharacterBody2D` nodes; the walls are `StaticBody2D`
nodes. Collision shapes alone do not move objects or implement bouncing.
Add C# scripts and input actions as needed. For example, you could use W/S
for the left paddle and the up/down arrows for the right paddle.

## Your task

Build a playable local two-player game. At minimum, implement:

- Paddle controls and ball movement.
- Ball collisions with paddles and the top and bottom walls.
- Scoring when the ball passes a paddle, and a way to continue after a point.
- A game-over condition and a way to start another game.
- A user interface that displays the current score and game status.

Discuss the exact requirements and submission instructions with your
instructor. The following are additional ideas, not implemented in the
starter project:

- Give each player lives; decide how points, lost lives and winning relate.
- Add main menu, gameplay, pause and game-over states.
- Save and load a small amount of game state, such as scores and remaining
  lives. Decide when saving and loading are allowed and handle missing or
  invalid save files.

## Checking your work

Run the game and check that both players can control their paddles, the ball
bounces off paddles and walls, points update for the correct player, and the
game ends and restarts according to your rules. If you add pause or saving,
check those flows too. The initial score label and starter notice are static
placeholders: replace or update them as part of your implementation.
