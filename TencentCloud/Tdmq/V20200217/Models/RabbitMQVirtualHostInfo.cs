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

    public class RabbitMQVirtualHostInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// vhost名
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// vhost描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// vhost标签
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// vhost概览统计信息
        /// </summary>
        [JsonProperty("VirtualHostStatistics")]
        public RabbitMQVirtualHostStatistics VirtualHostStatistics{ get; set; }

        /// <summary>
        /// 消息轨迹开关,true打开,false关闭
        /// </summary>
        [JsonProperty("TraceFlag")]
        public bool? TraceFlag{ get; set; }

        /// <summary>
        /// vhost状态，与原生控制台对应，有running、partial、stopped、unknown
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 消息堆积数
        /// </summary>
        [JsonProperty("MessageHeapCount")]
        public long? MessageHeapCount{ get; set; }

        /// <summary>
        /// 输入消息速率
        /// </summary>
        [JsonProperty("MessageRateIn")]
        public float? MessageRateIn{ get; set; }

        /// <summary>
        /// 输出消息速率
        /// </summary>
        [JsonProperty("MessageRateOut")]
        public float? MessageRateOut{ get; set; }

        /// <summary>
        /// 是否存在镜像队列策略，true 为存在，false 为不存
        /// </summary>
        [JsonProperty("MirrorQueuePolicyFlag")]
        public bool? MirrorQueuePolicyFlag{ get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamObj(map, prefix + "VirtualHostStatistics.", this.VirtualHostStatistics);
            this.SetParamSimple(map, prefix + "TraceFlag", this.TraceFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MessageHeapCount", this.MessageHeapCount);
            this.SetParamSimple(map, prefix + "MessageRateIn", this.MessageRateIn);
            this.SetParamSimple(map, prefix + "MessageRateOut", this.MessageRateOut);
            this.SetParamSimple(map, prefix + "MirrorQueuePolicyFlag", this.MirrorQueuePolicyFlag);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
        }
    }
}

