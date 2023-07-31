using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBonus : MonoBehaviour
{
    [SerializeField] private List<GameObject> bonusList;

    public void RandomBonusAfterKill(Transform transformEnemy){
        int randomСhance = Random.Range(0, 100);
        if(randomСhance >= 60){
            Instantiate(bonusList[Random.Range(0, bonusList.Count)], transformEnemy.position, Quaternion.identity);
        }
    }
}
