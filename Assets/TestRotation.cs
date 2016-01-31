using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TestRotation : MonoBehaviour, IDragHandler {

    Hashtable hashRight = new Hashtable ();
    Hashtable hashLeft = new Hashtable ();

    void Awake () {
        hashRight.Add ("name", "CameraRight");
        hashRight.Add ("y", 90f);
        hashRight.Add ("time", 0.5f);
        hashRight.Add ("looptype", iTween.EaseType.easeOutSine);

        hashLeft.Add ("name", "CameraLeft");
        hashLeft.Add ("y", -90f);
        hashLeft.Add ("time", 0.5f);
        hashLeft.Add ("looptype", iTween.EaseType.easeOutSine);
    }

    public void OnDrag (PointerEventData eventData) {
        Vector2 dir = Vector2.zero;
        dir = eventData.delta.normalized;
        Debug.Log (dir);
        if (!Camera.main.GetComponent<iTween>()) {
            if (dir.x < -.1f) {
                iTween.RotateAdd (Camera.main.gameObject, hashRight);
            }
            if (dir.x > .1f) {
                iTween.RotateAdd (Camera.main.gameObject, hashLeft);
            }
        }
        

    }
}
