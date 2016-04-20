// copyright(c) 2016 by 오명훈 
using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {
    
    void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
