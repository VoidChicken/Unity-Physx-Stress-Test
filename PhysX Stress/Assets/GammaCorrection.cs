using UnityEngine;
using System.Collections;

public class GammaCorrection : MonoBehaviour {
    Material gammaCorrection;
	// Use this for initialization
	void Start () {
        Shader gamma = Shader.Find("Hidden/Gamma Correction");
        gammaCorrection = new Material(gamma);
	}
	
	// Update is called once per frame
	void OnRenderImage(RenderTexture src, RenderTexture dest) {
        Graphics.Blit(src, dest, gammaCorrection);
	}
}
