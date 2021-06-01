
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mazer"))
        {
            SceneManager.LoadScene("menu");
            Debug.Log("hi");
        }

    }
}
