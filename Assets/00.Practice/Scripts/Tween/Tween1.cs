using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tween
{ 
    public class Tween1 : MonoBehaviour
    {
        public GameObject cube_1;       
        public Vector3 move_1 = new Vector3(10, 10, 10);
        public Vector3 rot_1 = new Vector3(180, 180, 180);
        public Vector3 scale_1 = new Vector3(10, 10, 10);
        
        
        public GameObject cube_2;
        public Vector3 vec3_2 = new Vector3(10, 10, 10);


        void Start()
        {
            cube_1.transform.DOMove(move_1, 10f, false);
            cube_1.transform.DORotate(rot_1, 10f, RotateMode.Fast);
            cube_1.transform.DOScale(scale_1, 10f);
            cube_1.GetComponent<MeshRenderer>().material.DOColor(Color.red, 10f);
            // cube_1.GetComponent<MeshRenderer>().material.DOFade(0, 10f);

            cube_2.transform.DOMove(vec3_2, 10f).SetEase(Ease.InOutQuart).SetLoops(-1, LoopType.Yoyo);

        }        
    }
}


