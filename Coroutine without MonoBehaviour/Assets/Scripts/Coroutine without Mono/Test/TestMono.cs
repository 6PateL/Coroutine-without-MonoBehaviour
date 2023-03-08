using UnityEngine;

public class TestMono : MonoBehaviour
{
    private Tester _tester;
    private void Start() {
        this._tester = new Tester(); 
    } 
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            this._tester.StartTestRoutine();
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            this._tester.StopTestRoutine();   
        }
    }
} 