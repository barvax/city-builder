using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resorce : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    Math math;
    MathPanel mathPanel;
    public int resourceType;
    private Transform icon;
    public float speed;
    Sounds sounds;
    [HideInInspector]
    public BoxCollider2D boxCollider;
    Player player;
    private void Awake()
    {
        mathPanel = FindObjectOfType<MathPanel>();
        icon = gameObject.transform.GetChild(0);
        sounds = FindObjectOfType<Sounds>();
        boxCollider = GetComponent<BoxCollider2D>();

    }
    void Start()
    {
        math = FindObjectOfType<Math>();
        player = FindObjectOfType<Player>();
      
    }

    private void OnMouseDown()
    {/*
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("i have been cliked");
            math.SendToBuilding();
            mathPanel.ShowImage(resourceType);
            mathPanel.gameObject.SetActive(true);
            sounds.PlayClick();
        }
        var resorces = FindObjectsOfType<Resorce>();
        for (int i = 0; i < resorces.Length; i++)
        {
            resorces[i].boxCollider.enabled = false;
        }
       
      */
    }

    private void Update()
    {
        icon.transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("o.k OnPointerClick");

        if (true)
        {
            Debug.Log("i have been cliked");
            math.SendToBuilding();
           mathPanel.ShowImage(resourceType);
            mathPanel.gameObject.SetActive(true);
            sounds.PlayClick();
            math.resourceType = resourceType;
        }
        var resorces = FindObjectsOfType<Resorce>();
        for (int i = 0; i < resorces.Length; i++)
        {
            resorces[i].boxCollider.enabled = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("o.k OnPointerDown");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("o.k  OnPointerUp");
    }

   
}
