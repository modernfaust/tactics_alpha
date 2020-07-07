using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsPanel : MonoBehaviour
{
    // Update is called once per frame

    public Button MoveButton;

    public void AllowMove()
    {
        Debug.Log("this works!");
        gameObject.GetComponent<PlayerMove>().executeMove = true;
    }
}
