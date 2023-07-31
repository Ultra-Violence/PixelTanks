using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private GameObject _WallLeft;
    [SerializeField] private GameObject _WallBottom;

    public GameObject WallLeft => _WallLeft;
    public GameObject WallBottom => _WallBottom;
}
