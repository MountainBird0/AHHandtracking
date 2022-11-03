using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public GameObject MainUI;

    public void ShowMainUI()
    {
        MainUI.SetActive(true);
    }

    public void HideMainUI()
    {
        MainUI.SetActive(false);
    }
}
