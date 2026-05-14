/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class ExposesItem : AbstractModel
    {
        
        /// <summary>
        /// <p>云厂商</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>云账号名称</p>
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// <p>云账号</p>
        /// </summary>
        [JsonProperty("CloudAccountId")]
        public string CloudAccountId{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>IP</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>端口或者端口范围</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>开放</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>风险类型</p>
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// <p>acl类型</p>
        /// </summary>
        [JsonProperty("AclType")]
        public string AclType{ get; set; }

        /// <summary>
        /// <p>acl列表</p>
        /// </summary>
        [JsonProperty("AclList")]
        public string AclList{ get; set; }

        /// <summary>
        /// <p>资产ID</p>
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>资产类型</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>端口服务数量</p>
        /// </summary>
        [JsonProperty("PortServiceCount")]
        public ulong? PortServiceCount{ get; set; }

        /// <summary>
        /// <p>高危端口数量</p>
        /// </summary>
        [JsonProperty("HighRiskPortServiceCount")]
        public ulong? HighRiskPortServiceCount{ get; set; }

        /// <summary>
        /// <p>web应用数量</p>
        /// </summary>
        [JsonProperty("WebAppCount")]
        public ulong? WebAppCount{ get; set; }

        /// <summary>
        /// <p>有风险web应用数量</p>
        /// </summary>
        [JsonProperty("RiskWebAppCount")]
        public ulong? RiskWebAppCount{ get; set; }

        /// <summary>
        /// <p>弱口令数量</p>
        /// </summary>
        [JsonProperty("WeakPasswordCount")]
        public ulong? WeakPasswordCount{ get; set; }

        /// <summary>
        /// <p>漏洞数量</p>
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// <p>首次发现时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最近更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>实例类型名称</p>
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// <p>开放状态</p>
        /// </summary>
        [JsonProperty("DisplayStatus")]
        public string DisplayStatus{ get; set; }

        /// <summary>
        /// <p>端口状态</p>
        /// </summary>
        [JsonProperty("DisplayRiskType")]
        public string DisplayRiskType{ get; set; }

        /// <summary>
        /// <p>扫描任务状态</p>
        /// </summary>
        [JsonProperty("ScanTaskStatus")]
        public string ScanTaskStatus{ get; set; }

        /// <summary>
        /// <p>uuid</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>是否进行过安全体检</p>
        /// </summary>
        [JsonProperty("HasScan")]
        public string HasScan{ get; set; }

        /// <summary>
        /// <p>租户ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>租户ID字符串</p>
        /// </summary>
        [JsonProperty("AppIdStr")]
        public string AppIdStr{ get; set; }

        /// <summary>
        /// <p>记录ID</p>
        /// </summary>
        [JsonProperty("ExposureID")]
        public ulong? ExposureID{ get; set; }

        /// <summary>
        /// <p>端口开放数量</p>
        /// </summary>
        [JsonProperty("PortDetectCount")]
        public ulong? PortDetectCount{ get; set; }

        /// <summary>
        /// <p>端口开放结果</p>
        /// </summary>
        [JsonProperty("PortDetectResult")]
        public string PortDetectResult{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>待治理风险数量</p>
        /// </summary>
        [JsonProperty("ToGovernedRiskCount")]
        public ulong? ToGovernedRiskCount{ get; set; }

        /// <summary>
        /// <p>待治理风险内容</p>
        /// </summary>
        [JsonProperty("ToGovernedRiskContent")]
        public string ToGovernedRiskContent{ get; set; }

        /// <summary>
        /// <p>资产类型图标</p>
        /// </summary>
        [JsonProperty("AssetTypeIconURL")]
        public string AssetTypeIconURL{ get; set; }

        /// <summary>
        /// <p>资产类型3D图标</p>
        /// </summary>
        [JsonProperty("AssetTypeIconSolidURL")]
        public string AssetTypeIconSolidURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "CloudAccountName", this.CloudAccountName);
            this.SetParamSimple(map, prefix + "CloudAccountId", this.CloudAccountId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "AclType", this.AclType);
            this.SetParamSimple(map, prefix + "AclList", this.AclList);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PortServiceCount", this.PortServiceCount);
            this.SetParamSimple(map, prefix + "HighRiskPortServiceCount", this.HighRiskPortServiceCount);
            this.SetParamSimple(map, prefix + "WebAppCount", this.WebAppCount);
            this.SetParamSimple(map, prefix + "RiskWebAppCount", this.RiskWebAppCount);
            this.SetParamSimple(map, prefix + "WeakPasswordCount", this.WeakPasswordCount);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AssetTypeName", this.AssetTypeName);
            this.SetParamSimple(map, prefix + "DisplayStatus", this.DisplayStatus);
            this.SetParamSimple(map, prefix + "DisplayRiskType", this.DisplayRiskType);
            this.SetParamSimple(map, prefix + "ScanTaskStatus", this.ScanTaskStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "HasScan", this.HasScan);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppIdStr", this.AppIdStr);
            this.SetParamSimple(map, prefix + "ExposureID", this.ExposureID);
            this.SetParamSimple(map, prefix + "PortDetectCount", this.PortDetectCount);
            this.SetParamSimple(map, prefix + "PortDetectResult", this.PortDetectResult);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ToGovernedRiskCount", this.ToGovernedRiskCount);
            this.SetParamSimple(map, prefix + "ToGovernedRiskContent", this.ToGovernedRiskContent);
            this.SetParamSimple(map, prefix + "AssetTypeIconURL", this.AssetTypeIconURL);
            this.SetParamSimple(map, prefix + "AssetTypeIconSolidURL", this.AssetTypeIconSolidURL);
        }
    }
}

