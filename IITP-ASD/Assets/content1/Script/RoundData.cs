using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RoundData
{
    public string name;//round name
    public int timeLimitInSeconds;
    public int pointsAddedForCorrectAnswer;
    public QusetionData[] questions; //이걸로 연결

}
