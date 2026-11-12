using Godot;

namespace GA.Ponk
{
	public partial class GameManager : Node
	{
		public static GameManager Instance { get; private set; }

		public GameManager()
		{
			if (Instance == null)
			{
				Instance = this;
			}
			else if (Instance != this)
			{
				QueueFree();
				return;
			}
		}

		// TODO: Add support for lives and score here.

		// TODO: Add support for game states here. See GArkanoid as an example.
		// Game states should include:
		//  - MainMenu
		//  - Gameplay
		//  - Paused
		//  - GameOver
		//  - Victory

		// TODO: Add support for saving the game.
		// This should include saving the current score, lives, ball position
		// and velocity, paddle position, and any other relevant game state information.
	}
}