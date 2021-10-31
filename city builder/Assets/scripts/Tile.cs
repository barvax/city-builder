using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool isClear = true;
    public GameObject theBuilding;
   SpawnBuilding spawnBuilding;
    public GameObject myTestPrifab;
  
    Sounds sounds;
   
    void Start()
    {
        spawnBuilding = FindObjectOfType<SpawnBuilding>();
        sounds = FindObjectOfType<Sounds>();
      
    }

    // Update is called once per frame
  /*  private void OnMouseEnter()
    {
        if (spawnBuilding.isSpawning)
        {
            //  Debug.Log("tile enter");
          //  var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
           // ron.color = new Color32(255, 100, 100, 100);
        }
     */
   /* }
    private void OnMouseExit()
    {
        if (spawnBuilding.isSpawning)
        {
          //  Debug.Log("tile exit");
           // var ron = gameObject.transform.GetChild(0). GetComponent<SpriteRenderer>();
           // ron.color = new Color32(255, 255, 255, 0);
        }
       
    }*/
   /*
    private void OnMouseDown()
    {

        if (spawnBuilding.currentBuilding != null && isClear)
        {

            spawnBuilding.tilePosition = this.transform;
            spawnBuilding.tile = this;
            spawnBuilding.placeBuildingPanel.SetActive(true);
            var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
            ron.color = new Color32(100, 100, 100, 255);

        }
       
       


    }
   */
    /*
    public void SetBuildingInPlace()
    {
        theBuilding = spawnBuilding.currentBuilding;
        Debug.Log("o.k");
        //  Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transform.position = worldPos;
        theBuilding.GetComponent<Building>().isInPlace = true;
        Debug.Log("is in place: " + theBuilding.GetComponent<Building>().isInPlace);
        theBuilding.transform.position = this.transform.position;
        var yaxis = transform.position.y;
        var final = Mathf.RoundToInt(-yaxis);
        theBuilding.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = final;
        spawnBuilding.currentBuilding = null;
        isClear = false;
        spawnBuilding.isSpawning = false;
        var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        ron.color = new Color32(255, 255, 255, 0);
        sounds.PlayBuild();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Air")
        {
            Debug.Log("wwwwwwwwwwwwwwww");
            isClear = false;
            var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
            ron.color = new Color32(100, 100, 100, 255);

        }
       
    }

    */

    public void OnPointerClick(PointerEventData eventData)
    {

        if (spawnBuilding.currentBuilding != null && isClear)
        {

            spawnBuilding.tilePosition = this.transform;
            spawnBuilding.tile = this;
            spawnBuilding.placeBuildingPanel.SetActive(true);
            var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
            ron.color = new Color32(100, 100, 100, 255);

        }

    }


    public void ClearColor()
    {
        var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        ron.color = new Color32(255, 255, 255, 0);
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
