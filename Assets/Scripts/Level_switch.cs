using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_switch : MonoBehaviour
{
    public int level_number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void switch_level(){
        print("test");
        Application.LoadLevel(level_number);
    }
}
