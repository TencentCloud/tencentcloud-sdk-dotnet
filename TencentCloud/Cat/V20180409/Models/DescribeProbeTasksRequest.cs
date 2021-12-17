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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProbeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID  列表
        /// </summary>
        [JsonProperty("TaskIDs")]
        public string[] TaskIDs{ get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 探测目标
        /// </summary>
        [JsonProperty("TargetAddress")]
        public string TargetAddress{ get; set; }

        /// <summary>
        /// 任务状态列表
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long?[] TaskStatus{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 付费模式
        /// <li>1 = 试用版本</li>
        /// <li> 2 = 付费版本 </li>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 订单状态
        /// <li>1 = 正常</li>
        /// <li> 2 = 欠费 </li>
        /// </summary>
        [JsonProperty("OrderState")]
        public long? OrderState{ get; set; }

        /// <summary>
        /// 拨测类型
        /// </summary>
        [JsonProperty("TaskType")]
        public long?[] TaskType{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("TaskCategory")]
        public long?[] TaskCategory{ get; set; }

        /// <summary>
        /// 排序的列
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 是否正序
        /// </summary>
        [JsonProperty("Ascend")]
        public bool? Ascend{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskIDs.", this.TaskIDs);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TargetAddress", this.TargetAddress);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "OrderState", this.OrderState);
            this.SetParamArraySimple(map, prefix + "TaskType.", this.TaskType);
            this.SetParamArraySimple(map, prefix + "TaskCategory.", this.TaskCategory);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Ascend", this.Ascend);
        }
    }
}

