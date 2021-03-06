﻿using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    // Array of dice sides sprites to load from Resources folder
    private Sprite[] Dice1;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

    // Use this for initialization
     void Start () {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        Dice1 = Resources.LoadAll<Sprite>("Dice1");
    }
	
    // If you left click over the dice then RollTheDice coroutine is started
    public void RollDice()
    {
        StartCoroutine("RollTheDice");
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides randomly
        // before final side appears. 20 iterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = Dice1[randomDiceSide];

            // Pause before next iteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;                                                                                                                                                         

        // Show final dice value in Console
        Debug.Log(finalSide);
    }
}
