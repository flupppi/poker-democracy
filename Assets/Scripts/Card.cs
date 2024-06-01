using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum CardState
{
    Idle,
    Dragged,
    Dropped
}

public class Card : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private TMP_Text titleTextField;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text revenueText;
    [SerializeField] private TMP_Text minimumCostText;
    [SerializeField] private TMP_Text influenceText;
    [SerializeField] private CardState cardState;
    [SerializeField] private Player mostInfluencePlayer = null;




    public string cardTitle;
    public string cardDescription;
    public Sprite cardIcon;
    public int revenueIncrease;
    public int minimumCost;
    public int numberOfInfluence;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void InitCard()
    {
        titleTextField.text = cardTitle;
        descriptionText.text = cardDescription;
        revenueText.text = revenueIncrease.ToString();
        influenceText.text = numberOfInfluence.ToString();
        minimumCostText.text = minimumCost.ToString();
        icon.sprite = cardIcon;

    }
}
