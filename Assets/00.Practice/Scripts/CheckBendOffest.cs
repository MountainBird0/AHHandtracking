using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Autohand
{
    public class CheckBendOffest : MonoBehaviour
    {
        public float num;

        private void OnEnable()
        {
            num = gameObject.GetComponent<Finger>().bendOffset;
        }

        void Update()
        {
            Debug.Log(num);
        }
    }

}
