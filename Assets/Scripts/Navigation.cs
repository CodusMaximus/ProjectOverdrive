using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : INavigation {
    public void MainMenu() {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void SampleScene() {
        SceneManager.LoadScene("SampleScene");
    }
}
public interface INavigation {
    void MainMenu();
    void SampleScene();
}
