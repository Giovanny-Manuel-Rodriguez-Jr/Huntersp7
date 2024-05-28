using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    private int index;
    private float spawnRate;

    public object targets { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget(GetIndex()));
        score = 0;
        UpdateScore(0);


        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score;
    }

    private int GetIndex()
    {
        return index;
    }

    IEnumerator SpawnTarget(int index)
    {
       while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            // Instantiate(targets[Index]);

           
        }

    }

    private void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
}
