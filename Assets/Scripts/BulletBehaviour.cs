using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour{
    [SerializeField] int bulletSpeed = 3;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        BulletMovimentation();
    }

    void OnCollisionEnter2D(Collision2D collision){
        Destroy(this.gameObject);
    }

    void BulletMovimentation() {
        transform.position = transform.position + transform.up * bulletSpeed * Time.fixedDeltaTime;
    }
}
