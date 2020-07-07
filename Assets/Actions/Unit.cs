using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public bool turn = false;
    public float halfHeight = 0;
    public GameObject[] tiles;
    public bool executeMove = false;

    //default unit stats
    public int health = 100;
    public int damage = 25;
    public int armor = 0;
    public int move = 5;
    public float jumpHeight = 2;
    public int attackRange = 1;

    protected void Init()
    {
        tiles = GameObject.FindGameObjectsWithTag("Tile");

        halfHeight = GetComponent<Collider>().bounds.extents.y;

        TurnManager.AddUnit(this);
    }

    public void Start () 
	{
        Init();
	}

    public void BeginTurn()
    {
        turn = true;
    }

    public void EndTurn()
    {
        turn = false;
    }
}
