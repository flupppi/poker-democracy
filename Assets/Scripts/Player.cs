using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private string playerName = "Player1";
    [SerializeField] private TMP_Text playerTitle;
    [SerializeField] private Image playerIcon;
    [SerializeField] public TMP_Text bankText;
    [SerializeField] public int bankAmount;

    [SerializeField] public TMP_Text scoreText;
    [SerializeField] public int score;
    [SerializeField] public TMP_Text revenueText;
    [SerializeField] public int revenue;

    [SerializeField] public TMP_Text betText;
    [SerializeField] public int bet;

    [SerializeField] public Button placeButton;
    [SerializeField] public Button incrementButton;
    [SerializeField] public Button decrementButton;



    
    public void IncrementBetAmount()
    {
        if (bet < bankAmount) {
            bet++;
        }

    
    }
    public void DecrementBetAmount()
    {
        if (bet > 0)
        {
            bet--;
        }
    }

    public void PlaceBet()
    {
        Debug.Log("Bet has been Placed");
    }


    void Start()
    {
        playerTitle.text = playerName;
    }

    void Update()
    {
        betText.text = bet.ToString();
        scoreText.text = score.ToString();
        bankText.text = bankAmount.ToString();
        revenueText.text = revenue.ToString();

    }
}
