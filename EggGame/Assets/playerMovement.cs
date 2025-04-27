using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 2f;
    private Vector2 vec;

    void Update()
    {
        vec.x = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + vec * speed * Time.fixedDeltaTime);
    }
}
