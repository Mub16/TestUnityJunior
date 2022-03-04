using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp_position_x = 0;
    public int hp_position_y = 0;
    int hp = 3;
    int timer_control = 300;
//Object
    public Rigidbody2D prayer_rb;
//Audio
    public AudioClip jumpAudio;
    void control_hp(){ //Контроль hp
        if (hp>=3){

        }
        else if(hp<=0){
            Application.LoadLevel(1);
        }
        else{
            
        }
    }
    void controler(){ //Контроль персонажа игроком
        if (Input.GetKeyDown(KeyCode.Space) && timer_control==0){
            prayer_rb.AddForce(Vector2.up * 1150);
            //print(jumpAudio);
            GetComponent<AudioSource>().PlayOneShot(jumpAudio);
            timer_control=255;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            prayer_rb.AddForce(Vector2.right * 10);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            prayer_rb.AddForce(Vector2.left * 10);
            //transform.localScale=Vector2(-1,1);
        }
        else{

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
        PlayerPrefs.SetInt("life_indicators", hp);
    }

    // Update is called once per frame
    void Update()
    {
        control_hp();
        controler();
        hp = PlayerPrefs.GetInt("life_indicators");
        timer_control--;
        if(timer_control<0){
            timer_control=0;
        }
    }
    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(hp_position_x, hp_position_y, 1000000, 1000000), $"<size=64> ♥{hp}</size>");
    }
}
