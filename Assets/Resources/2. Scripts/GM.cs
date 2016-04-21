// copyright(c) 2016 by 오명훈 
using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {
    
    [SerializeField] private int sceneNum;

    void Awake()
    {
        sceneNum = 0;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    public void SceneConversion(int repeat = 1, bool addScene = false)
    {
        for(int count = 0; count < repeat; count++)
        {
            IncreseSceneNum();
        }
        switch(addScene)
        {
            case true:
                OperateLoadScene(LoadSceneMode.Additive);
                break;
            case false:
                OperateLoadScene();
                break;
        }
    }

    void IncreseSceneNum()
    {
        sceneNum++;
    }

    void OperateLoadScene(LoadSceneMode mode = LoadSceneMode.Single)
    {
        SceneManager.LoadScene(sceneNum, mode);
    }

    void Start()
    {

    }
}
