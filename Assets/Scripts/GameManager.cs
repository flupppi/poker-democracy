using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public enum TurnStates
{
    Betting,
    Voting
}
public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerCount = 1;
    [SerializeField] private int counter = 0;
    [SerializeField] private int maxRounds = 11;
    [SerializeField] float bettingTime = 3.0f;
    [SerializeField] float votingTime = 1.0f;

    public TurnStates turnState;
    //public UnityEvent OnFinishRound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((bettingTime - Time.deltaTime) > 0.0f)
        {
            bettingTime = bettingTime - Time.deltaTime;
        }
        else
        {
            if (counter < maxRounds)
            {
                OnFinishBettingRound();

            }
            else { OnFinishGame(); }

        }
    }

    private void OnFinishGame()
    {
        Debug.Log("Game Finished");
    }

    void OnFinishVotingRound()
    {
        turnState = TurnStates.Betting;
        Debug.Log("Finished Voting Round");
        bettingTime = 3.0f;
        counter++;
    }
    void OnFinishBettingRound()
    {
        Debug.Log("Finished Betting Round");
        turnState = TurnStates.Voting;
        OnFinishVotingRound();

    }
}
