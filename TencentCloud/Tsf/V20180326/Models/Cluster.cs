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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群所属私有网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 集群状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 集群CIDR
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// 集群总CPU，单位: 核
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterTotalCpu")]
        public float? ClusterTotalCpu{ get; set; }

        /// <summary>
        /// 集群总内存，单位: G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterTotalMem")]
        public float? ClusterTotalMem{ get; set; }

        /// <summary>
        /// 集群已使用CPU，单位: 核
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterUsedCpu")]
        public float? ClusterUsedCpu{ get; set; }

        /// <summary>
        /// 集群已使用内存，单位: G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterUsedMem")]
        public float? ClusterUsedMem{ get; set; }

        /// <summary>
        /// 集群机器实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 集群可用的机器实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunInstanceCount")]
        public long? RunInstanceCount{ get; set; }

        /// <summary>
        /// 集群正常状态的机器实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NormalInstanceCount")]
        public long? NormalInstanceCount{ get; set; }

        /// <summary>
        /// 删除标记：true：可以删除；false：不可删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 集群所属TSF地域ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TsfRegionId")]
        public string TsfRegionId{ get; set; }

        /// <summary>
        /// 集群所属TSF地域名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TsfRegionName")]
        public string TsfRegionName{ get; set; }

        /// <summary>
        /// 集群所属TSF可用区ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TsfZoneId")]
        public string TsfZoneId{ get; set; }

        /// <summary>
        /// 集群所属TSF可用区名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TsfZoneName")]
        public string TsfZoneName{ get; set; }

        /// <summary>
        /// 集群不可删除的原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteFlagReason")]
        public string DeleteFlagReason{ get; set; }

        /// <summary>
        /// 集群最大CPU限制，单位：核
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterLimitCpu")]
        public float? ClusterLimitCpu{ get; set; }

        /// <summary>
        /// 集群最大内存限制，单位：G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterLimitMem")]
        public float? ClusterLimitMem{ get; set; }

        /// <summary>
        /// 集群可用的服务实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunServiceInstanceCount")]
        public long? RunServiceInstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "ClusterTotalCpu", this.ClusterTotalCpu);
            this.SetParamSimple(map, prefix + "ClusterTotalMem", this.ClusterTotalMem);
            this.SetParamSimple(map, prefix + "ClusterUsedCpu", this.ClusterUsedCpu);
            this.SetParamSimple(map, prefix + "ClusterUsedMem", this.ClusterUsedMem);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "RunInstanceCount", this.RunInstanceCount);
            this.SetParamSimple(map, prefix + "NormalInstanceCount", this.NormalInstanceCount);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TsfRegionId", this.TsfRegionId);
            this.SetParamSimple(map, prefix + "TsfRegionName", this.TsfRegionName);
            this.SetParamSimple(map, prefix + "TsfZoneId", this.TsfZoneId);
            this.SetParamSimple(map, prefix + "TsfZoneName", this.TsfZoneName);
            this.SetParamSimple(map, prefix + "DeleteFlagReason", this.DeleteFlagReason);
            this.SetParamSimple(map, prefix + "ClusterLimitCpu", this.ClusterLimitCpu);
            this.SetParamSimple(map, prefix + "ClusterLimitMem", this.ClusterLimitMem);
            this.SetParamSimple(map, prefix + "RunServiceInstanceCount", this.RunServiceInstanceCount);
        }
    }
}

