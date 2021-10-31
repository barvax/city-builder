using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxAnswer : MonoBehaviour
{
    public  int index;
    public Text numText;
    Math math;
    void Start()
    {
        math = FindObjectOfType<Math>();
        
    }

    // Update is called once per frame
    public void SetAnswer()
    {
        math.answer = index;
    }
}
