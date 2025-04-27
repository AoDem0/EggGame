using UnityEngine;

public class poopScript : MonoBehaviour
{
    [SerializeField] private eventHolder events;

    [SerializeField]private Transform pos;

     void Start()
    {
        events = FindAnyObjectByType<eventHolder>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("basket")){
            events.PoopPick();
        }
    }

    void Update()
    {
        if(pos.position.y >= -10){
            Destroy(gameObject);
        }
    }
}
