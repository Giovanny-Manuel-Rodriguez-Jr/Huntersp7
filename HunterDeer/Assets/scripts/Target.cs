using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Target : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager")
            .GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {  if(gameManager.isGameActive)
        {
            Destroy(gameObject);
        }
    }

    private void OnTrigerEnter(Collider other)
    {
     
        Destroy(gameObject);
        if (!gameObject.CompareTag("Sensor"))
        {
            gameManager.GameOver();
        }
    }
}
