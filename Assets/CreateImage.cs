using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateImage : MonoBehaviour {

    public GameObject canvas;
    public int superSize = 1;
    bool takingImage;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateImageNoUI()
    {
        if (!takingImage)
        {
            StartCoroutine(TakeImage());
        }
    }

    public IEnumerator TakeImage()
    {
        takingImage = true;
        canvas.SetActive(false);
        yield return new WaitForSeconds(0.001f);
        Application.CaptureScreenshot("Screenshot.png", superSize);
        yield return new WaitForSeconds(0.001f);
        canvas.SetActive(true);
        takingImage = false;
    }
}
