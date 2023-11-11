using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGrid
{
    int height;
    int width;
    int [,] mapArray;

    public void MapConstructor(int height, int width)
    {
        this.height = height;
        this.width = width;

        mapArray = new int[height, width];

        for(int x=0; x < height; x++) {
            for(int y = 0; y < width; y++) {
                CreateTile(x,y);
            }
        }
    }

    void CreateTile(int x, int y)
    {
        GameObject.Instantiate(new GameObject(), new Vector3(x, y, 0), Quaternion.identity);
    }
}
