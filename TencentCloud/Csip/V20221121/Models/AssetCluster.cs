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

    public class AssetCluster : AbstractModel
    {
        
        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 租户uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 租户昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 集群创建时间
        /// </summary>
        [JsonProperty("InstanceCreateTime")]
        public string InstanceCreateTime{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 集群防护状态，左边枚举,右边为显示
        /// 集群防护状态 
        /// 0:未接入
        /// 1:未防护 
        /// 2:部分防护 
        /// 3:防护中 
        /// 4:接入异常 
        /// 5:接入中 
        /// 6:卸载中 
        /// 7:卸载异常
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public long? ProtectStatus{ get; set; }

        /// <summary>
        /// 接入信息，不为空表示有接入异常信息
        /// </summary>
        [JsonProperty("ProtectInfo")]
        public string ProtectInfo{ get; set; }

        /// <summary>
        /// 私有网络id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// kubernetes版本
        /// </summary>
        [JsonProperty("KubernetesVersion")]
        public string KubernetesVersion{ get; set; }

        /// <summary>
        /// 运行时组件
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 运行时组件版本
        /// </summary>
        [JsonProperty("ComponentVersion")]
        public string ComponentVersion{ get; set; }

        /// <summary>
        /// 组件状态
        /// </summary>
        [JsonProperty("ComponentStatus")]
        public string ComponentStatus{ get; set; }

        /// <summary>
        /// 体检时间
        /// </summary>
        [JsonProperty("CheckTime")]
        public string CheckTime{ get; set; }

        /// <summary>
        /// 关联主机数
        /// </summary>
        [JsonProperty("MachineCount")]
        public long? MachineCount{ get; set; }

        /// <summary>
        /// 关联pod数
        /// </summary>
        [JsonProperty("PodCount")]
        public long? PodCount{ get; set; }

        /// <summary>
        /// 关联service数
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// 漏洞风险
        /// </summary>
        [JsonProperty("VulRisk")]
        public long? VulRisk{ get; set; }

        /// <summary>
        /// 配置风险
        /// </summary>
        [JsonProperty("CFGRisk")]
        public long? CFGRisk{ get; set; }

        /// <summary>
        /// 体检数
        /// </summary>
        [JsonProperty("CheckCount")]
        public long? CheckCount{ get; set; }

        /// <summary>
        /// 是否核心：1:核心，2:非核心
        /// </summary>
        [JsonProperty("IsCore")]
        public long? IsCore{ get; set; }

        /// <summary>
        /// 是否新资产 1新
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// 云资产类型：0：腾讯云，1：aws，2：azure
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "InstanceCreateTime", this.InstanceCreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "ProtectInfo", this.ProtectInfo);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "KubernetesVersion", this.KubernetesVersion);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "ComponentVersion", this.ComponentVersion);
            this.SetParamSimple(map, prefix + "ComponentStatus", this.ComponentStatus);
            this.SetParamSimple(map, prefix + "CheckTime", this.CheckTime);
            this.SetParamSimple(map, prefix + "MachineCount", this.MachineCount);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "VulRisk", this.VulRisk);
            this.SetParamSimple(map, prefix + "CFGRisk", this.CFGRisk);
            this.SetParamSimple(map, prefix + "CheckCount", this.CheckCount);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

