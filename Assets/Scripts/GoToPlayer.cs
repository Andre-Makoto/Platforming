using UnityEngine;

public class GoToPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float force = 50f;
    [SerializeField] float moveSpeed = 12.5f;
    Vector3 playerPosition;
    Rigidbody playerRigidBody;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

        private void OnCollisionEnter(Collision collision) 
    {
        // Verifica se o gameObject que colidiu tem a tag player.
        if (collision.gameObject.tag == "Player") 
        {
            // Pega o rigidBody do player
            playerRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidBody != null) 
            {
                Vector3 direction = (collision.transform.position - transform.position).normalized;
                playerRigidBody.AddForce(direction * force, ForceMode.Impulse);
            }
        }
    }
    // Metodo que verifica se o projetil chegou no destino, e caso tenha chegado se autodestroi.
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
    // Metodo que pega a posição do projetil e se movimenta até o playerPosition
    // MoveTowards funciona com 3 inputs, current (posição inicial), target (posição final) e maxDistanceDelta (velocidade de movimentação)
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed * Time.deltaTime);
    }
}
