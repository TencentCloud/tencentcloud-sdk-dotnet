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

    public class DescribeRabbitMQQueuesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，形如 amqp-xxxxxxxx。有效的 InstanceId 可通过登录 [TDMQ RabbitMQ 控制台](https://console.cloud.tencent.com/trabbitmq/cluster?rid=1)查询。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VirtualHost 名称，形如 testvhost。有效的 VirtualHost 名称可通过登录 [TDMQ RabbitMQ 控制台](https://console.cloud.tencent.com/trabbitmq/cluster?rid=1)查询，在左侧导航栏点击 Vhost，并在 Vhost 列表中找到Vhost名称。
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// 分页 Offset，默认 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页 Limit，默认 20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 队列类型筛选，不填或 "all"：筛选普通队列 和 quorum 队列；"classic"：筛选 classic(普通) 队列；"quorum"：筛选 quorum 队列
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// 排序依据的字段：
        /// ConsumerNumber - 在线消费者数量；
        /// MessageHeapCount - 消息堆积数；
        /// MessageRateInOut - 生产消费速率之和；
        /// MessageRateIn - 生产速率；
        /// MessageRateOut - 消费速率；
        /// </summary>
        [JsonProperty("SortElement")]
        public string SortElement{ get; set; }

        /// <summary>
        /// 排序顺序，ascend 或 descend
        /// ascend：升序
        /// descend：降序
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "SortElement", this.SortElement);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

