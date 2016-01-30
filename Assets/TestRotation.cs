using UnityEngine;
using System.Collections;

public class TestRotation : MonoBehaviour {

    Hashtable hash = new Hashtable ();

    void Awake () {
        hash.Add ("y", 90f);
        hash.Add ("time", 2);
        hash.Add ("looptype", iTween.EaseType.easeOutSine);
    }

	// Use this for initialization
	void Start () {
	
        
	}
	
	// Update is called once per frame
	void Update () {


    }
}
