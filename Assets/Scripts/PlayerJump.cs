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

    void Start()
    {

    }

    void Update()
    {
        // Physics.CheckSphere retorna true or false e guarda na variavel isGrounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadious, groundLayer);
        // Verifica se foi pressionado o "space" e se o player esta no chão.
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidBody.AddForce(Vector3.up * jumpForce);
        }
        // Debug.Log(isGrounded);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground") 
        {
            // Debug.Log("I stepped on somenthing!");
        }
    }
}
