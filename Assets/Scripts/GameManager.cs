using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
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
    [SerializeField] int maxPopluationCount = 100;
    [SerializeField] GameObject voterParent;
    [SerializeField] TMP_Text player1VotersText;
    [SerializeField] TMP_Text player2VotersText;
    [SerializeField] TMP_Text neutralVotersText;
    [SerializeField] int neutralVoters = 100;
    [SerializeField] int player1Voters;
    [SerializeField] int player2Voters;
    [SerializeField] Button finishTurnButton;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }



    [SerializeField] private TMP_Text counterText;

    [SerializeField] private List<Player> players;

    [SerializeField] private GameObject voterPrefab;


    public TurnStates turnState;
    //public UnityEvent OnFinishRound;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnPopulation();
    }

    void SpawnPopulation()
    {
        for (int i = 0; i < maxPopluationCount; i++) {
            Instantiate(voterPrefab, voterParent.transform);
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        player1VotersText.text = player1Voters.ToString();
        player2VotersText.text = player2Voters.ToString();
        neutralVotersText.text = neutralVoters.ToString();


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
        counterText.text = counter.ToString();
    }

    void OnFinishBettingRound()
    {
        Debug.Log("Finished Betting Round");
        turnState = TurnStates.Voting;
        OnFinishVotingRound();
    }

    public void FinishTurn()
    {
        Debug.Log("Player Finished Turn");
    }



}
