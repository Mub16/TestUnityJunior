using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meny : MonoBehaviour
{
    //string jump;
    //string left;
    //string right;
    // Start is called before the first frame update
    public GameObject Gobject;
    bool show_write = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void update_setting(){
        //PlayerPrefs.SetInt("jump", jump);
        //PlayerPrefs.SetInt("left", left);
        //PlayerPrefs.SetInt("left", right);
    }
    public void play(){

    }
    public void exit(){ //Выход из игры
        Application.Quit ();
    }
    public void writelen(){ //Отображение скрытых элементов/Или скрыть
        if (show_write == true){
        Gobject.SetActive (show_write);
        show_write = false;
        }
        else{
        Gobject.SetActive (false);
        show_write = true;
        }
    }
}
