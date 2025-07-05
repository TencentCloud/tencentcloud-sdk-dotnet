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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportRansomDefenseStrategyMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>Ips - String - 是否必填：否 - 通过ip查询 </li>
        /// <li>MachineNames - String - 是否必填：否 - 通过实例名查询 </li>
        /// <li>Names - String - 是否必填：否 - 通过实例名查询 </li>
        /// <li>Status - String - 是否必填：否 - 策略状态：0备份中，1备份成功，2备份失败 </li>
        /// <li>LastBackupTimeBegin - String - 是否必填：否 - 最近一次备份时间开始</li>
        /// <li>LastBackupTimeEnd - String - 是否必填：否 - 最近一次备份时间结束</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 排序方法 ASC DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段支持CreateTime、MachineCount
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

