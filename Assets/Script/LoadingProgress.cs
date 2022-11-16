using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingProgress : MonoBehaviour
{
    [SerializeField] Image image;

    private void Start()
    {
        StartCoroutine(Progress());
    }
    IEnumerator Progress()
    {

        image.fillAmount = 0;
        yield return new WaitForSeconds(1);

        var asyncOp = SceneManager.LoadSceneAsync(SceneLoader.SceneToLoad);

        while (asyncOp.isDone == false)
        {
            image.fillAmount = asyncOp.progress;
            yield return null;
        }
    }

}
