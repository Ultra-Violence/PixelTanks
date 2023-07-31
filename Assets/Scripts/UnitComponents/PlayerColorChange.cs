using UnityEngine;

public class PlayerColorChange : MonoBehaviour
{
    [SerializeField] private EnemySpawner enemySpawner;

    private void Update() {
        GetComponent<SpriteRenderer>().color = new Color(enemySpawner.currentEnemys*0.1f, 0, 0, 1);
    }
}
