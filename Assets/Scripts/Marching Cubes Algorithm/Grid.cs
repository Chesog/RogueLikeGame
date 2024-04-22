using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private GameObject gridPoint;
    [SerializeField] private Vector3 gridSize = new Vector3(10,1,10);
    [SerializeField] private Vector3 offsetBetweenPoints = new Vector3(10,1,10);

    private void Start()
    {
        for (int z = 0; z < gridSize.z; z++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int x = 0; x < gridSize.x; x++)
                {
                   GameObject aux = Instantiate(gridPoint,transform);
                   aux.transform.position = new Vector3(x * offsetBetweenPoints.x, y * offsetBetweenPoints.y, z * offsetBetweenPoints.z);
                }
            }
        }
    }
}
