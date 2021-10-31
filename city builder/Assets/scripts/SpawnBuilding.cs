using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBuilding : MonoBehaviour
{
    public GameObject currentBuilding;
    public GameObject[] buildings;
    public bool isSpawning;
    public Image image;
    public GameObject placeBuildingPanel;
    public Transform tilePosition;
    public Tile tile;
    public GameObject imageToBuild;

    Sounds sounds;
    void Start()
    {
        sounds = FindObjectOfType<Sounds>();
    }

    // Update is called once per frame
   public void SpawnMyBuilding(int index)
    {
        isSpawning = true;
        Debug.Log("o.k");
      GameObject building =   Instantiate(buildings[index], transform.position, transform.rotation);
        currentBuilding = building;
        imageToBuild.SetActive(true);
       
    }



    public void SetBuildingInPlace( )
    {
       // theBuilding = spawnBuilding.currentBuilding;
        Debug.Log("o.k");
        //  Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transform.position = worldPos;
        currentBuilding.GetComponent<Building>().isInPlace = true;
        Debug.Log("is in place: " + currentBuilding.GetComponent<Building>().isInPlace);
        currentBuilding.transform.position = tilePosition.position;
        currentBuilding.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        var yaxis = tile.transform.position.y;
        var final = Mathf.RoundToInt(-yaxis);
        currentBuilding.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = final;
        currentBuilding = null;
        tile.isClear = false;
        tile.ClearColor();
      isSpawning = false;
      //  var ron = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
       // ron.color = new Color32(255, 255, 255, 0);
        sounds.PlayBuild();
        imageToBuild.SetActive(false);

    }

    public void NoSpawn()
    {
        isSpawning = false;
        if (tile != null)
        {
            tile.ClearColor();
            tile = null;
        }
        if (currentBuilding != null)
        {
            Destroy(currentBuilding);
            currentBuilding = null;
        }
       
        imageToBuild.SetActive(false);
    }
}
