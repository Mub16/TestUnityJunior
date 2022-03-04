using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    int hp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {          // при входе в триггер
    if(other.tag == "Player") {                  // если это наш триггер
    hp = PlayerPrefs.GetInt("life_indicators");
    hp--;
    PlayerPrefs.SetInt("life_indicators", hp);
    }           
}
}
