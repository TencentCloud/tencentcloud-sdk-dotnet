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
        /// 集群状态，0:创建中，1:正常，2:删除中，3:已删除，5:创建失败，6: 删除失败
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
        /// 消息保留时间
        /// </summary>
        [JsonProperty("MessageRetentionTime")]
        public long? MessageRetentionTime{ get; set; }

        /// <summary>
        /// 最大存储容量
        /// </summary>
        [JsonProperty("MaxStorageCapacity")]
        public long? MaxStorageCapacity{ get; set; }


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
        }
    }
}

