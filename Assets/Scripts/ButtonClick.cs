using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate () { GoToSample(); });
    }

    private void GoToSample() {
        var navigateTo = new Navigation();
        navigateTo.SampleScene();
    }
}
