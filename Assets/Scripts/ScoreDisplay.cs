using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text myText;

    //Use this for initialization
    void Start()
    {
        myText.text = PlayerPrefs.GetFloat("playerScore").ToString();
    }
}