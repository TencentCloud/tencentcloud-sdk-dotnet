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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceAlarmEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 事件查询范围开始时间，闭区间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 事件查询范围截止时间，闭区间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 事件名称。 Outofmemory - 内存OOM（有状态事件）; Switch - 主从切换（有状态事件）; Roremove - 只读实例剔除（有状态事件）; MemoryUsedHigh - 内存使用率过高（有状态事件）; CPUExpansion - CPU性能扩容（无状态事件）; CPUExpansionFailed - CPU性能扩容失败（无状态事件）; CPUContraction - CPU性能回缩（无状态事件）; Restart - 实例重启（有状态事件）; ServerFailureNodeMigration - ServerFailureNodeMigration（有状态事件）; PlannedSwitch - 计划内主备切换（无状态事件）; OverusedReadonlySet - 实例将被锁定（无状态事件）; OverusedReadWriteSet - 实例解除锁定（无状态事件）。
        /// </summary>
        [JsonProperty("EventName")]
        public string[] EventName{ get; set; }

        /// <summary>
        /// 事件状态。"1" - 发生事件；"0" - 恢复事件；"-" - 无状态事件。
        /// </summary>
        [JsonProperty("EventStatus")]
        public string EventStatus{ get; set; }

        /// <summary>
        /// 排序方式。按事件发生事件进行排序，"DESC"-倒排；”ASC“-正序，默认倒排。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 事件展示数量。默认为100，最大为200。
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// 节点 ID。
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "EventName.", this.EventName);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
        }
    }
}

