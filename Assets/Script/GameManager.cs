using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI recordText;
    public GameObject UIMainMenuBtn;
    public AudioSource audioSource;
    private float songLength;
    private float songOver;
    
    public float Score;
    private bool isGameover;

    void Start()
    {
        Score = 0;
        isGameover = false;
        songLength = audioSource.clip.length;
        songOver = songLength + 2f;
    }

    void Update()
    {

        if (songLength >= songOver)
        {
            EndGame();
        }

        if (!isGameover)
        {
            recordText.text = "Score: " + (int)Score;
        }
    }

    public void EndGame()
    {
        isGameover = true;
        UIMainMenuBtn.SetActive(true);

    }
}
