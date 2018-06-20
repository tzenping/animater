using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateScript : MonoBehaviour {

    [SerializeField] int curFrame = 0;
    [SerializeField] int fps = 30;
    [SerializeField] int rowCount = 2;
    [SerializeField] int colCount = 8;

    Vector2 offset = Vector2.zero;
    float spritesWidth = 0f;
    Renderer rend;
    float timeBetweenFrames;
    float currentTime = 0f;
	// Use this for initialization
	void Start () {
        rend = this.GetComponent<Renderer>();
        spritesWidth = 1f / (float)colCount;
	}
	
	// Update is called once per frame
	void Update () {
        timeBetweenFrames = 1f/(float) fps;
        if (currentTime < timeBetweenFrames) currentTime += Time.deltaTime;
        else
        {
            currentTime = 0f;
            curFrame++;
        }
        offset.x = curFrame * spritesWidth;
        rend.material.SetTextureOffset("_MainTex",offset);
	}
}
