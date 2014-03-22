using UnityEngine;
using System.Collections;

public class PlaneScript2 : MonoBehaviour {

    public GameObject capture;
    public CaptureScript2 captureScript2;

	// Use this for initialization
	void Start () {
        captureScript2 = capture.GetComponent<CaptureScript2>();
    }
	
	// Update is called once per frame
	void Update () {
        renderer.material.mainTexture = captureScript2.texture;
    }
}
