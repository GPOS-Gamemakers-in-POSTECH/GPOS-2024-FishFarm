using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NurseryParts;

public class FishNursery
{
    int NurseryTier;
    public FishNursery()
    {
        bool IsNurseryAvailable;


        //FishTarget, 양식하는 물고기
        //FishPossible, 양식가능한 물고기 종류
        
        
        List<NurseryParts> PartsList = new List<NurseryParts>();//장착된 부품 목록

        int Temperature;//수온
        int OxygenRate;//용존 산소량

        int GrowthRate;//성장률
        int ExpirationDate=0;//폐사 일수 확인
    }


    void CheckNecessaryParts()//필수 부품 확인, 3일 후 폐사
    {
        
    }

    void AddParts(NurseryParts parts)//부품 추가
    {
        //중복 부품 확인

    }

    bool IsUpgradePossible()//티어 상승 조건 확인
    {
        
    }



}


public class FreshWaterNursery : FishNursery
{
    
}

public class SeaWaterNursery : FishNursery
{
    
}

public class InsideNursery : FishNursery
{

}