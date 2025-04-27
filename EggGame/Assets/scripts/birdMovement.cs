using Unity.VisualScripting;
using UnityEngine;

public class birdMovement : MonoBehaviour
{
    [SerializeField] private Transform birdTransform;
    [SerializeField] private Vector2 movementDirection;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private eventHolder events;
    [SerializeField] private float speed;
    public float lootSpawnPosition;

    private bool canSpawn = true;
    void Start()
    {   
        events = FindAnyObjectByType<eventHolder>();
        speed = Random.Range(2f, 4f);
        lootSpawnPosition = Random.Range(-10.3f, 10.4f);
        if(birdTransform.position.x > 0){
            movementDirection = new Vector2(-1, 0);
        }
        else{
            movementDirection = new Vector2(1, 0);
        }
    }
    void Update()
    {
        if(Mathf.Abs(birdTransform.position.x - lootSpawnPosition) < 0.1f && canSpawn){
            canSpawn = false;
            events.SendPosition(birdTransform.position);
        }
        if(birdTransform.position.x < -20 || birdTransform.position.x > 20){
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementDirection * speed * Time.fixedDeltaTime);
    }


}
