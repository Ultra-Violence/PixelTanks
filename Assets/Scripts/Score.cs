using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private EnemySpawner enemySpawner;

    private int _score;
    public int score => _score;

    public void UpdateScore(){
        _score++;
        enemySpawner.minusEnemy();
    }
}
