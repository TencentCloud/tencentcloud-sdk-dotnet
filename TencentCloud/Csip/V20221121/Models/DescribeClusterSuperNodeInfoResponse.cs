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

    public class DescribeClusterSuperNodeInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>所属地域 code（原样，如 ap-chengdu）。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>地域中文名（如 西南地区（成都）；由地域 code 经字典翻译得到）。</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>地域英文名（如 Southwest China (Chengdu)；由地域 code 经字典翻译得到）。</p>
        /// </summary>
        [JsonProperty("RegionNameEn")]
        public string RegionNameEn{ get; set; }

        /// <summary>
        /// <p>可用区（中文名，由可用区 code 经字典翻译得到）。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>资产最后更新时间。<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式，UTC时区）</p>
        /// </summary>
        [JsonProperty("AssetSyncTime")]
        public string AssetSyncTime{ get; set; }

        /// <summary>
        /// <p>节点来源（所属集群类型）。<br>枚举值：<br>TKE_MANAGED_CLUSTER：腾讯云标准集群<br>TKE_INDEPENDENT_CLUSTER：腾讯云标准集群（Master自维护）<br>TKE_SERVERLESS_CLUSTER：腾讯云Serverless集群<br>TKE_EDGE_CLUSTER：腾讯云边缘集群<br>SELF_BUILT：腾讯云内自建集群<br>SELF_BUILT_OTHER：非腾讯云自建集群（混合云）</p>
        /// </summary>
        [JsonProperty("NodeSource")]
        public string NodeSource{ get; set; }

        /// <summary>
        /// <p>子网名称。</p>
        /// </summary>
        [JsonProperty("SubNetName")]
        public string SubNetName{ get; set; }

        /// <summary>
        /// <p>子网 ID。</p>
        /// </summary>
        [JsonProperty("SubNetId")]
        public string SubNetId{ get; set; }

        /// <summary>
        /// <p>子网网段（CIDR）。</p>
        /// </summary>
        [JsonProperty("SubNetCIDR")]
        public string SubNetCIDR{ get; set; }

        /// <summary>
        /// <p>核数（由 cpu_request 除以 1000 得到）。<br>单位：核</p>
        /// </summary>
        [JsonProperty("CoresCount")]
        public long? CoresCount{ get; set; }

        /// <summary>
        /// <p>所属集群名称。</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>所属集群 ID。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>所属集群运行状态。<br>枚举值：<br>Running：运行中<br>Exception：异常<br>Unknown：未知<br>Creating：创建中<br>Destroyed：已销毁</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Kubernetes 版本。</p>
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>Kubelet 版本。</p>
        /// </summary>
        [JsonProperty("KubeletVersion")]
        public string KubeletVersion{ get; set; }

        /// <summary>
        /// <p>超级节点所属账号APPID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>超级节点实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>超级节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>VPCID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionNameEn", this.RegionNameEn);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AssetSyncTime", this.AssetSyncTime);
            this.SetParamSimple(map, prefix + "NodeSource", this.NodeSource);
            this.SetParamSimple(map, prefix + "SubNetName", this.SubNetName);
            this.SetParamSimple(map, prefix + "SubNetId", this.SubNetId);
            this.SetParamSimple(map, prefix + "SubNetCIDR", this.SubNetCIDR);
            this.SetParamSimple(map, prefix + "CoresCount", this.CoresCount);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "KubeletVersion", this.KubeletVersion);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

