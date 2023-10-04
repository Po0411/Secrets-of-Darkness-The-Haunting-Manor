using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_move : MonoBehaviour
{
    [SerializeField]
    private GameObject move_obj;
    [SerializeField]
    private float[] target_xyz=new float [3];
    [SerializeField]
    private float move_speed;
    [SerializeField]
    private bool is_MoveTowards;
    private void Update()
    {
        Vector3 target_vetcor = new Vector3(target_xyz[0], target_xyz[1], target_xyz[2]);
        if (is_MoveTowards)
            move_obj.transform.position = Vector3.MoveTowards(move_obj.transform.position, target_vetcor, move_speed);
        else
            move_obj.transform.position = target_vetcor;
    }
}
