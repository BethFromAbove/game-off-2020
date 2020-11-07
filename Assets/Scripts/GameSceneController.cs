using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public int canvasSize;
    public GameObject cellPrefab;

    int determineCellCount(float cellScale) {
        return (int) Math.Ceiling(canvasSize / cellScale);
    }

    void Start()
    {
        // Determine the sizes and ofssets of the cells
        float cellScale = cellPrefab.transform.localScale.x;
        int cellCount = determineCellCount(cellScale);
        float offsetX = - (canvasSize / 2) + (cellScale / 2);
        float offsetY = - (canvasSize / 2) + (cellScale / 2);

        // Create all the required cells
        for (int i = 0; i < cellCount; i++) {
            for (int j = 0; j < cellCount; j++) {
                float x = offsetX + (i * cellScale);
                float y = offsetY + (j * cellScale);
                Vector3 pos = new Vector3(x, y, 0);
                
                Instantiate(cellPrefab, pos, Quaternion.identity);
            }
        }
    }
}
