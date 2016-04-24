using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyPosition : MonoBehaviour
{



    //adds the passed Vactor3 to the list specified by the int passed
    public static void listAdd(Vector3 newVec, int L_num)
    {
        getList(L_num).Add(newVec);
    }


    //returns the list of all the Vector3s that we want spawns at
    public static List<Vector3> getSpawns(int L_num)
    {
        return getList(L_num);
    }

    //checks the number that is passed and returnes a refference to the 
    //specific "enemypos" list.
    private static List<Vector3> getList(int x)
    {
        //switch is used to test all of the numbers 1 - 20 for the sits that are supported
        switch (x)
        {
            case 1:
                return enemypos1;
            case 2:
                return enemypos2;
            case 3:
                return enemypos3;
            case 4:
                return enemypos4;
            case 5:
                return enemypos5;
            case 6:
                return enemypos6;
            case 7:
                return enemypos7;
            case 8:
                return enemypos8;
            case 9:
                return enemypos9;
            case 10:
                return enemypos10;
            case 11:
                return enemypos11;
            case 12:
                return enemypos12;
            case 13:
                return enemypos13;
            case 14:
                return enemypos14;
            case 15:
                return enemypos15;
            case 16:
                return enemypos16;
            case 17:
                return enemypos17;
            case 18:
                return enemypos18;
            case 19:
                return enemypos19;
            case 20:
                return enemypos20;
            default:
                Debug.Log("int passed is a non-supported int");
                break;
        }
        Debug.Log("the returned value is null");
        return null;
    }


    //creates all of the lists that would be called by the various spawn points
    static List<Vector3> enemypos1 = new List<Vector3>();
    static List<Vector3> enemypos2 = new List<Vector3>();
    static List<Vector3> enemypos3 = new List<Vector3>();
    static List<Vector3> enemypos4 = new List<Vector3>();
    static List<Vector3> enemypos5 = new List<Vector3>();
    static List<Vector3> enemypos6 = new List<Vector3>();
    static List<Vector3> enemypos7 = new List<Vector3>();
    static List<Vector3> enemypos8 = new List<Vector3>();
    static List<Vector3> enemypos9 = new List<Vector3>();
    static List<Vector3> enemypos10 = new List<Vector3>();
    static List<Vector3> enemypos11 = new List<Vector3>();
    static List<Vector3> enemypos12 = new List<Vector3>();
    static List<Vector3> enemypos13 = new List<Vector3>();
    static List<Vector3> enemypos14 = new List<Vector3>();
    static List<Vector3> enemypos15 = new List<Vector3>();
    static List<Vector3> enemypos16 = new List<Vector3>();
    static List<Vector3> enemypos17 = new List<Vector3>();
    static List<Vector3> enemypos18 = new List<Vector3>();
    static List<Vector3> enemypos19 = new List<Vector3>();
    static List<Vector3> enemypos20 = new List<Vector3>();

}

