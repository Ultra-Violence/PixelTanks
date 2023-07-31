using UnityEngine;

public class MazeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject CellPrefab;
    [SerializeField] private GameObject CellMetalPrefab;
    private Cell c;

    private void Awake() {
        MazeGenerator generator = new MazeGenerator();
        MazeGeneratorCell[,] maze = generator.GenerateMaze();

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                if(x == 0 || x == maze.GetLength(0) - 1 || y == 0 || y == maze.GetLength(1) - 1){
                    c = Instantiate(CellMetalPrefab, new Vector2(x, y), Quaternion.identity).GetComponent<Cell>();
                }
                else{
                    int randomNum = UnityEngine.Random.Range(0, 2);
                    if(randomNum == 1){
                        c = Instantiate(CellPrefab, new Vector2(x, y), Quaternion.identity).GetComponent<Cell>();
                    }
                    else {
                        c = Instantiate(CellMetalPrefab, new Vector2(x, y), Quaternion.identity).GetComponent<Cell>();
                    } 
                }
                
                

                c.WallLeft.SetActive(maze[x, y].WallLeft);
                c.WallBottom.SetActive(maze[x, y].WallBottom);
            }
        } 
    }
}
