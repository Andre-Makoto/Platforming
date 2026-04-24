using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public GameObject winText;

    void Start()
    {
        winText.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            winText.SetActive(true);
            // Debug.Log("You win!");
        }
    }
}
