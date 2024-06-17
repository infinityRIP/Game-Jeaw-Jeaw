using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnTag : MonoBehaviour

{
     private float timer;
    // Define the tag you want to trigger the scene change
     public string targetTag = "2";
    
    // Define the scene name you want to change to
    public string sceneToLoad = "YourSceneName";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering object has the specified tag
        if (other.CompareTag(targetTag))
        {
            Time.timeScale = 0;
            // Load the new scene
            Debug.Log("Object with tag " + targetTag + " entered trigger zone.");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
