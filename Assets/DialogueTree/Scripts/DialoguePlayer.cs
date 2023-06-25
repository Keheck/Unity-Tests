using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{
    public string DialogueLocation { get; set; }
    public float SecondsBetweenLetters { get; set; } = 0.1f;

    private bool finished;
    private string script;

    private 

    void Start() {

    }

    void OnEnable() {
        TextAsset asset = Resources.Load<TextAsset>($"{DialogueLocation}.dialogue");
    }

    void Update() {
        
    }

    IEnumerator DisplayText() {
        yield return new WaitForSeconds(0.1f);
    }
}
