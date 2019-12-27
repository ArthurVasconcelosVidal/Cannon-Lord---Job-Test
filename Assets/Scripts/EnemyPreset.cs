using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Enemy Preset", menuName = "Enemy Preset")]
public class EnemyPreset : ScriptableObject{

    [SerializeField] int life;
    [SerializeField] int speed;
    [SerializeField] Sprite enemySprite;
    [SerializeField] int damage;
    [SerializeField] int pontuation;
    [SerializeField] Color color;

    public int ReturnLife() {
        return life;
    }

    public int ReturnSpeed() {
        return speed;
    }

    public Sprite ReturnSprite() {
        return enemySprite;
    }

    public int ReturnDamage() {
        return damage;
    }

    public int ReturnPontuation() {
        return pontuation;
    }

    public Color ReturnColor() {
        return color;
    }
}
