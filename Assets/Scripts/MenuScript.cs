using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour{

    [SerializeField] Button playBT;
    [SerializeField] Text playTXT;
    bool play = false;
    [SerializeField] Button toggleMovBT;
    [SerializeField] Button reset;

    public void PlayButton() {
        if (play){
            GameManager.instance.PauseGame(true);
            playTXT.text = "Play";
            play = false;
        }
        else{
            GameManager.instance.PauseGame(false);
            playTXT.text = "Pause";
            play = true;
        }
    }

    public void ToggleMov() {
        GameManager.instance.ToggleMovimentationType();
    }

    public void Reset(){
        SceneManager.LoadScene("SampleScene");
    }
}
