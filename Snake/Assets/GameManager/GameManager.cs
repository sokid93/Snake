using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    [SerializeField, Min(0)] int mapSize;
    int[,] _map;
    
    void Awake() {
        _map = new int[mapSize, mapSize];
    }

    void Update()
    {
        
    }
}
