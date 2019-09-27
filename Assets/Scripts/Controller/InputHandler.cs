using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class InputHandler : MonoBehaviour
    {
        float horizontal;
        float vertical;

        bool aimInput;
        bool sprintInput;
        bool shootInput;
        bool crouchInput;
        bool reloadInput;
        bool switchInput;
        bool pivotInput;
        bool tets;

        bool isInit;

        float delta;

        void Start()
        {
            InitInGame();
        }
        public void InitInGame()
        {

        }

        void FixedUpdate()
        {
            if (!isInit)
            {
                return;
            }
            delta = Time.fixedDeltaTime;


        }
        void Update()
        {
            if (!isInit)
            {
                return;
            }
            delta = Time.deltaTime;
        }
    }
}
