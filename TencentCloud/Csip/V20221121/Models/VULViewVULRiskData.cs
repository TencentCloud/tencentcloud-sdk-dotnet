/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VULViewVULRiskData : AbstractModel
    {
        
        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 影响资产
        /// </summary>
        [JsonProperty("NoHandleCount")]
        public long? NoHandleCount{ get; set; }

        /// <summary>
        /// 风险等级，low-低危，high-高危，middle-中危，info-提示，extreme-严重。
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 组件
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 最近识别时间
        /// </summary>
        [JsonProperty("RecentTime")]
        public string RecentTime{ get; set; }

        /// <summary>
        /// 首次识别时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 影响资产数量
        /// </summary>
        [JsonProperty("AffectAssetCount")]
        public ulong? AffectAssetCount{ get; set; }

        /// <summary>
        /// 风险ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// 扫描来源，具体看接口返回枚举类型
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 前端索引
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// 漏洞类型
        /// </summary>
        [JsonProperty("VULType")]
        public string VULType{ get; set; }

        /// <summary>
        /// 漏洞名
        /// </summary>
        [JsonProperty("VULName")]
        public string VULName{ get; set; }

        /// <summary>
        /// cve
        /// </summary>
        [JsonProperty("CVE")]
        public string CVE{ get; set; }

        /// <summary>
        /// 漏洞payload
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// 漏洞影响组件
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 漏洞影响版本
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 风险点
        /// </summary>
        [JsonProperty("VULURL")]
        public string VULURL{ get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 用户appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 应急漏洞类型，1-应急漏洞，0-非应急漏洞
        /// </summary>
        [JsonProperty("EMGCVulType")]
        public long? EMGCVulType{ get; set; }

        /// <summary>
        /// CVSS评分
        /// </summary>
        [JsonProperty("CVSS")]
        public float? CVSS{ get; set; }

        /// <summary>
        /// PCMGRId
        /// </summary>
        [JsonProperty("PCMGRId")]
        public string PCMGRId{ get; set; }

        /// <summary>
        /// 漏洞标签。搜索时应急 必修传参VulTag=SuggestRepair/EMGCVul
        /// </summary>
        [JsonProperty("VulTag")]
        public string[] VulTag{ get; set; }

        /// <summary>
        /// 漏洞披露时间
        /// </summary>
        [JsonProperty("DisclosureTime")]
        public string DisclosureTime{ get; set; }

        /// <summary>
        /// 攻击热度
        /// </summary>
        [JsonProperty("AttackHeat")]
        public ulong? AttackHeat{ get; set; }

        /// <summary>
        /// 是否必修漏洞，1-是，0-不是
        /// </summary>
        [JsonProperty("IsSuggest")]
        public long? IsSuggest{ get; set; }

        /// <summary>
        /// 处置任务id
        /// </summary>
        [JsonProperty("HandleTaskId")]
        public string HandleTaskId{ get; set; }

        /// <summary>
        /// 引擎来源
        /// </summary>
        [JsonProperty("EngineSource")]
        public string EngineSource{ get; set; }

        /// <summary>
        /// 新的漏洞风险id
        /// </summary>
        [JsonProperty("VulRiskId")]
        public string VulRiskId{ get; set; }

        /// <summary>
        /// 新版漏洞id
        /// </summary>
        [JsonProperty("TvdID")]
        public string TvdID{ get; set; }

        /// <summary>
        /// 是否可以一键体检，1-可以，0-不可以
        /// </summary>
        [JsonProperty("IsOneClick")]
        public ulong? IsOneClick{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "NoHandleCount", this.NoHandleCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "RecentTime", this.RecentTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "AffectAssetCount", this.AffectAssetCount);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "VULURL", this.VULURL);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "EMGCVulType", this.EMGCVulType);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "PCMGRId", this.PCMGRId);
            this.SetParamArraySimple(map, prefix + "VulTag.", this.VulTag);
            this.SetParamSimple(map, prefix + "DisclosureTime", this.DisclosureTime);
            this.SetParamSimple(map, prefix + "AttackHeat", this.AttackHeat);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "HandleTaskId", this.HandleTaskId);
            this.SetParamSimple(map, prefix + "EngineSource", this.EngineSource);
            this.SetParamSimple(map, prefix + "VulRiskId", this.VulRiskId);
            this.SetParamSimple(map, prefix + "TvdID", this.TvdID);
            this.SetParamSimple(map, prefix + "IsOneClick", this.IsOneClick);
        }
    }
}

