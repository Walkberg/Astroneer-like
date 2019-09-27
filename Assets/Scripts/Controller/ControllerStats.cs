using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{

    [CreateAssetMenu(menuName = "Controller/Stats")]
    [System.Serializable]
    public class ControllerStats : ScriptableObject
    {
        public float walkSpeed = 4;
        public float runSpeed = 6;
        public float crouchSpeed = 2;
        public float aimSpeed = 2;
        public float rotateSpeed = 2.0f;
    }
}
