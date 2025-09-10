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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGroupOffsetsRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例Id,可通过[DescribeInstances](https://cloud.tencent.com/document/product/597/40835)接口获取
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 消费分组名称,可通过[DescribeConsumerGroup](https://cloud.tencent.com/document/product/597/40841)接口获取
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 重置offset的策略,入参含义 0. 对齐shift-by参数,代表把offset向前或向后移动shift条 1. 对齐参考(by-duration,to-datetime,to-earliest,to-latest),代表把offset移动到指定timestamp的位置 2. 对齐参考(to-offset),代表把offset移动到指定的offset位置
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// 需要重置的主题名列表
        /// </summary>
        [JsonProperty("Topics")]
        public string[] Topics{ get; set; }

        /// <summary>
        /// 当strategy为0时，必须包含该字段，可以大于零代表会把offset向后移动shift条，小于零则将offset向前回溯shift条数。正确重置后新的offset应该是(old_offset + shift)，需要注意的是如果新的offset小于partition的earliest则会设置为earliest，如果大于partition 的latest则会设置为latest
        /// </summary>
        [JsonProperty("Shift")]
        public long? Shift{ get; set; }

        /// <summary>
        /// 单位ms。当strategy为1时，必须包含该字段，其中-2表示重置offset到最开始的位置，-1表示重置到最新的位置(相当于清空)，其它值则代表指定的时间，会获取topic中指定时间的offset然后进行重置，需要注意的是，如果指定的时间不存在消息，则获取最末尾的offset。
        /// </summary>
        [JsonProperty("ShiftTimestamp")]
        public long? ShiftTimestamp{ get; set; }

        /// <summary>
        /// 需要重新设置的offset位置。当strategy为2，必须包含该字段。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 需要重新设置的partition的列表，如果没有指定Topics参数。则重置全部topics的对应的Partition列表里的partition。指定Topics时则重置指定的topic列表的对应的Partitions列表的partition。
        /// </summary>
        [JsonProperty("Partitions")]
        public long?[] Partitions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamArraySimple(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "Shift", this.Shift);
            this.SetParamSimple(map, prefix + "ShiftTimestamp", this.ShiftTimestamp);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "Partitions.", this.Partitions);
        }
    }
}

