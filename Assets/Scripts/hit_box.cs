using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_box : MonoBehaviour
{
    //ENUMY
    public GameObject wrug; //Здесь находится противник, можно записать что нибудь другое
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
    Destroy(wrug); //Уничтажение объекта
    } 
    }
}
