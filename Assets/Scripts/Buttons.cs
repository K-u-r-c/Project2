using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    public Rigidbody jumpTarget;
    public string sceneToLoad;
    public int jumpForce;

    public Fader fader;

    #region JumpButton
    public void Jump() {
        if (jumpTarget == null)
            return;

        jumpTarget.AddForce(Vector3.up * jumpForce);
    }
    #endregion

    #region SwitchSceneButton
    IEnumerator waitForAnimator() {
        fader.FadeIn();
        if(!fader.animator.GetCurrentAnimatorStateInfo(0).IsName("emptyState"))
            yield return new WaitForSeconds(.3f);
        
        SceneManager.LoadSceneAsync(sceneToLoad);
    }

    public void SwitchScene() {
        if (sceneToLoad == null) return;

        StartCoroutine(waitForAnimator());
    }
    #endregion
}
