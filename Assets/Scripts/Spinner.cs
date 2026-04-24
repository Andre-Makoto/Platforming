using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.5f;
    [SerializeField] float zValue = 0f;
    [SerializeField] float force = 50f;
    Rigidbody playerRigidBody;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Player") 
        {
            playerRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidBody != null) 
            {
                Vector3 direction = (collision.transform.position - transform.position).normalized;
                playerRigidBody.AddForce(direction * force, ForceMode.Impulse);
            }
        
        }
    }
}
