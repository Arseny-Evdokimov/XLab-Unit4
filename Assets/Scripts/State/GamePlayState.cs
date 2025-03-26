using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Golf
{
    public class GamePlayState : GameState
    {
        [FormerlySerializedAs("levelContr")] public LevelController levelController;
        [FormerlySerializedAs("playerContr")] public PlayerController playerController;
        public GameState gameOverState;
        public TMP_Text scoreText;


        protected override void OnEnable()
        {
            base.OnEnable();

            levelController.enabled = true;
            playerController.enabled = true;

            GameEvents.onCollisionStones += OnGameOver;
            GameEvents.onStickHit += OnStickHit;
            OnStickHit();
        }

        private void OnStickHit()
        {
            scoreText.text = $" Score: {levelController.score}";
        }

        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }
        protected override void OnDisable()
        {
            base.OnDisable();

            GameEvents.onCollisionStones -= OnGameOver;

            levelController.enabled = false;
            playerController.enabled = false;
        }
    }
}
