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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicFlowRankingResult : AbstractModel
    {
        
        /// <summary>
        /// Topic 流量数组
        /// </summary>
        [JsonProperty("TopicFlow")]
        public TopicFlowRanking[] TopicFlow{ get; set; }

        /// <summary>
        /// 消费者组消费速度排行速度
        /// </summary>
        [JsonProperty("ConsumeSpeed")]
        public ConsumerGroupSpeed[] ConsumeSpeed{ get; set; }

        /// <summary>
        /// Topic 消息堆积/占用磁盘排行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicMessageHeap")]
        public TopicMessageHeapRanking[] TopicMessageHeap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TopicFlow.", this.TopicFlow);
            this.SetParamArrayObj(map, prefix + "ConsumeSpeed.", this.ConsumeSpeed);
            this.SetParamArrayObj(map, prefix + "TopicMessageHeap.", this.TopicMessageHeap);
        }
    }
}

