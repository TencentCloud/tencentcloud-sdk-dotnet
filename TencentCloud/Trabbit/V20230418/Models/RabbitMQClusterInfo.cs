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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterInfo : AbstractModel
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
        /// <p>过期时间</p>
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
        /// <p>集群类型</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// <p>消息保留时间，单位小时</p>
        /// </summary>
        [JsonProperty("MessageRetainTime")]
        public ulong? MessageRetainTime{ get; set; }

        /// <summary>
        /// <p>发送消息流量比例</p>
        /// </summary>
        [JsonProperty("SendReceiveRatio")]
        public float? SendReceiveRatio{ get; set; }

        /// <summary>
        /// <p>消息轨迹保留时间，单位小时</p>
        /// </summary>
        [JsonProperty("TraceTime")]
        public ulong? TraceTime{ get; set; }

        /// <summary>
        /// <p>实例标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public RabbitMQServerlessTag[] Tags{ get; set; }

        /// <summary>
        /// <p>是否开启弹性tps</p>
        /// </summary>
        [JsonProperty("ElasticTpsFlag")]
        public bool? ElasticTpsFlag{ get; set; }

        /// <summary>
        /// <p>弹性tps倍数，默认弹1倍</p>
        /// </summary>
        [JsonProperty("ElasticTpsRatio")]
        public float? ElasticTpsRatio{ get; set; }

        /// <summary>
        /// <p>最大重投次数</p>
        /// </summary>
        [JsonProperty("MaxRedeliverCount")]
        public ulong? MaxRedeliverCount{ get; set; }

        /// <summary>
        /// <p>消费超时时间，单位min</p>
        /// </summary>
        [JsonProperty("ConsumerTimeout")]
        public ulong? ConsumerTimeout{ get; set; }


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
            this.SetParamSimple(map, prefix + "MessageRetainTime", this.MessageRetainTime);
            this.SetParamSimple(map, prefix + "SendReceiveRatio", this.SendReceiveRatio);
            this.SetParamSimple(map, prefix + "TraceTime", this.TraceTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ElasticTpsFlag", this.ElasticTpsFlag);
            this.SetParamSimple(map, prefix + "ElasticTpsRatio", this.ElasticTpsRatio);
            this.SetParamSimple(map, prefix + "MaxRedeliverCount", this.MaxRedeliverCount);
            this.SetParamSimple(map, prefix + "ConsumerTimeout", this.ConsumerTimeout);
        }
    }
}

