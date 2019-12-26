using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField] Transform shootPosition;
    [SerializeField] GameObject shootPrefab;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        LookToMouse();
        InputAction();
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

    void Shoot() {
        var bulltet = Instantiate(shootPrefab, shootPosition.position, Quaternion.identity);
        bulltet.transform.rotation = transform.rotation;
    }
}
