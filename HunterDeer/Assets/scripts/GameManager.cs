using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{

    public GameObject pauseScreen;
    private bool paused;

    public bool isGameActive;
    private int index;
    private float spawnRate;
    public TextMeshProUGUI gameOverText;
   

   
    

   

    // Start is called before the first frame update
    void Start()
    {
      
        StartCoroutine(SpawnTarget(GetIndex()));
        gameOverText.gameObject.SetActive(true);
        
       
    }

    

    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            ChangePaused();
        }
        

    }
    
    // Update is called once per frame




    public void GameOver()
    {
        isGameActive = false;
    }

    private int GetIndex()
    {
        return index;
    }

    IEnumerator SpawnTarget(int index)
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
           // int index = Random.Range(0, targets.Count);
           // Instantiate(targets[Index]);
        }

    }

    public void ResartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
