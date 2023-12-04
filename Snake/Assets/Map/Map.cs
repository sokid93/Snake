using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject tile;
    int verticalSize;
    int horizontalSize;

    void Start()
    {
        
    }

    public void InstantiateMapTiles()
    {
        for (int x = 0; x < verticalSize; x++)
        {
            for (int y = 0; y < horizontalSize; y++)
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

    public void SetMapSize(int newHeight, int newWidth)
    {
        verticalSize = newHeight;
        horizontalSize = newWidth;
    }
}
