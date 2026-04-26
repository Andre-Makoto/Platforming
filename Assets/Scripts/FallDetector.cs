using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject loseText;

    void Start()
    {
        loseText.SetActive(false);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            gameManager.Lose();
            // loseText.SetActive(true);
            // Debug.Log("You Lose!");
        }    
    }
}
