using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGrid : MonoBehaviour
{
    public GameObject gridTile;
    public float xFactor;
    public float yFactor;
    void Start()
    {
        SetMultyXy();
        SetTileMap();
    }

   public void SetXY()
    {
       
        for (int i = 0; i < 30; i++)
        {
            xFactor -= 2.56f;
            yFactor -= 1.28f;
        }
    }

    public void SetMultyXy()
    {
        float baseValue = -30f;
        for (int i = 0; i < 50; i++)
        {
            yFactor = baseValue;
            SetXY();
            SetTileMap();
            xFactor = 0;
            baseValue += 2.56f;
            
        }
    }
   public void SetTileMap()
    {
      
        for (int i = 0; i < 60; i++)
        {
            Instantiate(gridTile, new Vector3(transform.position.x+xFactor, transform.position.y+yFactor), transform.rotation);
            xFactor += 2.56f;
            yFactor += 1.28f;
        }
       
    }
}
