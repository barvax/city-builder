using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridBuildingSystem : MonoBehaviour
{
    public static GridBuildingSystem current;

    public GridLayout gridLayout;
    public Tilemap main;
    public Tilemap temp;





    private void Awake()
    {
        current = this;
    }

    public enum TileTyps
    {
        empty,
        white,
        red,
        green
    }

    public static Dictionary<TileTyps, TileBase> tilebase = new Dictionary<TileTyps, TileBase>();
    void Start()
    {
        string tilePath = @"Tiles\";
        tilebase.Add(TileTyps.empty, null);
       // tilebase.Add(TileTyps.white, Resources.Load<TileBase>);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
