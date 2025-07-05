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

    public class ExportRiskProcessEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>HostId - String - 是否必填：否 - 主机ID</li>
        /// <li>IpOrName - String - 是否必填：否 - 主机IP或主机名</li>
        /// <li>VirusName - String - 是否必填：否 - 病毒名</li>
        /// <li>ProcessId - String - 是否必填：否 - 进程ID</li>
        /// <li>ProcessPath - String - 是否必填：否 - 进程路径</li>
        /// <li>BeginTime - String - 是否必填：否 - 进程启动时间-开始</li>
        /// <li>EndTime - String - 是否必填：否 - 进程启动时间-结束</li>
        /// <li>Status - String - 是否必填：否 - 状态筛选 0待处理；1查杀中；2已查杀；3已退出;4已信任</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序方式：[ASC:升序|DESC:降序]
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// [StartTime:进程启动时间|DetectTime:最后检测时间]
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

