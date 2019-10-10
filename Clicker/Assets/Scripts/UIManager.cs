using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI관련 코드를 사용할 수 있음
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text goldDisplayer;
    public Text goldPerClickDisplayer;

    public DataController dataController;
    void Update()
    {
        goldDisplayer.text = "GOLD: " + dataController.GetGold();
        goldPerClickDisplayer.text = "GOLD PER CLICK: " + dataController.GetGoldPerClick();
    }
}
