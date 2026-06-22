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

    public class RocketMQClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>地域信息</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>创建时间，毫秒为单位</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>集群说明信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>公网接入地址</p>
        /// </summary>
        [JsonProperty("PublicEndPoint")]
        public string PublicEndPoint{ get; set; }

        /// <summary>
        /// <p>VPC接入地址</p>
        /// </summary>
        [JsonProperty("VpcEndPoint")]
        public string VpcEndPoint{ get; set; }

        /// <summary>
        /// <p>是否支持命名空间接入点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportNamespaceEndpoint")]
        public bool? SupportNamespaceEndpoint{ get; set; }

        /// <summary>
        /// <p>VPC信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vpcs")]
        public VpcConfig[] Vpcs{ get; set; }

        /// <summary>
        /// <p>是否为专享实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// <p>Rocketmq集群标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RocketMQFlag")]
        public bool? RocketMQFlag{ get; set; }

        /// <summary>
        /// <p>计费状态，1表示正常，2表示已停服，3表示已销毁</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>欠费停服时间，毫秒为单位</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolateTime")]
        public long? IsolateTime{ get; set; }

        /// <summary>
        /// <p>HTTP协议公网接入地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpPublicEndpoint")]
        public string HttpPublicEndpoint{ get; set; }

        /// <summary>
        /// <p>HTTP协议VPC接入地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpVpcEndpoint")]
        public string HttpVpcEndpoint{ get; set; }

        /// <summary>
        /// <p>TCP内部接入地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternalEndpoint")]
        public string InternalEndpoint{ get; set; }

        /// <summary>
        /// <p>HTTP协议内部接入地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpInternalEndpoint")]
        public string HttpInternalEndpoint{ get; set; }

        /// <summary>
        /// <p>是否开启ACL鉴权，专享实例支持关闭</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AclEnabled")]
        public bool? AclEnabled{ get; set; }

        /// <summary>
        /// <p>公网CLB实例ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicClbId")]
        public string PublicClbId{ get; set; }

        /// <summary>
        /// <p>vip</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>所属VPC</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>是否支持迁移</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportMigration")]
        public bool? SupportMigration{ get; set; }

        /// <summary>
        /// <p>实例状态，0表示创建中，1表示正常，2表示隔离中，3表示已销毁，4 - 异常, 5 - 发货失败，6 - 变配中，7 - 变配失败</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// <p>集群所属可用区，表明集群归属的可用区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>集群节点所在的可用区，若该集群为跨可用区集群，则包含该集群节点所在的多个可用区。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>是否已冻结</p>
        /// </summary>
        [JsonProperty("IsFrozen")]
        public bool? IsFrozen{ get; set; }

        /// <summary>
        /// <p>是否开启自动创建主题</p>
        /// </summary>
        [JsonProperty("AutoCreateTopicEnabled")]
        public bool? AutoCreateTopicEnabled{ get; set; }

        /// <summary>
        /// <p>是否开启集群Admin能力</p>
        /// </summary>
        [JsonProperty("AdminFeatureEnabled")]
        public bool? AdminFeatureEnabled{ get; set; }

        /// <summary>
        /// <p>Admin AK</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminAccessKey")]
        public string AdminAccessKey{ get; set; }

        /// <summary>
        /// <p>Admin SK</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminSecretKey")]
        public string AdminSecretKey{ get; set; }

        /// <summary>
        /// <p>是否开启删除保护</p>
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }

        /// <summary>
        /// <p>是否开启自动创建消费组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoCreateConsumeGroupEnabled")]
        public bool? AutoCreateConsumeGroupEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PublicEndPoint", this.PublicEndPoint);
            this.SetParamSimple(map, prefix + "VpcEndPoint", this.VpcEndPoint);
            this.SetParamSimple(map, prefix + "SupportNamespaceEndpoint", this.SupportNamespaceEndpoint);
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "RocketMQFlag", this.RocketMQFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "HttpPublicEndpoint", this.HttpPublicEndpoint);
            this.SetParamSimple(map, prefix + "HttpVpcEndpoint", this.HttpVpcEndpoint);
            this.SetParamSimple(map, prefix + "InternalEndpoint", this.InternalEndpoint);
            this.SetParamSimple(map, prefix + "HttpInternalEndpoint", this.HttpInternalEndpoint);
            this.SetParamSimple(map, prefix + "AclEnabled", this.AclEnabled);
            this.SetParamSimple(map, prefix + "PublicClbId", this.PublicClbId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SupportMigration", this.SupportMigration);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "IsFrozen", this.IsFrozen);
            this.SetParamSimple(map, prefix + "AutoCreateTopicEnabled", this.AutoCreateTopicEnabled);
            this.SetParamSimple(map, prefix + "AdminFeatureEnabled", this.AdminFeatureEnabled);
            this.SetParamSimple(map, prefix + "AdminAccessKey", this.AdminAccessKey);
            this.SetParamSimple(map, prefix + "AdminSecretKey", this.AdminSecretKey);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
            this.SetParamSimple(map, prefix + "AutoCreateConsumeGroupEnabled", this.AutoCreateConsumeGroupEnabled);
        }
    }
}

