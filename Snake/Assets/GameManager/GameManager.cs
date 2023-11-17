using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    [SerializeField, Min(0)] int mapSize;
    int[,] _map;
    Map map;

    void Awake() {
        map = GetComponent<Map>();
        map.SetMapSize(mapSize, mapSize);
        map.InstantiateMapTiles();
    }


    void Update()
    {
        
    }
}
