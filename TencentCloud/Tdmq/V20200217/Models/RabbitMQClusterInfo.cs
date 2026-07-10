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

    public class RabbitMQClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群 ID</p>
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
        /// <p>创建时间，毫秒为单位。unix 时间戳</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>集群说明信息</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>VPC及网络信息</p>
        /// </summary>
        [JsonProperty("Vpcs")]
        public VpcEndpointInfo[] Vpcs{ get; set; }

        /// <summary>
        /// <p>可用区信息</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>虚拟主机数量</p>
        /// </summary>
        [JsonProperty("VirtualHostNumber")]
        public long? VirtualHostNumber{ get; set; }

        /// <summary>
        /// <p>队列数量</p>
        /// </summary>
        [JsonProperty("QueueNumber")]
        public long? QueueNumber{ get; set; }

        /// <summary>
        /// <p>每秒生产消息数 单位：条/秒</p>
        /// </summary>
        [JsonProperty("MessagePublishRate")]
        public float? MessagePublishRate{ get; set; }

        /// <summary>
        /// <p>堆积消息数 单位：条</p>
        /// </summary>
        [JsonProperty("MessageStackNumber")]
        public long? MessageStackNumber{ get; set; }

        /// <summary>
        /// <p>实例到期时间，按量付费的资源该值为 0，毫秒为单位。unix 时间戳</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>Channel数量</p>
        /// </summary>
        [JsonProperty("ChannelNumber")]
        public long? ChannelNumber{ get; set; }

        /// <summary>
        /// <p>Connection数量</p>
        /// </summary>
        [JsonProperty("ConnectionNumber")]
        public long? ConnectionNumber{ get; set; }

        /// <summary>
        /// <p>Consumer数量</p>
        /// </summary>
        [JsonProperty("ConsumerNumber")]
        public long? ConsumerNumber{ get; set; }

        /// <summary>
        /// <p>Exchang数量</p>
        /// </summary>
        [JsonProperty("ExchangeNumber")]
        public long? ExchangeNumber{ get; set; }

        /// <summary>
        /// <p>集群异常信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExceptionInformation")]
        public string ExceptionInformation{ get; set; }

        /// <summary>
        /// <p>实例状态，0表示创建中，1表示正常，2表示隔离中，3表示已销毁，4 - 异常, 5 - 发货失败</p>
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// <p>自动续费标记，0表示默认状态(用户未设置，即初始状态即手动续费)， 1表示自动续费，2表示明确不自动续费(用户设置)</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>是否开启镜像队列策略。1表示开启，0表示没开启。</p>
        /// </summary>
        [JsonProperty("MirrorQueuePolicyFlag")]
        public long? MirrorQueuePolicyFlag{ get; set; }

        /// <summary>
        /// <p>每秒消费消息数 单位：条/秒</p>
        /// </summary>
        [JsonProperty("MessageConsumeRate")]
        public float? MessageConsumeRate{ get; set; }

        /// <summary>
        /// <p>集群版本信息</p>
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>计费模式，0-后付费，1-预付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>实例类型，0 专享版、1 Serverless 版</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// <p>开始隔离时间。unix 时间戳</p>
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public long? IsolatedTime{ get; set; }

        /// <summary>
        /// <p>是否为容器实例，默认 true</p>
        /// </summary>
        [JsonProperty("Container")]
        public bool? Container{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>是否已开启删除保护</p>
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }

        /// <summary>
        /// <p>是否有vhost未开启镜像队列风险</p>
        /// </summary>
        [JsonProperty("MirroredQueueRisk")]
        public bool? MirroredQueueRisk{ get; set; }

        /// <summary>
        /// <p>是否提示风险</p>
        /// </summary>
        [JsonProperty("EnableRiskWarning")]
        public bool? EnableRiskWarning{ get; set; }

        /// <summary>
        /// <p>消费超时时间</p>
        /// </summary>
        [JsonProperty("ConsumeTimeout")]
        public ulong? ConsumeTimeout{ get; set; }

        /// <summary>
        /// <p>最大Channel数</p>
        /// </summary>
        [JsonProperty("ChannelMax")]
        public ulong? ChannelMax{ get; set; }

        /// <summary>
        /// <p>集群类型</p><p>枚举值：</p><ul><li>NORMAL： 公有云</li><li>CDC： 本地专用集群</li></ul>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>CDC集群ID</p>
        /// </summary>
        [JsonProperty("CdcClusterId")]
        public string CdcClusterId{ get; set; }


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
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "MirrorQueuePolicyFlag", this.MirrorQueuePolicyFlag);
            this.SetParamSimple(map, prefix + "MessageConsumeRate", this.MessageConsumeRate);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
            this.SetParamSimple(map, prefix + "MirroredQueueRisk", this.MirroredQueueRisk);
            this.SetParamSimple(map, prefix + "EnableRiskWarning", this.EnableRiskWarning);
            this.SetParamSimple(map, prefix + "ConsumeTimeout", this.ConsumeTimeout);
            this.SetParamSimple(map, prefix + "ChannelMax", this.ChannelMax);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "CdcClusterId", this.CdcClusterId);
        }
    }
}

