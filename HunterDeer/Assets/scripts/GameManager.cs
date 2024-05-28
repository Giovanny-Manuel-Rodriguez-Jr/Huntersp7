using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    

  
    
    public bool isGameActive;
    private int index;
    private float spawnRate;

    

    public object targets { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnTarget(GetIndex()));
      
        
        


        isGameActive = true;
    }

    // Update is called once per frame
  
   
  

    public void GameOver()
    {
        
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

    private void gameOver()
    {
       
        isGameActive = false;
    }
}
