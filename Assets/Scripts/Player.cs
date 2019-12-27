using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField] Transform shootPosition;
    [SerializeField] GameObject shootPrefab;
    Rigidbody2D rigidBody;
    bool canShoot = true;
    bool automaticMov = true;

    #region Atributes
    public bool movType = false;
    [SerializeField] int life = 100;
    [SerializeField] float shootRecoveryTime = 1.5f;
    #endregion

    // Start is called before the first frame update
    void Start(){
        GameManager.instance.LifeAtt(life);
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        if (!GameManager.instance.isPaused){
            if (movType)
                LookToMouse();
            else
                AutomaticMoviment();

            InputAction();
        }
    }

    void InputAction(){
        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }
    }

    void LookToMouse() {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = lookDirection;
    }

    void AutomaticMoviment() {
        if (rigidBody.rotation > 90){
            automaticMov = true;
        }
        else if(rigidBody.rotation < -90){
            automaticMov = false;
        }

        if (automaticMov){
            rigidBody.rotation -= 1;
        }
        else{
            rigidBody.rotation += 1;
        }
    }

    void Shoot(){
        if (canShoot){
            var bulltet = Instantiate(shootPrefab, shootPosition.position, Quaternion.identity);
            bulltet.transform.rotation = transform.rotation;
            Invoke("ShootRecover", shootRecoveryTime);
            canShoot = false;
        }    
    }

    void ShootRecover() {
        canShoot = true;
    }

    public void ApplyDamage(int damage) {
        if (damage < life){
            life -= damage;
            GameManager.instance.LifeAtt(life);
        }
        else{
            life = 0;
            GameManager.instance.LifeAtt(life);
            GameManager.instance.PlayerIsDead();
        }
    }

    public void ToggleMovType() {
        movType = !movType;
    }

}
