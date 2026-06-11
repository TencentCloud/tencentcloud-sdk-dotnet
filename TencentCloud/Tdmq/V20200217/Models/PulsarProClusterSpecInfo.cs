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

    public class PulsarProClusterSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群规格名称</p>
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// <p>峰值tps</p>
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// <p>峰值带宽。单位：mbps</p>
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// <p>最大命名空间个数</p>
        /// </summary>
        [JsonProperty("MaxNamespaces")]
        public ulong? MaxNamespaces{ get; set; }

        /// <summary>
        /// <p>可以创建的最大主题数</p>
        /// </summary>
        [JsonProperty("MaxTopics")]
        public ulong? MaxTopics{ get; set; }

        /// <summary>
        /// <p>规格外弹性TPS</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScalableTps")]
        public ulong? ScalableTps{ get; set; }

        /// <summary>
        /// <p>32或者128<br>当前集群topic的最大分区数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxPartitions")]
        public ulong? MaxPartitions{ get; set; }

        /// <summary>
        /// <p>最大延迟消息数量。0代表没有限制</p>
        /// </summary>
        [JsonProperty("MaxDelayedMessages")]
        public long? MaxDelayedMessages{ get; set; }

        /// <summary>
        /// <p>可以创建的最大主题分区数</p>
        /// </summary>
        [JsonProperty("MaxTopicsPartitioned")]
        public long? MaxTopicsPartitioned{ get; set; }

        /// <summary>
        /// <p>单broker最大链接数</p>
        /// </summary>
        [JsonProperty("BrokerMaxConnections")]
        public long? BrokerMaxConnections{ get; set; }

        /// <summary>
        /// <p>单IP最大链接数</p>
        /// </summary>
        [JsonProperty("BrokerMaxConnectionsPerIp")]
        public long? BrokerMaxConnectionsPerIp{ get; set; }

        /// <summary>
        /// <p>弹性存储集群最大存储规格；固定存储该值为0</p>
        /// </summary>
        [JsonProperty("MaximumElasticStorage")]
        public long? MaximumElasticStorage{ get; set; }

        /// <summary>
        /// <p>当前集群可使用的全量TPS，包括弹性TPS</p>
        /// </summary>
        [JsonProperty("TotalTps")]
        public long? TotalTps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "MaxNamespaces", this.MaxNamespaces);
            this.SetParamSimple(map, prefix + "MaxTopics", this.MaxTopics);
            this.SetParamSimple(map, prefix + "ScalableTps", this.ScalableTps);
            this.SetParamSimple(map, prefix + "MaxPartitions", this.MaxPartitions);
            this.SetParamSimple(map, prefix + "MaxDelayedMessages", this.MaxDelayedMessages);
            this.SetParamSimple(map, prefix + "MaxTopicsPartitioned", this.MaxTopicsPartitioned);
            this.SetParamSimple(map, prefix + "BrokerMaxConnections", this.BrokerMaxConnections);
            this.SetParamSimple(map, prefix + "BrokerMaxConnectionsPerIp", this.BrokerMaxConnectionsPerIp);
            this.SetParamSimple(map, prefix + "MaximumElasticStorage", this.MaximumElasticStorage);
            this.SetParamSimple(map, prefix + "TotalTps", this.TotalTps);
        }
    }
}

