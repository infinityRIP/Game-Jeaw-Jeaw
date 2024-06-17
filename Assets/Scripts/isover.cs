// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;
// using UnityEngine.SceneManagement;


// public class isover : MonoBehaviour
// {
//     public Merg Merg;
//     private string Check = "n";
//     public string sceneName;
//     void Update()
//     {
//      if(Input.GetKeyDown("space"))
//         {
//             StartCoroutine(chkGameOver());
//         }
//     }
    
//     IEnumerator chkGameOver()
//     {
//         yield return new WaitForSeconds(5f);
//         Check = "y";
//     }

//     void OnTriggerStay2D(Collider2D other)
//     {
//         if ((Check=="y")) 
//         {
//             SceneManager.LoadScene(sceneName);
//             Debug.Log("game over");
//         }
//     }
// }