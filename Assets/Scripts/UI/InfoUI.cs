using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    [SerializeField] private Text healthTextUI;
    [SerializeField] private Text enemysTextUI;
    [SerializeField] private EnemySpawner enemySpawner;
    [SerializeField] private StatsUnit player;

    public void Update(){
        healthTextUI.text = " -  " + player.health.ToString();
        enemysTextUI.text = " -  " + enemySpawner.currentEnemys.ToString();
    }
    
}
