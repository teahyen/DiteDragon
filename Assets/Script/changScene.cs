using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changScene : MonoBehaviour
{
        public void ChangeFirstScene()
        {
            SceneManager.LoadScene("start");
        }
        public void ChangeSecondScene()
        {
            SceneManager.LoadScene("MainScene");
        }
}
