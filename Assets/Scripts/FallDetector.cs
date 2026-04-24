using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public GameObject loseText;

    void Start()
    {
        loseText.SetActive(false);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            loseText.SetActive(true);
            // Debug.Log("You Lose!");
        }    
    }
}
