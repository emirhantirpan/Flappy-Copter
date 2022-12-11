using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class UI_Manager : MonoBehaviour
{
    public Player player;
    public GameObject gameOver;
    public GameObject tapHand;
    public GameObject tap;
    public int score;
    public TextMeshProUGUI text;
    
    private void Awake()
    {
        Application.targetFrameRate = 60;

        
    }
    public void IncreaseScore()
    {
        score++;
        text.text = score.ToString();
    }
}
