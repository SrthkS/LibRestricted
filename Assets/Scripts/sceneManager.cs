using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void Load1984()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("1984");
    }
    public void LoadTKAB()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("TKAB");
    }
    public void LoadBible()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Bible");
    }
    public void LoadQuran()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Quran");
    }
    public void LoadRigveda()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Rigveda");
    }
    public void LoadLibrary()
    {
        SceneManager.LoadScene("Library");
    }
}
