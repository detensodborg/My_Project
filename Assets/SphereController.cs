using UnityEngine;
using UnityEngine.UI;

public class SphereController : MonoBehaviour
{
    private int wallHits = 0;
    public int maxWallHits = 4;
    public Slider experienceBar;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            wallHits++;
            UpdateExperienceBar();
        }
    }

    private void UpdateExperienceBar()
    {
        float fillAmount = (float)wallHits / maxWallHits;
        experienceBar.value = fillAmount;

        if (wallHits >= maxWallHits)
        {
            // Perform any additional actions when the experience bar is filled (e.g., level up)
            Debug.Log("Experience bar filled!");
        }
    }
}
