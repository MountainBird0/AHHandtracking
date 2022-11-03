using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    private Image image;

    public void OnEnable()
    {
        image = gameObject.GetComponent<Image>();
    }

    public void ChangeTouchColor()
    {
        Debug.Log($"[ChangeImage] : 버튼 누름");
        image.color = Color.red;
    }

    public void ChangeUnTouchColor()
    {
        Debug.Log($"[ChangeImage] : 버튼 다시 누름");
        image.color = Color.yellow;
    }
}
