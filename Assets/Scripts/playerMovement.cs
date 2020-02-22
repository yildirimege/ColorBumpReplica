using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position += player.transform.forward * Time.deltaTime * speed;
        

        if(Input.GetKey("left"))
        {
            player.transform.position += -transform.right * Time.deltaTime * speed;


        }

        if(Input.GetKey("right"))
        {

            player.transform.position += transform.right * Time.deltaTime * speed;

        }

        
    }
}
