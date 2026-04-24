using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Jump config")]
    public float jumpForce = 300;
    public Rigidbody rigidBody;
    public Transform groundCheck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * jumpForce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") 
        {
            Debug.Log("I stepped on somenthing!");
        }
    }
}
