using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGrid
{
    [field: SerializeField] public int height { get; private set; }
    [field: SerializeField] public int width { get; private set; }
    [field: SerializeField] public int[,] mapArray { get; private set; }

    public void MapInitialize(int height, int width)
    {
        this.height = height;
        this.width = width;

        mapArray = new int[height, width];
    }
}
