using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    [SerializeField, Min(0)] int mapSize;
    int[,] _map;
    Map map = new Map();
    SnakeGrid grid = new SnakeGrid();
    [SerializeField] GameObject tile;

    void Awake() {
        
    }

    private void InstantiateMapTiles()
    {
        for (int x = 0; x < grid.height; x++)
        {
            for (int y = 0; y < grid.width; y++)
            {
                InstantiateTile(x, y);
            }
        }
    }

    private void InstantiateTile(int x, int y)
    {
        var worldPosition = new Vector3(x, y, 0);
        Instantiate(tile, worldPosition, Quaternion.identity, this.transform);
    }

    void Update()
    {
        
    }
}
