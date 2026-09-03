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

    public class DescribeReverseShellEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回数量，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>ProcName - String - 是否必填：否 - 进程名(模糊匹配进程名或父进程名)</li>
        /// <li>MachineName - String - 是否必填：否 - 主机名称(模糊匹配)</li>
        /// <li>InstanceID - String - 是否必填：否 - 实例ID(模糊匹配)</li>
        /// <li>IP - String - 是否必填：否 - 主机IP(内网IP或公网IP,模糊匹配)</li>
        /// <li>Quuid - String - 是否必填：否 - 主机QUUID(支持多个)</li>
        /// <li>Uuid - String - 是否必填：否 - 主机UUID</li>
        /// <li>Status - String - 是否必填：否 - 处理状态(0:待处理 2:已加入白名单 3:已处理 4:已忽略)</li>
        /// <li>DetectBy - String - 是否必填：否 - 检测方式(0:行为分析 1:命令特征检测)</li>
        /// <li>ID - String - 是否必填：否 - 事件ID(支持多个)</li>
        /// <li>CreateBeginTime - String - 是否必填：否 - 发生开始时间</li>
        /// <li>CreateEndTime - String - 是否必填：否 - 发生结束时间</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序方式：根据请求次数排序：asc-升序/desc-降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段：CreateTime-发生时间
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

