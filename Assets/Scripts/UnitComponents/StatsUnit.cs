using UnityEngine;
using UnityEngine.AI;

public class StatsUnit : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private EnemySO activeType;

    [SerializeField] private int _health;
    public int health => _health;
    
    private void Start() {
        if(gameObject.tag == "Enemy"){
            GetComponent<NavMeshAgent>().speed = activeType.speed;
            GetComponent<SpriteRenderer>().color = activeType.color;
            _health = activeType.health;
        }
    }

    public void TakeDamage(int Damage){
        if(gameObject.tag == "Player")  transform.position = new Vector3(15.5f, 1.5f, 0);
        _health -= Damage;
    }

    private void Update() {
        if(health <= 0){
            if(gameObject.tag == "Player"){
                Menu.SetActive(true);
                Menu.GetComponent<Menu>().End("Game Over");
            }
            else if(gameObject.tag == "Enemy"){
                GameObject.Find("GameEvents/Score").GetComponent<Score>().UpdateScore();
                GameObject.Find("GameEvents/RandomBonus").GetComponent<RandomBonus>().RandomBonusAfterKill(transform);
            }
            Destroy(gameObject);
        }
    }

    public void GetHealth(int number){
        _health += number;
    }
}
