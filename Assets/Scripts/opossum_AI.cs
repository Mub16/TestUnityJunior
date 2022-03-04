using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opossum_AI : MonoBehaviour
{
    //float
    public float speed;
    public int max;
    private int stop_max;
    //Object
    public Rigidbody2D opossum;
    // Start is called before the first frame update
    void Start()
    {
        stop_max = max;
        max=0;
        opossum.AddForce(Vector2.up * 100);
    }
    void zeroUpdate(){ //Функция для зброса на ноль счётчика
        if(max > stop_max*2){
            max=0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        max++;
        if(max < stop_max){
            opossum.AddForce(Vector2.right * speed);
            zeroUpdate();
        }
        if(max > stop_max){
            opossum.AddForce(Vector2.left * speed);
            zeroUpdate();
        }
        else{

        }
    }
}
