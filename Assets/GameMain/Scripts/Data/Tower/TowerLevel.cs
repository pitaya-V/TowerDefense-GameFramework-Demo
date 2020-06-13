﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Data;
using GameFramework.DataTable;

namespace Flower
{
    public class TowerLevel : MonoBehaviour
    {
        private DRTowerLevel dRTowerLevel;
        private DRAssetsPath dRAssetsPath;

        public int Id
        {
            get
            {
                return dRTowerLevel.Id;
            }
        }

        public string DesId
        {
            get
            {
                return GameEntry.Localization.GetString(dRTowerLevel.DesId);
            }
        }

        public string AssetPath
        {
            get
            {
                return dRAssetsPath.AssetPath;
            }
        }

        public float DPS
        {
            get
            {
                return dRTowerLevel.DPS;
            }
        }

        public float Range
        {
            get
            {
                return dRTowerLevel.Range;
            }
        }

        public int BuildEnergy
        {
            get
            {
                return dRTowerLevel.BuildEnergy;
            }
        }

        public int SellEnergy
        {
            get
            {
                return dRTowerLevel.SellEnergy;
            }
        }
    }

}

