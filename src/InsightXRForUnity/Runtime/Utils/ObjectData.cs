using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectData
{
    public string ParentObject;
    public float posx, posy, posz, rotx, roty, rotz, rotw;

    public ObjectData(Vector3 pos, Quaternion rot, string Parent)
    {
        ParentObject = Parent;
        (posx, posy, posz) = (pos.x,pos.y,pos.z);
        (rotx, roty, rotz, rotw) = (rot.x, rot.y, rot.z, rot.w);
        
    }
    public Vector3 GetPosition()
    {
        return new Vector3(posx, posy, posz);
    }

    public Quaternion GetRotation()
    {
        return new Quaternion(rotx, roty, rotz, rotw);
    }
    
    
}
