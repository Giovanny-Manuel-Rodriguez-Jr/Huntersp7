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

    

   

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnTarget(GetIndex()));
      
        

        isGameActive = true;
    }

    // Update is called once per frame
  
   
  

    public void GameOver()
    {
         isGameActive=false;
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

   
}
