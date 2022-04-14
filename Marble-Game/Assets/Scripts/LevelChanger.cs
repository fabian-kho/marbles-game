using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelChanger
{

    private class LoadingMonobehavoir : MonoBehaviour{}
    public enum Scene {
        Level1,
        Level2,
        Loading,

    }

    private static Action onLoaderCallback;

    public static void Load(Scene scene){
        
        //Set the loader callback action to load the target scene
        onLoaderCallback = () => {
        GameObject loadingGameobject = new GameObject("Loading Game Object");
        loadingGameobject.AddComponent<LoadingMonobehavoir>().StartCoroutine(LoadingSceneAsync(scene));
        };
        //Load the loading Scene
        SceneManager.LoadScene(Scene.Loading.ToString());
    }
    private static IEnumerator LoadingSceneAsync(Scene scene){

        yield return null;
        AsyncOperation asynchOperation = SceneManager.LoadSceneAsync(scene.ToString());
        while(!asynchOperation.isDone) yield return null;
    }
    public static void LoaderCallback(){
        //Triggered after the first Update wich lets the screen refresh
        //Execute the loader callback action wich will load the target scene
        if(onLoaderCallback != null){
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
