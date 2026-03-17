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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageDenyEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>EventType- String - 是否必填：否 -事件类型 EVENT_RISK:风险事件类型，EVENT_PRIVILEGE:特权。</li>
        /// <li>DealBehavior- String - 是否必填：否 - 执行动作,BEHAVIOR_ALERT:告警，BEHAVIOR_HOLDUP_SUCCESSED:拦截。</li>
        /// <li>RuleName- string - 是否必填：否 - 规则名称。</li>
        /// <li>NodeName- string - 是否必填：否 - 节点名称。</li>
        /// <li>NodeIP- string - 是否必填：否 - 内外IP。</li>
        /// <li>PublicIP- string - 是否必填：否 - 外网IP。</li>
        /// <li>ImageName- string - 是否必填：否 - 镜像名称。</li>
        /// <li>ImageID- string - 是否必填：否 - 镜像ID。</li>
        /// <li>TimeRange- String -是否必填: 否 -  时间范围，第一个值表示开始时间，第二个值表示结束时间 </li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

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
        /// 排序方式：asc/desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段：告警数量：EventCount，最近生成时间：LatestFoundTime
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

