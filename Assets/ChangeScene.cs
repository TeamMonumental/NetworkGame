using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    
    public void SwitchScene(string scene) {
        SceneManager.LoadScene(scene);
    }
}
