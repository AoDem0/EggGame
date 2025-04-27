using UnityEngine;

public class eggScript : MonoBehaviour
{
    [SerializeField] private eventHolder events;
    [SerializeField] private int eggPoints;
    [SerializeField]private Transform pos;
     void Start()
    {
        events = FindAnyObjectByType<eventHolder>();
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("basket")){
            events.EggPick(eggPoints);
        }
    }

    void Update()
    {
        if(pos.position.y >= -10){
            Destroy(gameObject);
        }
    }
}
