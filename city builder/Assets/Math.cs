using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Math : MonoBehaviour
{
    public Text text;
    public int level;
    public int randNum;
    public int result;
    public int answer;
    public BoxAnswer[] boxAnswers;
    public int[] numbersArr;
    Sounds sounds;
    public MathPanel mathPanel;
    Resorce resorce;
    public int resourceType;
    Player player;


    void Start()
    {
        player = FindObjectOfType<Player>();
        // mathPanel = FindObjectOfType<MathPanel>();
        resorce = FindObjectOfType<Resorce>();
        sounds = FindObjectOfType<Sounds>();
        for (int i = 0; i < 100; i++)
        {
            numbersArr[i] = i+1;
        }
        
    }

   public void RandomNumber()
    {
        randNum = Random.Range(1, 11);
       
    }
    public int SetDrill(int level)
    {
        RandomNumber();

        result = level * randNum;
        return result;
    }

    public void ShowDrill()
    {
        text.text = level+ "x" + randNum;
    }

    public void Answer()
    {
        if(result == answer)
        {
            AddresourceToPlayer();
            sounds.PlayTrueAnswer();
           Debug.Log("good");
            mathPanel.ClosePanel();
            var resorces = FindObjectsOfType<Resorce>();
            for (int i = 0; i < resorces.Length; i++)
            {
                resorces[i].boxCollider.enabled = true;
            }
           
          
        }
        else
        {
            Debug.Log("bad");
        }
       
    }
   public void SendToBuilding()
    {
       
        SetDrill(level);
        ShowDrill();
        Suffel();
        mathPanel.OpenMyPanel();
    }


   
    public void Suffel()
    {
        Debug.Log("im result:" + result);
        int temp;
        bool theAnswer = false;
        for (int i = 0; i < numbersArr.Length; i++)
        {
            int rand = Random.Range(0, numbersArr.Length);
            temp = numbersArr[i];
            numbersArr[i] = numbersArr[rand];
            numbersArr[rand] = temp;
           
        }

        for (int i = 0; i < boxAnswers.Length; i++)
        {
            boxAnswers[i].index = numbersArr[i];
            boxAnswers[i].numText.text = numbersArr[i].ToString();
            if (numbersArr[i] == result)
            {
                theAnswer = true;
                Debug.Log("test test im the answer" + i);
            }
        }

        if (!theAnswer)
        {
            int randresult = Random.Range(0, boxAnswers.Length);
            boxAnswers[randresult].index = result;
            boxAnswers[randresult].numText.text = result.ToString();
        }
       
    }

    public void AddresourceToPlayer()
    {
         Debug.Log(resourceType + " is the resource type");
        if (resourceType == 0)
        {
            //  Debug.LogError("player gold: " + Player.gold);
            Player.gold++;
        }
         if (resourceType == 1)
        {
            Player.food++;
        }
         if (resourceType == 2)
        {
            Player.wood++;
        }
         if (resourceType == 3)
        {
            Player.stone++;
        }
       
       

        player.DisplayResources();
        Debug.Log("gold: " + Player.gold);
        Debug.Log("wood: " + Player.wood);
        Debug.Log("stone: " + Player.stone);
        Debug.Log("food: " + Player.food);

    }
}
