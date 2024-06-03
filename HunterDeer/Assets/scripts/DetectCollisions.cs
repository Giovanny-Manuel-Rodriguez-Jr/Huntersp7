using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    public GameManager gameManager;
  
   




    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <-20)
        {
           
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
       
        Destroy(other.gameObject);

    }
}
