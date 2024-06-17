using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Merg : MonoBehaviour
{ 
    public string sceneName;
    public AudioSource Source;
    private string inthecloud = "y";
    private string Check = "n";

    void Start()
    {
        
        if (transform.position.y<3.5)
        {
            inthecloud = "n";
        }
    }
        public void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name=="border") && (Check=="y"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    void Update()

    {
        
        if (inthecloud=="y")
        {
            GetComponent<Transform>().position = Move.cloudxPos;
            
        }

        if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            inthecloud = "n";
            StartCoroutine(chkGameOver());
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        
        if (collision.gameObject.tag==gameObject.tag)
        {
            
            Move.spawnPos = transform.position;
            Move.newObj = "y";
            Move.whichObj = int.Parse(gameObject.tag);
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag==gameObject.tag)
        {
            Source.Play();
        }
       
    }



    IEnumerator chkGameOver()
    {
        yield return new WaitForSeconds(2f);
        Check = "y";
    }
}
