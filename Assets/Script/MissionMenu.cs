using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionMenu : MonoBehaviour
{
    public GameObject SubMenuView;
    public GameObject MissionMenuView;

    public void onClickCancelBtn()
    {
        MissionMenuView.SetActive(false);
        SubMenuView.SetActive(true);
    }
}
