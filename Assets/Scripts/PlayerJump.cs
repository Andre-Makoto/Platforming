using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Jump config")]
    public float jumpForce = 300;
    public Rigidbody rigidBody;
    public Transform groundCheck;
    public float groundCheckRadious = 0.2f;
    public LayerMask groundLayer;

    bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadious, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidBody.AddForce(Vector3.up * jumpForce);
        }
        // Debug.Log(isGrounded);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground") 
        {
            Debug.Log("I stepped on somenthing!");
        }
    }
}
