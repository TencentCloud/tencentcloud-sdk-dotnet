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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternalTenant : AbstractModel
    {
        
        /// <summary>
        /// 虚拟集群ID
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 虚拟集群名称
        /// </summary>
        [JsonProperty("TenantName")]
        public string TenantName{ get; set; }

        /// <summary>
        /// 客户UIN
        /// </summary>
        [JsonProperty("CustomerUin")]
        public string CustomerUin{ get; set; }

        /// <summary>
        /// 客户的APPID
        /// </summary>
        [JsonProperty("CustomerAppId")]
        public string CustomerAppId{ get; set; }

        /// <summary>
        /// 物理集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群协议类型，支持的值为TDMQ，ROCKETMQ，AMQP，CMQ
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 命名空间配额
        /// </summary>
        [JsonProperty("MaxNamespaces")]
        public long? MaxNamespaces{ get; set; }

        /// <summary>
        /// 已使用命名空间配额
        /// </summary>
        [JsonProperty("UsedNamespaces")]
        public long? UsedNamespaces{ get; set; }

        /// <summary>
        /// Topic配额
        /// </summary>
        [JsonProperty("MaxTopics")]
        public long? MaxTopics{ get; set; }

        /// <summary>
        /// 已使用Topic配额
        /// </summary>
        [JsonProperty("UsedTopics")]
        public long? UsedTopics{ get; set; }

        /// <summary>
        /// Topic分区数配额
        /// </summary>
        [JsonProperty("MaxPartitions")]
        public long? MaxPartitions{ get; set; }

        /// <summary>
        /// 已使用Topic分区数配额
        /// </summary>
        [JsonProperty("UsedPartitions")]
        public long? UsedPartitions{ get; set; }

        /// <summary>
        /// 存储配额, byte为单位
        /// </summary>
        [JsonProperty("MaxMsgBacklogSize")]
        public ulong? MaxMsgBacklogSize{ get; set; }

        /// <summary>
        /// 命名空间最大生产TPS
        /// </summary>
        [JsonProperty("MaxPublishTps")]
        public ulong? MaxPublishTps{ get; set; }

        /// <summary>
        /// 消息最大保留时间，秒为单位
        /// </summary>
        [JsonProperty("MaxRetention")]
        public ulong? MaxRetention{ get; set; }

        /// <summary>
        /// 创建时间，毫秒为单位
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 修改时间，毫秒为单位
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 命名空间最大消费TPS
        /// </summary>
        [JsonProperty("MaxDispatchTps")]
        public ulong? MaxDispatchTps{ get; set; }

        /// <summary>
        /// 命名空间最大消费带宽，byte为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDispatchRateInBytes")]
        public ulong? MaxDispatchRateInBytes{ get; set; }

        /// <summary>
        /// 命名空间最大生产带宽，byte为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxPublishRateInBytes")]
        public ulong? MaxPublishRateInBytes{ get; set; }

        /// <summary>
        /// 消息最大保留空间，MB为单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRetentionSizeInMB")]
        public ulong? MaxRetentionSizeInMB{ get; set; }

        /// <summary>
        /// public Access Enabled
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAccessEnabled")]
        public bool? PublicAccessEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "TenantName", this.TenantName);
            this.SetParamSimple(map, prefix + "CustomerUin", this.CustomerUin);
            this.SetParamSimple(map, prefix + "CustomerAppId", this.CustomerAppId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MaxNamespaces", this.MaxNamespaces);
            this.SetParamSimple(map, prefix + "UsedNamespaces", this.UsedNamespaces);
            this.SetParamSimple(map, prefix + "MaxTopics", this.MaxTopics);
            this.SetParamSimple(map, prefix + "UsedTopics", this.UsedTopics);
            this.SetParamSimple(map, prefix + "MaxPartitions", this.MaxPartitions);
            this.SetParamSimple(map, prefix + "UsedPartitions", this.UsedPartitions);
            this.SetParamSimple(map, prefix + "MaxMsgBacklogSize", this.MaxMsgBacklogSize);
            this.SetParamSimple(map, prefix + "MaxPublishTps", this.MaxPublishTps);
            this.SetParamSimple(map, prefix + "MaxRetention", this.MaxRetention);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "MaxDispatchTps", this.MaxDispatchTps);
            this.SetParamSimple(map, prefix + "MaxDispatchRateInBytes", this.MaxDispatchRateInBytes);
            this.SetParamSimple(map, prefix + "MaxPublishRateInBytes", this.MaxPublishRateInBytes);
            this.SetParamSimple(map, prefix + "MaxRetentionSizeInMB", this.MaxRetentionSizeInMB);
            this.SetParamSimple(map, prefix + "PublicAccessEnabled", this.PublicAccessEnabled);
        }
    }
}

