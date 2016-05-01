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

    //adds vector3 to specified list for caster spawns
    public static void listAdd_caster(Vector3 newVec, int L_num)
    {
        getList_caster(L_num).Add(newVec);
    }

    //adds vector3 to specified list for bosses
    public static void listAdd_boss(Vector3 newVec, int L_num)
    {
        getList_boss(L_num).Add(newVec);
    }


    //returns the list of all the Vector3s that we want enemys to spawns at
    public static List<Vector3> getSpawns(int L_num)
    {
        Debug.Log("the l number is " + L_num);
        return getList(L_num);
    }


    //returns the list of all the Vector3s that we want casters to spawns at
    public static List<Vector3> getSpawns_caster(int L_num)
    {
        Debug.Log("the l number is " + L_num);
        return getList_caster(L_num);
    }

    //returns the list of all the Vector3s that we want bosses to spawns at
    public static List<Vector3> getSpawns_boss(int L_num)
    {
        Debug.Log("the l number is " + L_num);
        return getList_boss(L_num);
    }



    //checks the number that is passed and returnes a refference to the 
    //specific "enemypos" list.
    private static List<Vector3> getList(int x)
    {
        //switch is used to test all of the numbers 1 - 28 for the sits that are supported
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
            case 21:
                return enemypos21;
            case 22:
                return enemypos22;
            case 23:
                return enemypos23;
            case 24:
                return enemypos24;
            case 25:
                return enemypos25;
            case 26:
                return enemypos26;
            case 27:
                return enemypos27;
            case 28:
                return enemypos28;

            default:
                Debug.Log("int passed is a non-supported int");
                break;
        }
        Debug.Log("the returned value is null");
        return null;
    }

     private static List<Vector3> getList_caster(int x)
    {
        //switch is used to test all of the numbers 1-4 for the sits that are supported
        switch (x)
        {
            case 1:
                return casterpos1;
            case 2:
                return casterpos2;
            case 3:
                return casterpos3;
            case 4:
                return casterpos4;
            default:
                Debug.Log("int passed is a non-supported int");
                break;
        }
        Debug.Log("the returned value is null");
        return null;
    }


     private static List<Vector3> getList_boss(int x)
     {
         //switch is used to test all of the numbers 1-2 for the sits that are supported
         switch (x)
         {
             case 1:
                 return bosspos1;
             case 2:
                 return bosspos2;
             default:
                 Debug.Log("int passed is a non-supported int");
                 break;
         }
         Debug.Log("the returned value is null");
         return null;
     }



    //creates all of the lists that would be called by the various spawn points
    static List<Vector3> enemypos0 = new List<Vector3>();
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
    static List<Vector3> enemypos21 = new List<Vector3>();
    static List<Vector3> enemypos22 = new List<Vector3>();
    static List<Vector3> enemypos23 = new List<Vector3>();
    static List<Vector3> enemypos24 = new List<Vector3>();
    static List<Vector3> enemypos25 = new List<Vector3>();
    static List<Vector3> enemypos26 = new List<Vector3>();
    static List<Vector3> enemypos27 = new List<Vector3>();
    static List<Vector3> enemypos28 = new List<Vector3>();

    //caster skeliton spawnpoints
    static List<Vector3> casterpos1 = new List<Vector3>();
    static List<Vector3> casterpos2 = new List<Vector3>();
    static List<Vector3> casterpos3 = new List<Vector3>();
    static List<Vector3> casterpos4 = new List<Vector3>();

    //boss spawnpoints
    static List<Vector3> bosspos1 = new List<Vector3>();
    static List<Vector3> bosspos2 = new List<Vector3>();

}

