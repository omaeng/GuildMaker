using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {
    
    void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
