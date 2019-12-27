using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    public static GameManager instance;
    public bool isPaused;
    bool gameOver = false;
    [SerializeField] Canvas gameOverCanvas;
    #region Time Points And Life
    int points = 0;
    float pastTime = 0;
    [SerializeField] Text pointsTXT;
    [SerializeField] Text timeTXT;
    [SerializeField] Text lifeTXT;
    [SerializeField] Image lifeBar;
    #endregion

    [SerializeField] GameObject playerReference;

    void Awake(){
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start(){
        ApplyPontuation(0);
        PauseGame(true);
        gameOverCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update(){
        TimeCount();
    }

    public void PlayerIsDead() {
        GameOver();
    }

    public void ApplyPontuation(int pontuation) {
        points += pontuation;
        pointsTXT.text = ("Pontuação: " + points.ToString());
    }

    void TimeCount() {
        pastTime += Time.deltaTime;
        timeTXT.text = ("Tempo: " + Mathf.Round(pastTime).ToString());
    }

    public void LifeAtt(float life){
        lifeTXT.text = life.ToString();
        life = life / 100;
        lifeBar.fillAmount = life;
    }

    public GameObject ReturnPlayer() {
        return playerReference;
    }

    public void ToggleMovimentationType() {
        playerReference.GetComponent<Player>().ToggleMovType();
    }

    public void PauseGame(bool isPaused) {
        if (!gameOver){
            if (isPaused){
                Time.timeScale = 0;
                this.isPaused = true;
            }
            else{
                Time.timeScale = 1;
                this.isPaused = false;
            }
        }
        else{
            Time.timeScale = 0;
        }
    }

    void GameOver() {
        gameOverCanvas.enabled = true;
        gameOver = true;
        PauseGame(true);
    }
}
