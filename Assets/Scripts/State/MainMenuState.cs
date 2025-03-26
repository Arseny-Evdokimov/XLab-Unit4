using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public GameState gamePlayState;
        public TMP_Text scoreText;
        [FormerlySerializedAs("LevelContr")] public LevelController levelController;

        public void PlayGame()
        {
            Exit();
            gamePlayState.Enter();
        }
        protected override void OnEnable()
        {
            base.OnEnable();

            scoreText.text = $"Highscore: {levelController.highScore}";
        }
    }
}
