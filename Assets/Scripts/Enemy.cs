using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    Rigidbody2D rigidbody2d;

    [SerializeField] Vector2 direction = new Vector2(1, 0.2f);
    public EnemyPreset preset;
    int pontuation;
    int damage;
    int enemySpeed;
    int life;

    // Start is called before the first frame update
    void Awake(){
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void ApplyConfig() {
        SpriteRenderer spriteRenderer;
        spriteRenderer = GetComponent<SpriteRenderer>();

        enemySpeed = preset.ReturnSpeed();
        damage = preset.ReturnDamage();
        pontuation = preset.ReturnPontuation();
        life = preset.ReturnLife();
        spriteRenderer.sprite = preset.ReturnSprite();
        spriteRenderer.color = preset.ReturnColor();
    }

    // Update is called once per frame
    void Update(){
        Movimentation();
    }

    void OnCollisionEnter2D(Collision2D collision){
        string tag = collision.gameObject.tag;
        switch (tag){
            case "Wall":
                ChangeDirection();
                break;
            case "Player":
                collision.gameObject.GetComponent<Player>().ApplyDamage(damage);
                Destroy(this.gameObject);
                break;
            case "Bullet":
                int bulletDamage = collision.gameObject.GetComponent<BulletBehaviour>().ReturnBulletDamage();
                ApplyDamage(bulletDamage);
                break;
            case "Finish":
                GameManager.instance.ReturnPlayer().GetComponent<Player>().ApplyDamage(damage);
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }

    void ChangeDirection() {
        direction = new Vector2(-direction.x,direction.y);
    }

    void Movimentation() {
        rigidbody2d.MovePosition(rigidbody2d.position - direction * enemySpeed * Time.fixedDeltaTime);
    }

    void ApplyDamage(int damage){
        life -= damage;
        if (life <= 0){
            CallPontuation();
            Destroy(this.gameObject);
        }
    }

    void CallPontuation() {
        GameManager.instance.ApplyPontuation(pontuation);
    }
}
