using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    public Image fillImage; // Reference to the Image component representing the filled portion

    private float currentExperience; // Current experience value
    public float maxExperience; // Maximum experience value

    // Call this method to update the experience value and the experience bar
    public void UpdateExperience(float experience)
    {
        currentExperience = experience;
        UpdateExperienceBar();
    }

    // Update the visual representation of the experience bar
    private void UpdateExperienceBar()
    {
        if (fillImage == null)
        {
            Debug.LogWarning("Image reference is missing. Assign the Image component to the fillImage field.");
            return;
        }

        float fillAmount = currentExperience / maxExperience;
        fillImage.fillAmount = fillAmount;
    }
}
