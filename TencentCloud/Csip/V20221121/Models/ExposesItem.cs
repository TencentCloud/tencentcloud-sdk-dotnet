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
        /// 云厂商
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// 云账号名称
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// 云账号
        /// </summary>
        [JsonProperty("CloudAccountId")]
        public string CloudAccountId{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 端口或者端口范围
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 开放
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// acl类型
        /// </summary>
        [JsonProperty("AclType")]
        public string AclType{ get; set; }

        /// <summary>
        /// acl列表
        /// </summary>
        [JsonProperty("AclList")]
        public string AclList{ get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 端口服务数量
        /// </summary>
        [JsonProperty("PortServiceCount")]
        public ulong? PortServiceCount{ get; set; }

        /// <summary>
        /// 高危端口数量
        /// </summary>
        [JsonProperty("HighRiskPortServiceCount")]
        public ulong? HighRiskPortServiceCount{ get; set; }

        /// <summary>
        /// web应用数量
        /// </summary>
        [JsonProperty("WebAppCount")]
        public ulong? WebAppCount{ get; set; }

        /// <summary>
        /// 有风险web应用数量
        /// </summary>
        [JsonProperty("RiskWebAppCount")]
        public ulong? RiskWebAppCount{ get; set; }

        /// <summary>
        /// 弱口令数量
        /// </summary>
        [JsonProperty("WeakPasswordCount")]
        public ulong? WeakPasswordCount{ get; set; }

        /// <summary>
        /// 漏洞数量
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// 首次发现时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 实例类型名称
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// 开放状态
        /// </summary>
        [JsonProperty("DisplayStatus")]
        public string DisplayStatus{ get; set; }

        /// <summary>
        /// 端口状态
        /// </summary>
        [JsonProperty("DisplayRiskType")]
        public string DisplayRiskType{ get; set; }

        /// <summary>
        /// 扫描任务状态
        /// </summary>
        [JsonProperty("ScanTaskStatus")]
        public string ScanTaskStatus{ get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 是否进行过安全体检
        /// </summary>
        [JsonProperty("HasScan")]
        public string HasScan{ get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 租户ID字符串
        /// </summary>
        [JsonProperty("AppIdStr")]
        public string AppIdStr{ get; set; }


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
        }
    }
}

