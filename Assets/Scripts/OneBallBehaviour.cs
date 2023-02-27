using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame 
{
    public class OneBallBehaviour : MonoBehaviour
    {
        static int BallCount = 0;
        public int BallNumber;

        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3
                (3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);

            BallCount++;
            BallNumber = BallCount;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
