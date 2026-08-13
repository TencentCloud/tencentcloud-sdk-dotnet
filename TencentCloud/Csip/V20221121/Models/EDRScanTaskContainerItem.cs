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

    public class EDRScanTaskContainerItem : AbstractModel
    {
        
        /// <summary>
        /// <p>容器ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContainerID")]
        public string ContainerID{ get; set; }

        /// <summary>
        /// <p>容器名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>Pod名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>资产所属账号名称（后端富化）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>所属账号AppId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>云类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>扫描状态：WAIT/SCANNING/FINISHED/FAILED</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>告警数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// <p>失败原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>解决方案</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixSuggestion")]
        public string FixSuggestion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContainerID", this.ContainerID);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "FixSuggestion", this.FixSuggestion);
        }
    }
}

