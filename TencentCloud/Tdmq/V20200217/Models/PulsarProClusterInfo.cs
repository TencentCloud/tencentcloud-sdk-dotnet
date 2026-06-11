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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PulsarProClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群Id。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称。</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>说明信息。</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>集群状态，0:创建中，1:正常，2:隔离</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>集群版本</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>节点分布情况</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeDistribution")]
        public InstanceNodeDistribution[] NodeDistribution{ get; set; }

        /// <summary>
        /// <p>最大储存容量，单位：MB</p>
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// <p>是否可以修改路由</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanEditRoute")]
        public bool? CanEditRoute{ get; set; }

        /// <summary>
        /// <p>代表是专业版和小规格专业版的不同计费规格PULSAR.P1固定存储PULSAR.P2弹性存储</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingLabelVersion")]
        public string BillingLabelVersion{ get; set; }

        /// <summary>
        /// <p>实例到期时间戳，毫秒级精度。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>是否开启自动创建主题<br>true就是开启了，false是关闭</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoCreateTopicStatus")]
        public bool? AutoCreateTopicStatus{ get; set; }

        /// <summary>
        /// <p>自动创建主题的默认分区数，如果没开启就是0</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultPartitionNumber")]
        public long? DefaultPartitionNumber{ get; set; }

        /// <summary>
        /// <p>用户自定义的租户别名，如果没有，会复用专业集群 ID</p>
        /// </summary>
        [JsonProperty("Tenant")]
        public string Tenant{ get; set; }

        /// <summary>
        /// <p>删除保护开关标识</p>
        /// </summary>
        [JsonProperty("DeleteProtection")]
        public long? DeleteProtection{ get; set; }

        /// <summary>
        /// <p>是否开启弹性tps</p><p>枚举值：</p><ul><li>0： 关闭</li><li>1： 开启</li></ul>
        /// </summary>
        [JsonProperty("ElasticTpsEnabled")]
        public long? ElasticTpsEnabled{ get; set; }

        /// <summary>
        /// <p>是否开启数据加密</p><p>枚举值：</p><ul><li>0： 关闭数据加密</li><li>1： 开启数据加密</li></ul>
        /// </summary>
        [JsonProperty("EncryptionStatus")]
        public long? EncryptionStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "NodeDistribution.", this.NodeDistribution);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "CanEditRoute", this.CanEditRoute);
            this.SetParamSimple(map, prefix + "BillingLabelVersion", this.BillingLabelVersion);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoCreateTopicStatus", this.AutoCreateTopicStatus);
            this.SetParamSimple(map, prefix + "DefaultPartitionNumber", this.DefaultPartitionNumber);
            this.SetParamSimple(map, prefix + "Tenant", this.Tenant);
            this.SetParamSimple(map, prefix + "DeleteProtection", this.DeleteProtection);
            this.SetParamSimple(map, prefix + "ElasticTpsEnabled", this.ElasticTpsEnabled);
            this.SetParamSimple(map, prefix + "EncryptionStatus", this.EncryptionStatus);
        }
    }
}

