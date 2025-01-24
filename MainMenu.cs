using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to start the game
    public void PlayGame()
    {
        // Load the next scene (assuming the main gameplay scene is next in the build settings)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Method to open options menu
    public void OpenOptions()
    {
        // Here you would implement the functionality to open the options menu
        Debug.Log("Options menu opened.");
    }

    // Method to quit the game
    public void QuitGame()
    {
        // Exit the application
        Debug.Log("Game is exiting...");
        Application.Quit();
    }
}
