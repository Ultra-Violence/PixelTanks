using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUI : MonoBehaviour
{
    [SerializeField] private Score statistic;

    private void Update() {
        GetComponent<Text>().text = "Score: " + statistic.score.ToString();
    }
}
