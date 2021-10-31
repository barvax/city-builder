using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    public static int wood;
    public static int stone;
    public static int gold;
    public static int food;

    public TextMeshProUGUI woodText;
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI foodText;

  
    void Start()
    {
        DisplayResources();
    }

    public  void DisplayResources()
    {
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
        goldText.text = gold.ToString();
        foodText.text = food.ToString();
    }
}
