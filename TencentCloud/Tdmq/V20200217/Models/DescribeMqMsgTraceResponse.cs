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

    public class DescribeMqMsgTraceResponse : AbstractModel
    {
        
        /// <summary>
        /// [
        ///     {
        ///         "Stage": "produce",
        ///         "Data": {
        ///             "ProducerName": "生产者名",
        ///             "ProduceTime": "消息生产时间",
        ///             "ProducerAddr": "客户端地址",
        ///             "Duration": "耗时ms",
        ///             "Status": "状态（0：成功，1：失败）"
        ///         }
        ///     },
        ///     {
        ///         "Stage": "persist",
        ///         "Data": {
        ///             "PersistTime": "存储时间",
        ///             "Duration": "耗时ms",
        ///             "Status": "状态（0：成功，1：失败）"
        ///         }
        ///     },
        ///     {
        ///         "Stage": "consume",
        ///         "Data": {
        ///             "TotalCount": 2,
        ///             "RocketMqConsumeLogs": [
        ///                 {
        ///                     "ConsumerGroup": "消费组",
        ///                     "ConsumeModel": "消费模式",
        ///                     "ConsumerAddr": "消费者地址",
        ///                     "ConsumeTime": "推送时间",
        ///                     "Status": "状态（0:已推送未确认, 2:已确认, 3:转入重试, 4:已重试未确认, 5:已转入死信队列）"
        ///                 },
        ///                 {
        ///                     "ConsumerGroup": "消费组",
        ///                     "ConsumeModel": "消费模式",
        ///                     "ConsumerAddr": "消费者地址",
        ///                     "ConsumeTime": "推送时间",
        ///                     "Status": "状态（0:已推送未确认, 2:已确认, 3:转入重试, 4:已重试未确认, 5:已转入死信队列）"
        ///                 }
        ///             ]    
        ///         }
        ///     }
        /// ]
        /// </summary>
        [JsonProperty("Result")]
        public TraceResult[] Result{ get; set; }

        /// <summary>
        /// 消息轨迹页展示的topic名称
        /// </summary>
        [JsonProperty("ShowTopicName")]
        public string ShowTopicName{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Result.", this.Result);
            this.SetParamSimple(map, prefix + "ShowTopicName", this.ShowTopicName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

