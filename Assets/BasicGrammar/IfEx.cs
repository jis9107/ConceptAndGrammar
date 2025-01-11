using UnityEngine;

public class IfEx
{
    public void If()
    {
        int num = 4;
        string result;

        if (num % 2 == 0)
            result = "짝수";
        else
            result = "홀수";

        Debug.Log(result);


        result = (num % 2 == 0) ? "짝수" : "홀수";

        Debug.Log(result);
    }
}