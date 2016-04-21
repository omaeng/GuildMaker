using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {
    private GM _gm;
    private float _time;

    void Awake()
    {
        _gm = GameObject.Find("GM").GetComponent<GM>();
        _time = 0;
    }

    void Start()
    {
        StartCoroutine(PlayLogo());
    }

    IEnumerator PlayLogo()
    {
        while (_time < 2.0f || !Input.GetMouseButtonDown(0))
        {
            _time += Time.deltaTime;
            Debug.Log("PlayLogo!");

            yield return null;
        }

        _gm.SceneConversion();
        
        yield return null;
    }
}
