using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreMan : MonoBehaviour
{
    [SerializeField] private int playerHp = 3;
    public int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;


    public Image[] pasekSerc;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
     void Update()
    {

        for (int i = 0; i < pasekSerc.Length; i++)
        {
            if(i < playerHp ){
                pasekSerc[i].enabled = true;
            }
            else{
                pasekSerc[i].enabled = false;
            }
        }
    }

    private void OnEnable()
    {
        eventHolder.OnEggPick += AddScore;
        eventHolder.OnPoopPick += healthLost;
    }

    private void OnDisable()
    {
        eventHolder.OnEggPick -= AddScore;
        eventHolder.OnPoopPick -= healthLost;
    }

    private void AddScore(int points)
    {
        score = score + points;
        scoreText.text = score.ToString();
        
    }

    private void healthLost(){
        playerHp--;
    }

}
