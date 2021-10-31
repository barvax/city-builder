using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathPanel : MonoBehaviour
{
    public Image resourceImage;
    public Sprite[] resourcesSprites;
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public  void ShowImage(int index)
    {
        resourceImage.sprite = resourcesSprites[index];
    }

    public void ClosePanel()
    {
        StartCoroutine(closeMyPanel());
    }
    IEnumerator closeMyPanel()
    {
        yield return new WaitForSeconds(0.2f);
        this.gameObject.SetActive(false);
    }

    public void OpenMyPanel()
    {
        this.gameObject.SetActive(true);
    }
}
