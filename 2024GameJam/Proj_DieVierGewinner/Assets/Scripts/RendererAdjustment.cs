using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RendererAdjustment : MonoBehaviour
{
    void Start() {
        RawImage img = GetComponent<RawImage>();
        Resolution res = Screen.currentResolution;
        float sh = res.height;
        float sw = res.width;

        float rat = (sh / sw);
        img.texture.width = 480; img.texture.height = (int)(480 * rat);
    }

    
    void Update() {
        
    }
}
