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

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// 集群Id。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 说明信息。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 接入点数量
        /// </summary>
        [JsonProperty("EndPointNum")]
        public long? EndPointNum{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 集群是否健康，1表示健康，0表示异常
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// 集群健康信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthyInfo")]
        public string HealthyInfo{ get; set; }

        /// <summary>
        /// 集群状态，0:创建中，1:正常，2:销毁中，3:已删除，4: 隔离中，5:创建失败，6: 删除失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 最大命名空间数量
        /// </summary>
        [JsonProperty("MaxNamespaceNum")]
        public long? MaxNamespaceNum{ get; set; }

        /// <summary>
        /// 最大Topic数量
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public long? MaxTopicNum{ get; set; }

        /// <summary>
        /// 最大QPS
        /// </summary>
        [JsonProperty("MaxQps")]
        public long? MaxQps{ get; set; }

        /// <summary>
        /// 最大消息保留时间，秒为单位
        /// </summary>
        [JsonProperty("MessageRetentionTime")]
        public long? MessageRetentionTime{ get; set; }

        /// <summary>
        /// 最大存储容量
        /// </summary>
        [JsonProperty("MaxStorageCapacity")]
        public long? MaxStorageCapacity{ get; set; }

        /// <summary>
        /// 集群版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 公网访问接入点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicEndPoint")]
        public string PublicEndPoint{ get; set; }

        /// <summary>
        /// 旧的公网访问接入点
        /// </summary>
        [JsonProperty("OldPublicEndPoint")]
        public string OldPublicEndPoint{ get; set; }

        /// <summary>
        /// VPC访问接入点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcEndPoint")]
        public string VpcEndPoint{ get; set; }

        /// <summary>
        /// 旧的VPC访问接入点
        /// </summary>
        [JsonProperty("OldVpcEndPoint")]
        public string OldVpcEndPoint{ get; set; }

        /// <summary>
        /// 命名空间数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceNum")]
        public long? NamespaceNum{ get; set; }

        /// <summary>
        /// 已使用存储限制，MB为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedStorageBudget")]
        public long? UsedStorageBudget{ get; set; }

        /// <summary>
        /// 最大生产消息速率，以条数为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxPublishRateInMessages")]
        public long? MaxPublishRateInMessages{ get; set; }

        /// <summary>
        /// 最大推送消息速率，以条数为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDispatchRateInMessages")]
        public long? MaxDispatchRateInMessages{ get; set; }

        /// <summary>
        /// 最大生产消息速率，以字节为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxPublishRateInBytes")]
        public long? MaxPublishRateInBytes{ get; set; }

        /// <summary>
        /// 最大推送消息速率，以字节为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDispatchRateInBytes")]
        public long? MaxDispatchRateInBytes{ get; set; }

        /// <summary>
        /// 已创建主题数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// 最长消息延时，以秒为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxMessageDelayInSeconds")]
        public long? MaxMessageDelayInSeconds{ get; set; }

        /// <summary>
        /// 是否开启公网访问，不填时默认开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAccessEnabled")]
        public bool? PublicAccessEnabled{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 旧的支撑网 Pulsar 接入点
        /// </summary>
        [JsonProperty("OldInternalPulsarEndPoint")]
        public string OldInternalPulsarEndPoint{ get; set; }

        /// <summary>
        /// 旧的支撑网 HTTP 接入点
        /// </summary>
        [JsonProperty("OldInternalHttpEndPoint")]
        public string OldInternalHttpEndPoint{ get; set; }

        /// <summary>
        /// 计费模式：
        /// 0: 按量计费
        /// 1: 包年包月
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 项目名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 是否支持升级专业版实例
        /// </summary>
        [JsonProperty("UpgradeProInstance")]
        public bool? UpgradeProInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "EndPointNum", this.EndPointNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "HealthyInfo", this.HealthyInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MaxNamespaceNum", this.MaxNamespaceNum);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
            this.SetParamSimple(map, prefix + "MaxQps", this.MaxQps);
            this.SetParamSimple(map, prefix + "MessageRetentionTime", this.MessageRetentionTime);
            this.SetParamSimple(map, prefix + "MaxStorageCapacity", this.MaxStorageCapacity);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "PublicEndPoint", this.PublicEndPoint);
            this.SetParamSimple(map, prefix + "OldPublicEndPoint", this.OldPublicEndPoint);
            this.SetParamSimple(map, prefix + "VpcEndPoint", this.VpcEndPoint);
            this.SetParamSimple(map, prefix + "OldVpcEndPoint", this.OldVpcEndPoint);
            this.SetParamSimple(map, prefix + "NamespaceNum", this.NamespaceNum);
            this.SetParamSimple(map, prefix + "UsedStorageBudget", this.UsedStorageBudget);
            this.SetParamSimple(map, prefix + "MaxPublishRateInMessages", this.MaxPublishRateInMessages);
            this.SetParamSimple(map, prefix + "MaxDispatchRateInMessages", this.MaxDispatchRateInMessages);
            this.SetParamSimple(map, prefix + "MaxPublishRateInBytes", this.MaxPublishRateInBytes);
            this.SetParamSimple(map, prefix + "MaxDispatchRateInBytes", this.MaxDispatchRateInBytes);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "MaxMessageDelayInSeconds", this.MaxMessageDelayInSeconds);
            this.SetParamSimple(map, prefix + "PublicAccessEnabled", this.PublicAccessEnabled);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OldInternalPulsarEndPoint", this.OldInternalPulsarEndPoint);
            this.SetParamSimple(map, prefix + "OldInternalHttpEndPoint", this.OldInternalHttpEndPoint);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "UpgradeProInstance", this.UpgradeProInstance);
        }
    }
}

