﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerShip : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject dice1, dice2;
    public GameObject Property;
    public GameObject buyButton;
    public GameObject doNotBuyButton;
    public GameObject PayButton;

    public int[] playerOwnership;
    // Start is called before the first frame update
    void Start()
    {
        buyButton.SetActive(false);
        doNotBuyButton.SetActive(false);
        PayButton.SetActive(false);
        playerOwnership = new int [22];
        //walletText.GetComponent<TextMeshProUGUI>().text = "player money" + stopRolling.ToString();

    }


    public void CheckOwnership()
    {
        
        if (playerOwnership[Property.GetComponent<Properties>().properyTracker] == 0)
        {
            buyButton.SetActive(true);
            doNotBuyButton.SetActive(true);
        }
        else if (playerOwnership[Property.GetComponent<Properties>().properyTracker] == dice1.GetComponent<Dice>().turn)
        {
            
        }
        else
        {
            PayButton.SetActive(true);
        }
        
    }
    

}