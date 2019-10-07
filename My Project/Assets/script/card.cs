using System;
using CryEngine;

namespace CryEngine.Game
{
	[EntityComponent(Guid="41745482-a2fc-489b-4f03-9c8f938de2f9")]
	public class card : EntityComponent
	{
        /// <summary>
        /// Called at the start of the game.
        /// </summary>
        /// 
        public int rank;
        public string suit;

		protected override void OnGameplayStart()
		{
			
		}

		/// <summary>
		/// Called once every frame when the game is running.
		/// </summary>
		/// <param name="frameTime">The time difference between this and the previous frame.</param>
		protected override void OnUpdate(float frameTime)
		{
			
		}
	}
}