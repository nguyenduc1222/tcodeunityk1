using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject prefab;

    private GameObject _clone1;
    private GameObject _clone2;
    private GameObject _clone3;
    private GameObject _clone4;

    private TargetController t1;
    private TargetController t2;
    private TargetController t3;
    private TargetController t4;


    void Start()
    {
        // for (int i = 0; i < 10; i++)
        // {
        //     Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        // }

        _clone1 = Instantiate(prefab, Camera.main.ViewportToWorldPoint(new Vector3(0.05F, 0.95F, 0)), Quaternion.identity);
         t1 = _clone1.GetComponent<TargetController>();
        t1.myColor = Color.red;
        t1.moveTo = TargetController.MoveTo.DOWN;

        _clone2 = Instantiate(prefab, Camera.main.ViewportToWorldPoint(new Vector3(0.95F, 0.95F, 0)), Quaternion.identity);
         t2 = _clone2.GetComponent<TargetController>();
        t2.myColor = Color.blue;
        t2.moveTo = TargetController.MoveTo.LEFT;

        _clone3 = Instantiate(prefab, Camera.main.ViewportToWorldPoint(new Vector3(0.95F, 0.05F, 0)), Quaternion.identity);
         t3 = _clone3.GetComponent<TargetController>();
        t3.myColor = Color.yellow;
        t3.moveTo = TargetController.MoveTo.UP;

        _clone4 = Instantiate(prefab, Camera.main.ViewportToWorldPoint(new Vector3(0.05F, 0.05F, 0)), Quaternion.identity);
         t4 = _clone4.GetComponent<TargetController>();
        t4.myColor = Color.white;
        t4.moveTo = TargetController.MoveTo.RIGHT;

    }

	

	// Update is called once per frame
	void Update () {

        //t1.Update();
        //t2.Update();
        //t3.Update();
        //t4.Update();

    }
}
