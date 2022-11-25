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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateK8sApiAbnormalRuleInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则详情
        /// </summary>
        [JsonProperty("RuleInfo")]
        public K8sApiAbnormalRuleInfo RuleInfo{ get; set; }

        /// <summary>
        /// 拷贝规则ID(适用于复制规则场景)
        /// </summary>
        [JsonProperty("CopySrcRuleID")]
        public string CopySrcRuleID{ get; set; }

        /// <summary>
        /// 事件ID(适用于事件加白场景)
        /// </summary>
        [JsonProperty("EventID")]
        public ulong? EventID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RuleInfo.", this.RuleInfo);
            this.SetParamSimple(map, prefix + "CopySrcRuleID", this.CopySrcRuleID);
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
        }
    }
}

