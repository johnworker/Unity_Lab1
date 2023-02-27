
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class GameController : MonoBehaviour
    {
        public GameObject OneBallPrefab;
        public int Score = 0;
        public bool Gameover = false;
        public int NumberOfBalls = 0;
        public int MaximumBalls = 15;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("AddBall", 1.5F, 1);
        }

        // Update is called once per frame
        void Update()
        {
            Instantiate(OneBallPrefab);
        }

        public void ClickedOnBall()
        {
            Score++;
            NumberOfBalls--;
        }

        private void OnMouseDown()
        {
            GameController controller = Camera.main.GetComponent<GameController>();
            controller.ClickedOnBall();
            Destroy(gameObject);
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
                }
            }
        }

        public void StartGame()
        {

        }
    }

}
