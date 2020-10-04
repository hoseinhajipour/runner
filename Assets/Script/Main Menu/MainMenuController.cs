using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Text BestCoinsText;
    void Start()
    {
        BestCoinsText.text = "Best: " + PlayerPrefs.GetInt("coin");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
