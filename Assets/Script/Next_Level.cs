using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next_Level : MonoBehaviour
{
    GameObject player;
    //public GameObject Next_Level_Pannel;
    public Animator transition;
    public string name;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player") ;
        {
          
            loadnext();
        }
    }
    public void loadnext()
    {

        StartCoroutine(loadLevel());
    }
    IEnumerator loadLevel() 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(name);
    }
}
