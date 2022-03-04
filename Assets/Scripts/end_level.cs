using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {          // при входе в триггер
    if(other.tag == "Player") {                  // если это наш триггер
    Application.LoadLevel(0);
    } 
    }
}
