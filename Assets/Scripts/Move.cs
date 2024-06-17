using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
     
     public Transform[] Object;
     static public string spawnedYet = "n";
     static public Vector2 cloudxPos;
     static public Vector2 spawnPos;
     static public string newObj="n";
     static public int whichObj = 0;
     public AudioSource Drop;
    void Start()
    {
        
    }
    void Update()
    {
        spawnObj();
        replaceObj();

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-10,0);
        }

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(10,0);
        }
        
        if ((!Input.GetKey("a")) && (!Input.GetKey("d")))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
        
        if ((GetComponent<Rigidbody2D>().velocity.x < 0) && (transform.position.x < -10))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        if ((GetComponent<Rigidbody2D>().velocity.x > 0) && (transform.position.x > 10))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }



        cloudxPos = transform.position;
        if ((Input.GetKeyDown("space")) && (spawnedYet=="y"))
        {
            spawnedYet = "n";
            Drop.Play();
        }
        
    }

    void spawnObj()
    {
        if (spawnedYet=="n")
        {
            StartCoroutine(spawntimer());
            spawnedYet = "w";

        }
    }

    void replaceObj()
    {
        if (newObj == "y")
        {
            newObj = "n";
            Instantiate(Object[whichObj+1], spawnPos, Object[0].rotation);
        }
    }

    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        Instantiate(Object[0], transform.position, Object[0].rotation);
        spawnedYet = "y";
    }
}
