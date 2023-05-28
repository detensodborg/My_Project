using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Manager : MonoBehaviour
{

    private const int grid_size = 6;
    public GameObject tile_prefab;

    Dictionary<Vector2, GameObject> tiles = new Dictionary<Vector2, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < grid_size; x++) {
            for (int z = 0; z < grid_size; z++) {
                tiles[new Vector2(x,z)] = Instantiate(tile_prefab, new Vector3(x-(grid_size/2)+0.5f, 1, z - (grid_size / 2)+0.5f), Quaternion.identity);
            }
        }
        ToggleGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool is_on = false;
    public void ToggleGrid()
    {
        is_on = !is_on;
      foreach (GameObject value in tiles.Values)
      {
          value.SetActive(is_on);
      }
    }
}
