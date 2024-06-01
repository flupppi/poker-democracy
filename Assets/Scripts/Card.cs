using System;
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
    [SerializeField] public Color color;
    public Color selectColor;
    [SerializeField] private TMP_Text titleTextField;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text revenueText;
    [SerializeField] private TMP_Text minimumCostText;
    [SerializeField] private TMP_Text influenceText;
    [SerializeField] private CardState cardState;
    [SerializeField] private Player mostInfluencePlayer = null;
    [SerializeField] public MeshRenderer meshRenderer;
    [SerializeField] private TMP_Text bet_player1;
    [SerializeField] private TMP_Text bet_player2;
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
        meshRenderer.material.color = color;
    }
    public void ChangeColor(bool selected)
    {
        if (selected) {
            meshRenderer.material.color = selectColor;
        }
        else
        {
            meshRenderer.material.color = color;
        }
    }

    internal void RaiseCard(bool v)
    {
        float raiseAmount;
        if (v)
        {
            raiseAmount = 1.0f;
        }
        else
        {
            raiseAmount = 0.0f;
        }
        Vector3 currentPos = transform.position;
        currentPos.y = raiseAmount;
        transform.position = currentPos;

    }

}
