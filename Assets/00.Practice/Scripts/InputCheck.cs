using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCheck : MonoBehaviour
{
    public void ClickButton()
    {
        Debug.Log("버튼 누름");
    }

    public void Pressed()
    {
        Debug.Log("누름");
    }

    public void UnPressed()
    {
        Debug.Log("다시 누름");
    }
}
