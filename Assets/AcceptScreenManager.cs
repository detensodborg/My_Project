using UnityEngine;
using UnityEngine.SceneManagement;

public class AcceptScreenManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("PocketLife");
    }
}
