using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPanel : MonoBehaviour


{
    void Start(){
    }
    public void ExecutePlayerMove(){
        gameObject.GetComponent<PlayerMove>().enabled=true;
    }


}
