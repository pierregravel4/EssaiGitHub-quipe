using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leScript : MonoBehaviour
{
[SerializeField] private Vector3 _rot;
    //Yo mon fou ! C'est le script trop cool !!//

    void Update()
    {
        transform.Rotate(_rot*Time.deltaTime);
    }

}
