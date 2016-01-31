using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour, IDragHandler, IPointerClickHandler {

    Hashtable hashRight = new Hashtable ();
    Hashtable hashLeft = new Hashtable ();

    public int classID;
    public bool isClassMenuOpen;
    public GameObject auxiliarCanvas, classesMenu;

    void Awake () {
        hashRight.Add ("name", "CameraRight");
        hashRight.Add ("y", 120f);
        hashRight.Add ("time", 0.5f);
        hashRight.Add ("looptype", iTween.EaseType.easeOutSine);

        hashLeft.Add ("name", "CameraLeft");
        hashLeft.Add ("y", -120f);
        hashLeft.Add ("time", 0.5f);
        hashLeft.Add ("looptype", iTween.EaseType.easeOutSine);
    }



    public void OnDrag (PointerEventData eventData) {
        if (!isClassMenuOpen) {
            Vector2 dir = Vector2.zero;
            dir = eventData.delta.normalized;

            if (!Camera.main.GetComponent<iTween> ()) {
                if (dir.x < -.1f) {
                    iTween.RotateAdd (Camera.main.gameObject, hashRight);
                }
                if (dir.x > .1f) {
                    iTween.RotateAdd (Camera.main.gameObject, hashLeft);
                }
            }
        }
    }

    public void OnPointerClick (PointerEventData eventData) {
        OpenClassMenu ();
    }

    public void OpenClassMenu () {
        if (classID == 1) {
            isClassMenuOpen = true;
            //auxiliarCanvas.SetActive (false);
            classesMenu.SetActive (true);
        }
    }
}
