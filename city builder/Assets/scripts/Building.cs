using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public bool isInPlace= false;
    public int xpos;
    public int yPos;
    SpawnBuilding spawn;
    public Sprite sprite;
    void Start()
    {
        spawn = FindObjectOfType<SpawnBuilding>();
        spawn.image.sprite = sprite;
        Tile[] tiles = FindObjectsOfType<Tile>();
        Debug.Log(tiles.Length);
        for (int i = 0; i < tiles.Length; i++)
        {
           var tile= tiles[i].gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
           // tile.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (!isInPlace)
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,Input.mousePosition.y+10));
            transform.position = worldPos;
        }
       */
    }

   
}
