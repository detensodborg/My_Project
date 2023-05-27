using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public Text pointsText;

    private int points = 0;

    void Start()
    {
        pointsText.text = points.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            points++;
            pointsText.text = points.ToString();
        }
    }
}
