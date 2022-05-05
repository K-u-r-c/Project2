using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    public Rigidbody jumpTarget;
    public string sceneToLoad;
    public int jumpForce;

    #region JumpButton
    public void Jump() {
        if (jumpTarget == null)
            return;

        jumpTarget.AddForce(Vector3.up * jumpForce);
    }
    #endregion

    #region SwitchSceneButton
    public void SwitchScene() {
        SceneManager.LoadSceneAsync(sceneToLoad);
    }
    #endregion
}
