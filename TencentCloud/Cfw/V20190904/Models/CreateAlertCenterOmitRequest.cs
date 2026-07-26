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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlertCenterOmitRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>要忽略的记录 ID 列表。TableType=AlertTable 时，使用 DescribeLogs（Index=rule_threatinfo）返回的 log_id；仅通过 HandleEventIdList 指定事件时传 [""]。TableType=InterceptionTable 时，使用 DescribeBlockList 返回的 Data[].UniqueId 或 TopData[].UniqueId。</p>
        /// </summary>
        [JsonProperty("HandleIdList")]
        public string[] HandleIdList{ get; set; }

        /// <summary>
        /// <p>必填的记录来源类型：AlertTable 表示告警中心，InterceptionTable 表示拦截列表。</p>
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>告警事件 ID 列表，可省略且仅用于 TableType=AlertTable。HandleEventIdList 与 HandleIdList 至少指定一种目标；仅按事件忽略时，HandleIdList 固定传 [""]。事件 ID 通过 DescribeCfwAlerts 获取，返回 alerts[].current_event_id 时使用该值，否则使用 alerts[].event_id。</p>
        /// </summary>
        [JsonProperty("HandleEventIdList")]
        public string[] HandleEventIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HandleIdList.", this.HandleIdList);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamArraySimple(map, prefix + "HandleEventIdList.", this.HandleEventIdList);
        }
    }
}

