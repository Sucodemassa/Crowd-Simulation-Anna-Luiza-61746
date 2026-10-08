using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public static FlockManager FM;
    public GameObject fishPrefab;
    public int numFish = 20;
    public GameObject[] allfish;
    public Vector3 swinLimit = new Vector3 (8, 8, 8);
    public Vector3 goalPos = Vector3.zero;

    [Header("Fish Settings")]
    [Range(0.0f, 5f)]
    public float minSpeed;
    [Range(0.0f, 5f)]
    public float maxSpeed;
    [Range(1.0f, 10.0f)]
    public float neighbourDistance;
    [Range(1.0f, 5.0f)] 
    public float rotationSpeed;
    void Start()
    {
        allfish = new GameObject[numFish];

        for (int i = 0; i < numFish; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-swinLimit.x, swinLimit.x),
                                                                Random.Range(-swinLimit.y, swinLimit.y),
                                                                Random.Range(-swinLimit.z, swinLimit.z));
            allfish[i] = Instantiate(fishPrefab, pos, Quaternion.identity);
        }
        FM = this;
        goalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0,100) < 10) 
        {
            goalPos     = this.transform.position + new Vector3(Random.Range(-swinLimit.x, swinLimit.x),
                                                                Random.Range(-swinLimit.y, swinLimit.y),
                                                                Random.Range(-swinLimit.z, swinLimit.z));
        }
    }
}
