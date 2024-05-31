using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardState
{
    Idle,
    Dragged,
    Dropped
}

public class Card : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private CardState cardState;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
