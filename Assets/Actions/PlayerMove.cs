using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : TacticsMove 
{
	
	// Update is called once per frame

	void Update () 
	{
        Debug.DrawRay(transform.position, transform.forward);
        
        if (!turn)
        {
            return;
        }

        if (!moving)
        {
            if (executeMove){
                Debug.Log("executeMove is True");
                FindSelectableTiles();
                CheckMousetoMove();
            }
        }
        else
        {
            Move();
            
        }
        
	}

    void CheckMousetoMove()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();

                    if (t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }

    void CheckMousetoAttack()
    {
        return;
    }
}
