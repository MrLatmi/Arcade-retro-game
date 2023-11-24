using UnityEngine;
using UnityEngine.SceneManagement;

public class looose : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Untagged"))
        {
            SceneManager.LoadScene("loooose");
        }
    }
}