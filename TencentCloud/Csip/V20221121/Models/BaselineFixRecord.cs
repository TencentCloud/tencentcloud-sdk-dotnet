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

    public class BaselineFixRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>修复记录主键 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>租户 AppID。</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>被修复的检测项基础信息。</p>
        /// </summary>
        [JsonProperty("ItemInfo")]
        public BaselineItem ItemInfo{ get; set; }

        /// <summary>
        /// <p>本次修复涉及的主机资产信息，无数据时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostInfo")]
        public BaselineHostAsset HostInfo{ get; set; }

        /// <summary>
        /// <p>集群资产信息，无数据时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public BaselineClusterAsset ClusterInfo{ get; set; }

        /// <summary>
        /// <p>资产类型：HOST（主机）、CLUSTER（容器集群）。</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>修复完成时间。</p>
        /// </summary>
        [JsonProperty("FixTime")]
        public string FixTime{ get; set; }

        /// <summary>
        /// <p>该风险首次被发现的时间。</p>
        /// </summary>
        [JsonProperty("DiscoveryTime")]
        public string DiscoveryTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamObj(map, prefix + "ItemInfo.", this.ItemInfo);
            this.SetParamObj(map, prefix + "HostInfo.", this.HostInfo);
            this.SetParamObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "FixTime", this.FixTime);
            this.SetParamSimple(map, prefix + "DiscoveryTime", this.DiscoveryTime);
        }
    }
}

