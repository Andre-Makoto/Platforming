using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            for (int i = 0; i < projectile.Length; i++) 
            {
                projectile[i].SetActive(true);
            }
        }    
    }
}
