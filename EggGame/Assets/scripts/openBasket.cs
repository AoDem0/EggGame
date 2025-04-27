using System.Collections;
using UnityEngine;

public class openBasket : MonoBehaviour
{
    [SerializeField] private GameObject basket;
    [SerializeField] private float openBasketTime = 1.5f;
    private bool notPressed = true;

    void Start()
    {
        basket.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown("e") && notPressed){
            StartCoroutine(openBasketForTime());
        }
    }

    private IEnumerator openBasketForTime(){
        notPressed = false;
        basket.SetActive(true);
        yield return new WaitForSeconds(openBasketTime);  
        basket.SetActive(false);
        notPressed = true;
    }
}
