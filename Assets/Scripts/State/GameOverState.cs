using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Golf
{
    public class GameOverState : GameState
    {
        public GameState mainMenuState;
        [FormerlySerializedAs("levelContr")] public LevelController levelController;

        public void Restart()
        {
            levelController.ClearStone();

            Exit();
            mainMenuState.Enter();
        }
    }
}
