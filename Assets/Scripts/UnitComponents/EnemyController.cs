using UnityEngine.AI;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    private void Start() {
        agent.SetDestination(new Vector3(15.5f, 0.5f, 0));
    }
    private void Update() {
        transform.rotation = Quaternion.identity;
    }
}
