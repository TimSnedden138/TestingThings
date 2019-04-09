using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour {
    public List<ButtonsComp> buttonList = new List<ButtonsComp>();
    public Text ShopName;
    public Text ShopDescr;
    private int PlayerMoney;
    public Text Money;
    public Text PlayerInv;
    public List<string> playerInv;
    // Use this for initialization
    void Start() {
        switch (Random.Range(1, 4))
        {
            case 0:
                ShopName.text = "0";
                break;
            case 1:
                ShopName.text = "1";
                break;
            case 2:
                ShopName.text = "2";
                break;
            case 3:
                ShopName.text = "3";
                break;
        }
        ShopDescr.text = "Welcome would you like to buy one of these Items";
        ShopDescr.resizeTextForBestFit = true;
        ShopDescr.color = Color.white;
        PlayerMoney = Random.Range(0, 546);
        PlayerInv.color = Color.white;
        PlayerInv.fontSize = 39;
        Money.color = Color.white;
        Money.resizeTextForBestFit = true;
        for (int i = 0; i < buttonList.Count; i++)
        {
         buttonList[i].Obj.GetComponentInChildren<Text>().text = buttonList[i].objText + buttonList[i].objVal;
        }
        buttonList[0].Obj.onClick.AddListener(() => AddtoInv(0));
        buttonList[1].Obj.onClick.AddListener(() => AddtoInv(1));
        buttonList[2].Obj.onClick.AddListener(() => AddtoInv(2));
        buttonList[3].Obj.onClick.AddListener(() => AddtoInv(3));
        buttonList[4].Obj.onClick.AddListener(() => AddtoInv(4));
    }

    // Update is called once per frame
    void Update()
    {
        Money.text = "Your Money Is: " + PlayerMoney;
    }
    public void AddtoInv(int i)
    {
        if (PlayerMoney > buttonList[i].objVal)
        {
            playerInv.Add(buttonList[i].objText);
            PlayerInv.text = "";
            PlayerMoney = PlayerMoney - buttonList[i].objVal;
        }
        else
        {
            return;
        }
        foreach(string msg in playerInv)
        {
            PlayerInv.text += msg.ToString() + "\n";
        }
    }
}
[System.Serializable]
public class ButtonsComp
{
    public Button Obj;
    public string objText;
    public int objVal;
}
