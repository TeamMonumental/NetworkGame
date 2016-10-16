using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

	public void ToggleFullscreen() {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
