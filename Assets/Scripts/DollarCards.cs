using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollarCards : MonoBehaviour
{

    public static int scoreValue = 1500;

    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "score: $" + scoreValue;
    }
}
