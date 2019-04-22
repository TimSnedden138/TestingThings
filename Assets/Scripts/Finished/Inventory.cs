using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour {
    public List<ButtonsComp> ShopItems = new List<ButtonsComp>();
    public List<string> playerInv;
    public List<Texture> backgroundImages;
    public RawImage rawImage;
    public Text ShopName;
    public Text ShopDescr;
    public Text ScreenInv;
    public Text ScreenMoney;
    private int PlayerMoney;
    // Use this for initialization
    void Start() {
        switch (Random.Range(0, 4))
        {
            case 0:
                ShopName.text = "Gnome Depot";
                rawImage.texture = backgroundImages[0];
                break;
            case 1:
                ShopName.text = "The Shadeland";
                rawImage.texture = backgroundImages[1];
                break;
            case 2:
                ShopName.text = "VoidShow";
                rawImage.texture = backgroundImages[2];
                break;
            case 3:
                ShopName.text = "Corecords";
                rawImage.texture = backgroundImages[3];
                break;
        }
        ShopDescr.text = "Would you like to buy one of these Items" + "\n"+ "To Buy Click The Buttons" +"\n"+
                          "To Sell press 1 through 5 to sell the weapon in the order of the shop";
        ShopDescr.color = Color.white;
        PlayerMoney = Random.Range(0, 546);
        ScreenInv.color = Color.white;
        ScreenInv.fontSize = 25;
        ScreenMoney.color = Color.white;
        for (int i = 0; i < ShopItems.Count; i++)
        {
         ShopItems[i].Obj.GetComponentInChildren<Text>().text = "Weapon: " + ShopItems[i].objText + "\n"+ 
                "Cost: " + ShopItems[i].objVal;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        ScreenMoney.text = "Your Money Is: " + PlayerMoney;
        if (Input.GetKeyDown(KeyCode.Alpha1) && playerInv.Contains(ShopItems[0].objText))
        {
            Remove(ShopItems[0].objText);
            PlayerMoney = PlayerMoney + 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && playerInv.Contains(ShopItems[0].objText))
        {
            Remove(ShopItems[1].objText);
            PlayerMoney = PlayerMoney + 15;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && playerInv.Contains(ShopItems[0].objText))
        {
            Remove(ShopItems[2].objText);
            PlayerMoney = PlayerMoney + 60;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && playerInv.Contains(ShopItems[0].objText))
        {
            Remove(ShopItems[3].objText);
            PlayerMoney = PlayerMoney + 85;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && playerInv.Contains(ShopItems[0].objText))
        {
            Remove(ShopItems[4].objText);
            PlayerMoney = PlayerMoney + 30;
        }
        if(PlayerMoney > ShopItems[0].objVal)
        {
        ShopItems[0].Obj.onClick.AddListener(() => AddtoInv(0));
        }
        if (PlayerMoney > ShopItems[1].objVal)
        {
        ShopItems[1].Obj.onClick.AddListener(() => AddtoInv(1));
        }
    }
    public void AddtoInv(int val)
    {
        if (PlayerMoney > ShopItems[val].objVal)
        {
            playerInv.Add(ShopItems[val].objText);
            
            ScreenInv.text = "";
            PlayerMoney = PlayerMoney - ShopItems[val].objVal;
        }
        else
        {
            Debug.Log("You Dont Have Enough Money");
        }
        foreach(string msg in playerInv)
        {
         ScreenInv.text += msg.ToString() + "\n";
        }
    }
    public void Remove(string val)
    {
        playerInv.Remove(val);
        ScreenInv.text = "";
        foreach (string msg in playerInv)
        {
            ScreenInv.text += msg.ToString() + "\n";

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