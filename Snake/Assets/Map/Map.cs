using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    SnakeGrid grid;
    [SerializeField] GameObject tile;

    void Start()
    {
        grid.InitializeMap(10, 10);
        for(int x=0; x < grid.height; x++)
        {
            for(int y=0;y<grid.width; y++)
            {
                InstantiateTile(x, y);
            }
        }
    }

    private void InstantiateTile(int x, int y)
    {
        var worldPosition = new Vector3(x, y, 0);
        Instantiate(tile, worldPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
