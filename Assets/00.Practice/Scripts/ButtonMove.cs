using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public Vector3 pressOffset;

    public Color pressColor = Color.white;
    public Color unpressColor = Color.white;

    public void Press()
    {
        gameObject.transform.localPosition += pressOffset;
        gameObject.GetComponent<MeshRenderer>().material.color = pressColor;
    }

    public void UnPress()
    {
        gameObject.transform.localPosition -= pressOffset;
        gameObject.GetComponent<MeshRenderer>().material.color = unpressColor;

    }
}
