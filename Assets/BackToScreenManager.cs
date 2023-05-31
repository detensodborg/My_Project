using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScreenManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("PocketLife");
    }
}
