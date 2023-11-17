using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    [SerializeField, Min(0)] int mapSize;
    Map map;

    void Awake() 
    {
        map = GetComponent<Map>();
    }

    private void Start()
    {
        map.SetMapSize(mapSize, mapSize);
        map.InstantiateMapTiles();
    }


    void Update()
    {
        
    }
}
