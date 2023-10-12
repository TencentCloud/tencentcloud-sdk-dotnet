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

    public class ExportAssetMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>IP - String - 是否必填：否 - 主机ip</li>
        /// <li>MachineName - String - 是否必填：否 - 主机名称</li>
        /// <li>InstanceID - string - 是否必填：否 - 实例ID</li>
        /// <li>OsType - String - 是否必填：否 - windows或linux</li>
        /// <li>CpuLoad - Int - 是否必填：否 - 
        /// 0: 0%或未知  1: 0%～20%
        /// 2: 20%～50%  3: 50%～80%
        /// 4: 80%～100%</li>
        /// <li>DiskLoad - Int - 是否必填：否 - 
        /// 0: 0%或未知  1: 0%～20%
        /// 2: 20%～50%  3: 50%～80%
        /// 4: 80%～100%</li>
        /// <li>MemLoad - Int - 是否必填：否 - 
        /// 0: 0%或未知  1: 0%～20%
        /// 2: 20%～50%  3: 50%～80%
        /// 4: 80%～100%</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

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
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

