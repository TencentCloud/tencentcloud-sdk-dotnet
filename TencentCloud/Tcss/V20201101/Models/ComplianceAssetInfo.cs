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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceAssetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>客户资产的ID。</p>
        /// </summary>
        [JsonProperty("CustomerAssetId")]
        public ulong? CustomerAssetId{ get; set; }

        /// <summary>
        /// <p>资产类别。</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>资产的名称。</p>
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// <p>当资产为镜像时，这个字段为镜像Tag。</p>
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// <p>资产所在的主机IP。</p>
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// <p>资产所属的节点的名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>检测状态</p><p>CHECK_INIT, 待检测</p><p>CHECK_RUNNING, 检测中</p><p>CHECK_FINISHED, 检测完成</p><p>CHECK_FAILED, 检测失败</p>
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// <p>此类资产通过的检测项的数目。</p>
        /// </summary>
        [JsonProperty("PassedPolicyItemCount")]
        public ulong? PassedPolicyItemCount{ get; set; }

        /// <summary>
        /// <p>此类资产未通过的检测的数目。</p>
        /// </summary>
        [JsonProperty("FailedPolicyItemCount")]
        public ulong? FailedPolicyItemCount{ get; set; }

        /// <summary>
        /// <p>上次检测的时间。</p>
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// <p>检测结果：<br>RESULT_FAILED: 未通过。<br>RESULT_PASSED: 通过。</p>
        /// </summary>
        [JsonProperty("CheckResult")]
        public string CheckResult{ get; set; }

        /// <summary>
        /// <p>主机节点的实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>镜像仓库信息</p>
        /// </summary>
        [JsonProperty("ImageRegistryInfo")]
        public ImageRegistryInfo ImageRegistryInfo{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>资产唯一ID</p><p>默认值：-</p>
        /// </summary>
        [JsonProperty("AssetUniqueID")]
        public string AssetUniqueID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerAssetId", this.CustomerAssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "PassedPolicyItemCount", this.PassedPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedPolicyItemCount", this.FailedPolicyItemCount);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "ImageRegistryInfo.", this.ImageRegistryInfo);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AssetUniqueID", this.AssetUniqueID);
        }
    }
}

