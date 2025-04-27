using TMPro;
using UnityEngine;

public class scoreMan : MonoBehaviour
{
    [SerializeField] private int playerHp = 3;
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshPro scoreText;

    void Start()
    {
        score = 0;
    }


    /*public GameEvents gameEvents;
    private int coinCount = 0;

    private void OnEnable()
    {
        gameEvents.OnCoinCollected += AddCoin;
    }

    private void OnDisable()
    {
        gameEvents.OnCoinCollected -= AddCoin;
    }

    private void AddCoin()
    {
        coinCount++;
        Debug.Log("Zebrano monetę! Liczba monet: " + coinCount);
    }*/

}
