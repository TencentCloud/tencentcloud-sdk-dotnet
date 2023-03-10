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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepairTaskControlRequest : AbstractModel
    {
        
        /// <summary>
        /// 待授权任务实例对应的产品类型，支持取值：
        /// 
        /// - `CVM`：云服务器
        /// - `CDH`：专用宿主机
        /// - `CPM2.0`：裸金属云服务器
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 指定待操作的实例ID列表，仅允许对列表中的实例ID相关的维修任务发起授权。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 维修任务ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 操作类型，当前只支持传入`AuthorizeRepair`。
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 预约授权时间，形如`2023-01-01 12:00:00`。预约时间需晚于当前时间至少5分钟，且在48小时之内。
        /// </summary>
        [JsonProperty("OrderAuthTime")]
        public string OrderAuthTime{ get; set; }

        /// <summary>
        /// 附加的授权处理策略。
        /// </summary>
        [JsonProperty("TaskSubMethod")]
        public string TaskSubMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "OrderAuthTime", this.OrderAuthTime);
            this.SetParamSimple(map, prefix + "TaskSubMethod", this.TaskSubMethod);
        }
    }
}

