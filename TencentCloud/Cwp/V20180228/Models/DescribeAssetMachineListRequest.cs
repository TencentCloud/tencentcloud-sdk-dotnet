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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>MachineName  主机名称</li>
        /// <li>InstanceID  实例ID  </li>
        /// <li>IP   内网IP或公网IP</li>
        /// <li>OsType - String - 是否必填：否 - windows或linux</li>
        /// <li>CpuLoad - Int - 是否必填：否 - 
        /// 	0: 未知  1: 低负载
        /// 	2: 中负载  3: 高负载</li>
        /// <li>DiskLoad - Int - 是否必填：否 - 
        /// 	0: 0%或未知  1: 0%～20%
        /// 	2: 20%～50%  3: 50%～80%
        /// 	4: 80%～100%</li>
        /// <li>MemLoad - Int - 是否必填：否 - 
        /// 	0: 0%或未知  1: 0%～20%
        /// 	2: 20%～50%  3: 50%～80%
        /// 	4: 80%～100%</li>
        /// <li>Quuid：主机Quuid</li>
        /// <li>Os -String 是否必填: 否 - 操作系统( DescribeMachineOsList 接口 值 )</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 需要返回的数量，默认为10，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 排序方式，asc升序 或 desc降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 可选排序[FirstTime|PartitionCount]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

