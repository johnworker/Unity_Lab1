
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace minigame
{
    public class GameController : MonoBehaviour
    {
        public GameObject OneBallPrefab;

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
    }

}
