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

    public class BaselineItemRiskRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>风险记录主键 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>命中风险的主机资产信息，无数据时为 null。</p>
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
        /// <p>命中资产的资产类型。取值：</p><ul><li>HOST：主机</li><li>CLUSTER：集群</li><li>POD：Pod</li><li>CONTAINER：容器</li><li>IMAGE：镜像</li></ul>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>风险检测结果状态。取值：</p><ul><li>CHECKING：检测中</li><li>PASS：通过</li><li>NOT_PASS：未通过</li><li>CHECK_FAILED：检测失败</li><li>NOT_INVOLVED：不涉及</li><li>IGNORED：已忽略</li></ul>
        /// </summary>
        [JsonProperty("ResultStatus")]
        public string ResultStatus{ get; set; }

        /// <summary>
        /// <p>最近检查时间。</p>
        /// </summary>
        [JsonProperty("LatestCheckTime")]
        public string LatestCheckTime{ get; set; }

        /// <summary>
        /// <p>基线检测项 ID。</p>
        /// </summary>
        [JsonProperty("ItemID")]
        public ulong? ItemID{ get; set; }

        /// <summary>
        /// <p>风险事件 ID，用于唯一标识该风险记录。</p>
        /// </summary>
        [JsonProperty("RiskID")]
        public string RiskID{ get; set; }

        /// <summary>
        /// <p>本次扫描的全局 JobID。</p>
        /// </summary>
        [JsonProperty("JobID")]
        public string JobID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamObj(map, prefix + "HostInfo.", this.HostInfo);
            this.SetParamObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ResultStatus", this.ResultStatus);
            this.SetParamSimple(map, prefix + "LatestCheckTime", this.LatestCheckTime);
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "JobID", this.JobID);
        }
    }
}

