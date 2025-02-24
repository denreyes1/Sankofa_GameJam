using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = ""; // Set in Inspector or change manually

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && sceneToLoad != "") // Make sure your Player has the "Player" tag
        {
            SceneManager.LoadScene(sceneToLoad); // Load the assigned scene
        }
    }
}
