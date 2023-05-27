using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public Game_manager game_manager;

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            game_manager.credits++;
            game_manager.pointsText.text = game_manager.credits.ToString();
            game_manager.exp++;

        }
    }
}
