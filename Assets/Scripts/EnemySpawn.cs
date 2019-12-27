using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour{
    [SerializeField] EnemyPreset[] enemyPreset;
    [SerializeField] GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start(){
        TimeToSpawn();
    }

    void SpawnNewEnemy() {
        TimeToSpawn();

        var enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        int enemyPresetNum = Random.Range(0, enemyPreset.Length);
        enemy.GetComponent<Enemy>().preset = enemyPreset[enemyPresetNum];
        enemy.GetComponent<Enemy>().ApplyConfig();
    }

    void TimeToSpawn() {
        float time = Random.Range(1,4);
        Invoke("SpawnNewEnemy", time);
    }
}
