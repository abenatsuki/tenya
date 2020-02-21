using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InstanceManager : MonoBehaviour
{
    [SerializeField,Tooltip("ランダムx最小値")]
    float min;
    [SerializeField,Tooltip("ランダムx最大値")]
    float max;
    [SerializeField,Tooltip("プレふぁぶリスト")]
    List<GameObject> objects;

    [SerializeField,Tooltip("生成間隔")]
    int spownTime;

    float time;


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spownTime) { 
        Instantiate(objects[Random.Range(0, objects.Count)], new Vector3(Random.Range(min, max), transform.position.y, 0), new Quaternion(0, 0, 0, 0));
        time = 0; }
        
        
    }
}
