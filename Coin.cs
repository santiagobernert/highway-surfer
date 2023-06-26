using System;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text coinText;
    public int coins;
    void Start() {
        coinText = GetComponent<Text>();
        coinText.text = "" + PlayerPrefs.GetInt("coins", coins);
    }
}