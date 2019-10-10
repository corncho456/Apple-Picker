using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpgradeButton : MonoBehaviour
{
    public Text upgradeDisplayer;

    public string upgradeName;

    [HideInInspector]
    public int goldByUpgrade;
    public int startGoldByUpgrade = 1;


    [HideInInspector]
    public int currentCost = 1; //아이템의 업그레이드 가격
    
    public int startCurrentCost = 1; //게임이 시작되었을때의 가격

    [HideInInspector]
    public int level = 1;

    //업그레이드 계수
    public float upgradePow = 2.14f;
    //코스트 수치 계수
    public float costPow = 3.14f;

    //public DataController dataController;

    //start 함수는 awake 보다 한박자 늦는다. awake -> start 실행된다.
    void Start()
    {
        //currentCost = startCurrentCost;
        //level = 1;
        //goldByUpgrade = startGoldByUpgrade;
        DataController.GetInstance().LoadUpgradeButton(this);
        UpdateUI();
    }


    //업그레이드를 한번 할때마다 골드와 레벨을 올려주는 함수
    public void PurchaseUpgrade()
    {
        //singletone 이용하기
        if (DataController.GetInstance().GetGold() >= currentCost )
        {
            DataController.GetInstance().SubGold(currentCost);
            level++;
            DataController.GetInstance().AddGoldPerClick(goldByUpgrade);

            UpdateUpgrade();
            UpdateUI();
            DataController.GetInstance().SaveUpgradeButton(this);
        }
    }
    //업그레이드 할때 올라가는 정도.
    public void UpdateUpgrade()
    {
        goldByUpgrade = startGoldByUpgrade * (int)Mathf.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
    }

    public void UpdateUI()
    {
        upgradeDisplayer.text = upgradeName + "\nCost: " + currentCost + "\nLevel: " + level + "\nNext New GoldPerClick: " + goldByUpgrade;
    }
}
