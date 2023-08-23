using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroname= "superman";
        float herohight= 170.5f;
        int heroage = 30;
        string herosuperpower="fly";

        string villainName="venom";
        float vililanhight=165.5f;
        int vililanage = 27;
        string vililansuperpower= "web";

        int result = heroage - vililanage;
        print(result);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
