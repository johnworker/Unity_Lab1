
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace minigame
{
    public class GameController : MonoBehaviour
    {
        public GameObject OneBallPrefab;
        public int Score = 0;
        public bool Gameover = true;
        public int NumberOfBalls = 0;
        public int MaximumBalls = 15;
        public TextMeshProUGUI ScoreText;
        public Button PlayAgainButton;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("AddBall", 1.5F, 1);
        }

        // Update is called once per frame
        void Update()
        {
            // Instantiate(OneBallPrefab);
            ScoreText.text = Score.ToString();
        }

        public void ClickedOnBall()
        {
            Score++;
            NumberOfBalls--;
        }


        public void AddABall()
        {
            if(!Gameover)
            {
                Instantiate(OneBallPrefab);
                NumberOfBalls++;
                if(NumberOfBalls >= MaximumBalls)
                {
                    Gameover = true;
                    PlayAgainButton.gameObject.SetActive(true);
                }
            }
        }

        public void StartGame()
        {
            foreach (GameObject ball in GameObject.FindGameObjectsWithTag("GameController"))
            {
                Destroy(ball);
            }
            PlayAgainButton.gameObject.SetActive(false);
            Score = 0;
            NumberOfBalls = 0;
            Gameover = false;
        }
    }

}
