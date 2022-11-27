using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Next_MainLevel : MonoBehaviour
{
    GameObject player;
    public GameObject Next_Level_Pannel;
    
    void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player") ;
        {
             Next_Level_Pannel.SetActive(true);
             Destroy(player);
          
        }
    }
   
}
