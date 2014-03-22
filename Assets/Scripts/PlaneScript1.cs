using UnityEngine;
using System.Collections;

public class PlaneScript1 : MonoBehaviour {

    public GameObject capture;
    public CaptureScript1 captureScript1;

	// Use this for initialization
	void Start () {
        captureScript1 = capture.GetComponent<CaptureScript1>();
    }
	
	// Update is called once per frame
	void Update () {
        renderer.material.mainTexture = captureScript1.texture;
    }
}
