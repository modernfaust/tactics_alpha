using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : Actions
{
    void Attack()
    {
        GetCurrentTile();
        ComputeAdjacencyLists(jumpHeight,null);
    }

    void FindSelectableTiles()
    {
        //need to write a general function to find suitable tiles for combat
        //perform BFS for combat
        ComputeAdjacencyLists(jumpHeight, null);
        GetCurrentTile();

        Queue<Tile> process = new Queue<Tile>();

        process.Enqueue(currentTile);
        currentTile.visited = true;

        while (process.Count > 0)
        {
            Tile t = process.Dequeue();

            selectableTiles.Add(t);
            t.selectable = true;

            if (t.distance < move)
            {
                foreach (Tile tile in t.adjacencyList)
                {
                    if (!tile.visited)
                    {
                        tile.parent = t;
                        tile.visited = true;
                        tile.distance = 1 + t.distance;
                        process.Enqueue(tile);
                    }
                }
            }
        }
    }
    
    
}
