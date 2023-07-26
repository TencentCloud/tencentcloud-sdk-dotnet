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

    public class RabbitMQClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 地域信息
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 创建时间，毫秒为单位
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 集群说明信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// VPC及网络信息
        /// </summary>
        [JsonProperty("Vpcs")]
        public VpcEndpointInfo[] Vpcs{ get; set; }

        /// <summary>
        /// 可用区信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// 虚拟主机数量
        /// </summary>
        [JsonProperty("VirtualHostNumber")]
        public long? VirtualHostNumber{ get; set; }

        /// <summary>
        /// 队列数量
        /// </summary>
        [JsonProperty("QueueNumber")]
        public long? QueueNumber{ get; set; }

        /// <summary>
        /// 每秒生产消息数 单位：条/秒
        /// </summary>
        [JsonProperty("MessagePublishRate")]
        public float? MessagePublishRate{ get; set; }

        /// <summary>
        /// 堆积消息数 单位：条
        /// </summary>
        [JsonProperty("MessageStackNumber")]
        public long? MessageStackNumber{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// Channel数量
        /// </summary>
        [JsonProperty("ChannelNumber")]
        public long? ChannelNumber{ get; set; }

        /// <summary>
        /// Connection数量
        /// </summary>
        [JsonProperty("ConnectionNumber")]
        public long? ConnectionNumber{ get; set; }

        /// <summary>
        /// Consumer数量
        /// </summary>
        [JsonProperty("ConsumerNumber")]
        public long? ConsumerNumber{ get; set; }

        /// <summary>
        /// Exchang数量
        /// </summary>
        [JsonProperty("ExchangeNumber")]
        public long? ExchangeNumber{ get; set; }

        /// <summary>
        /// 集群异常。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExceptionInformation")]
        public string ExceptionInformation{ get; set; }

        /// <summary>
        /// 实例状态，0表示创建中，1表示正常，2表示隔离中，3表示已销毁，4 - 异常, 5 - 发货失败
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "VirtualHostNumber", this.VirtualHostNumber);
            this.SetParamSimple(map, prefix + "QueueNumber", this.QueueNumber);
            this.SetParamSimple(map, prefix + "MessagePublishRate", this.MessagePublishRate);
            this.SetParamSimple(map, prefix + "MessageStackNumber", this.MessageStackNumber);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChannelNumber", this.ChannelNumber);
            this.SetParamSimple(map, prefix + "ConnectionNumber", this.ConnectionNumber);
            this.SetParamSimple(map, prefix + "ConsumerNumber", this.ConsumerNumber);
            this.SetParamSimple(map, prefix + "ExchangeNumber", this.ExchangeNumber);
            this.SetParamSimple(map, prefix + "ExceptionInformation", this.ExceptionInformation);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
        }
    }
}

