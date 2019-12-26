using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    Rigidbody2D rigidbody2d;
    [SerializeField] int enemySpeed = 3;
    [SerializeField] Vector2 direction = new Vector2(1,0.2f);
    [SerializeField] int pontuation = 10;
    [SerializeField] int damage = 10;

    // Start is called before the first frame update
    void Start(){
        rigidbody2d = GetComponent<Rigidbody2D>();
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
                break;
            case "Bullet":
                GameManager.instance.PointCount(pontuation);
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
}
