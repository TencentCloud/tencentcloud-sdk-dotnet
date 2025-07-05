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

    public class DescribeComplianceAssetPolicyItemListRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户资产的ID。
        /// </summary>
        [JsonProperty("CustomerAssetId")]
        public ulong? CustomerAssetId{ get; set; }

        /// <summary>
        /// 起始偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 要获取的数据量，默认为10，最大为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 过滤器列表。Name字段支持
        /// RiskLevel， AppId
        /// </summary>
        [JsonProperty("Filters")]
        public ComplianceFilters[] Filters{ get; set; }

        /// <summary>
        /// 资产类型 <li>ASSET_CONTAINER Docker容器</li> <li>ASSET_IMAGE Docker镜像</li> <li>ASSET_HOST Docker主机</li> <li>ASSET_K8S Kubernetes</li> <li>ASSET_CONTAINERD Containerd主机</li> <li>ASSET_CONTAINERD_CONTAINER Containerd容器</li>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerAssetId", this.CustomerAssetId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
        }
    }
}

