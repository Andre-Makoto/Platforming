using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject winText;

    void Start()
    {
        winText.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.Win();
            // winText.SetActive(true);
            // Debug.Log("You win!");
        }
    }
}
