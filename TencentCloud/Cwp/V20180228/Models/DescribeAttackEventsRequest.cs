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

    public class DescribeAttackEventsRequest : AbstractModel
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
        ///  过滤条件。
        /// <li>Type - String 攻击状态 0: 尝试攻击 1: 攻击成功 - 是否必填: 否</li>
        /// <li>Status - String 事件处理状态 0：待处理 1：已处理 2： 已加白 3： 已忽略 4：已删除  - 是否必填: 否</li>
        /// <li>SrcIP - String 来源IP - 是否必填: 否</li>
        /// <li>Uuids - String 主机安全uuid - 是否必填: 否</li>
        /// <li>Quuids - String cvm uuid - 是否必填: 否</li>
        /// <li>DstPort - String 攻击目标端口 - 是否必填: 否</li>
        /// <li>MachineName - String 主机名称 - 是否必填: 否</li>
        /// <li>InstanceID - String 主机实例ID - 是否必填: 否</li>
        /// <li>AttackTimeBegin - String 攻击开始时间 - 是否必填: 否</li>
        /// <li>AttackTimeEnd - String 攻击结束时间 - 是否必填: 否</li>
        /// <li>VulSupportDefense - String 漏洞是否支持防御 0不支持，1支持 - 是否必填: 否</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 排序方式 ASC,DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

