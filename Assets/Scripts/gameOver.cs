using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    private bool gameIsOver = false;
    private bool levelCompleted = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameIsOver==true || transform.position.y < 1.9) SceneManager.LoadScene("gameOver");

        else if (levelCompleted ==true) SceneManager.LoadScene("levelComplete");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {

            gameIsOver = true;
            
             


        }

        if(collision.gameObject.tag == "levelComplete")
        {

            levelCompleted = true;

        }
    }

  
}
