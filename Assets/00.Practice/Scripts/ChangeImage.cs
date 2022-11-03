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
        Debug.Log($"[ChangeImage] : ��ư ����");
        image.color = Color.red;
    }

    public void ChangeUnTouchColor()
    {
        Debug.Log($"[ChangeImage] : ��ư �ٽ� ����");
        image.color = Color.yellow;
    }
}
