using UnityEngine;
using System.Collections;

public class MainMenuControl : MonoBehaviour {

    public MenuController[] doors = new MenuController[3];

    public void CloseMenu () {
        for (int a = 0; a < doors.Length; a++) {
            if (doors[a].isClassMenuOpen) {
                doors [a].isClassMenuOpen = false;
                //doors [a].auxiliarCanvas.SetActive (true);
                doors [a].classesMenu.SetActive (false);
            }
        }        
    }
}
