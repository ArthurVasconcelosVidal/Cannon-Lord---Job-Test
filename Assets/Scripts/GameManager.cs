using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    public static GameManager instance;

    #region Time Points And Life
    int points = 0;
    float pastTime = 0;
    [SerializeField] Text pointsTXT;
    [SerializeField] Text timeTXT;
    [SerializeField] Text lifeTXT;
    [SerializeField] Image lifeBar;
    #endregion

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
        PointCount(0);
    }

    // Update is called once per frame
    void Update(){
        TimeCount();
    }

    public void PlayerIsDead() {
        //DoSomething
    }

    public void PointCount(int pontuation) {
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
}
