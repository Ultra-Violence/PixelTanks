using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject enemyPref;
    [SerializeField] private int maxEnemys;
    
    private int _currentEnemys;
    public int currentEnemys => _currentEnemys;
    private int aliveEnemys = 0;
    private int maxAliveEnemys;

    [SerializeField] private List<Transform> enemySpawns;
    [SerializeField] private List<GameObject> enemyPrefs;

    private void Start() {
        Time.timeScale = 1;
        _currentEnemys = maxEnemys;
        StartCoroutine(enemySpawnCoroutine());
    }

    private void Update() {
        if(_currentEnemys <= 0){
            Menu.SetActive(true);
            Menu.GetComponent<Menu>().End("You Win!");
        }

        maxAliveEnemys = _currentEnemys;
        maxAliveEnemys = Mathf.Clamp(maxAliveEnemys, 0, 3);
    }

    IEnumerator enemySpawnCoroutine(){
        yield return new WaitForSeconds(5f);
        for (; aliveEnemys < maxAliveEnemys && _currentEnemys > 0;)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(enemyPrefs[Random.Range(0, enemyPrefs.Count)], enemySpawns[Random.Range(0, enemySpawns.Count)].position, Quaternion.identity);
            aliveEnemys++;
        }
        StartCoroutine(enemySpawnCoroutine());
    }

    public void minusEnemy(){
        _currentEnemys--;
        aliveEnemys--;
    }
}
