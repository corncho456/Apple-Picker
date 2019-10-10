using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Button : MonoBehaviour
{
    public DataController dataController;
    public void OnClick()
    {
        //gold = gold + goldPerClick;
        int goldPerClick = dataController.GetGoldPerClick();
        dataController.AddGold(goldPerClick);
    }


}
