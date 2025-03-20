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

    public class PulsarProClusterSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群规格名称
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 峰值tps
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// 峰值带宽。单位：mbps
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// 最大命名空间个数
        /// </summary>
        [JsonProperty("MaxNamespaces")]
        public ulong? MaxNamespaces{ get; set; }

        /// <summary>
        /// 最大主题分区数
        /// </summary>
        [JsonProperty("MaxTopics")]
        public ulong? MaxTopics{ get; set; }

        /// <summary>
        /// 规格外弹性TPS
        /// </summary>
        [JsonProperty("ScalableTps")]
        public ulong? ScalableTps{ get; set; }

        /// <summary>
        /// 32或者128
        /// 当前集群topic的最大分区数
        /// </summary>
        [JsonProperty("MaxPartitions")]
        public ulong? MaxPartitions{ get; set; }

        /// <summary>
        /// 商品最大延迟消息数量。0代表没有限制	
        /// </summary>
        [JsonProperty("MaxDelayedMessages")]
        public long? MaxDelayedMessages{ get; set; }


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
        }
    }
}

