using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame 
{
    public class OneBallBehaviour : MonoBehaviour
    {
        public float XSpeed;
        public float YSpeed;
        public float ZSpeed;
        public float Multiplier = 0.75F;
        public float TooFar = 5;

        static int BallCount = 0;
        public int BallNumber;

        // Start is called before the first frame update
        void Start()
        {
            //transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);

            BallCount++;
            BallNumber = BallCount;

            ResetBall();
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Time.deltaTime * XSpeed, Time.deltaTime * YSpeed, Time.deltaTime * ZSpeed);

            XSpeed += Multiplier - Random.value * Multiplier * 2;
            YSpeed += Multiplier - Random.value * Multiplier * 2;
            ZSpeed += Multiplier - Random.value * Multiplier * 2;

            if ((Mathf.Abs(transform.position.x) > TooFar)
                || (Mathf.Abs(transform.position.y) > TooFar)
                || (Mathf.Abs(transform.position.z) > TooFar))
            {
                ResetBall();
            } 
        }

        private void ResetBall()
        {
            XSpeed = Random.value * Multiplier;
            YSpeed = Random.value * Multiplier;
            ZSpeed = Random.value * Multiplier;

            transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);

        }




        void OnMouseDown()
        {
            GameController controller = Camera.main.GetComponent<GameController>();
            if (!controller.Gameover)
            {
                controller.ClickedOnBall();
                Destroy(gameObject);
            }
        }

    }

}
