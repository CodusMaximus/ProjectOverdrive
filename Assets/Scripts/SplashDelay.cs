using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashDelay : MonoBehaviour
{
    public int SecondsDelay { get; set; } = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(SecondsDelay, () =>
        {
            INavigation n = new Navigation();
            n.MainMenu();
        }));
    }
    private bool isCoroutineExecuting = false;
    IEnumerator ExecuteAfterTime(float time, Action task) {
        if (isCoroutineExecuting)
            yield break;
        isCoroutineExecuting = true;
        yield return new WaitForSeconds(time);
        task();
        isCoroutineExecuting = false;
    }
}
