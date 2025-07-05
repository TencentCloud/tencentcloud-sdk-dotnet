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

    public class ChangeRuleEventsIgnoreStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 忽略状态 0:取消忽略 ； 1:忽略
        /// </summary>
        [JsonProperty("IgnoreStatus")]
        public ulong? IgnoreStatus{ get; set; }

        /// <summary>
        /// 检测项id数组
        /// </summary>
        [JsonProperty("RuleIdList")]
        public ulong?[] RuleIdList{ get; set; }

        /// <summary>
        /// 事件id数组
        /// </summary>
        [JsonProperty("EventIdList")]
        public ulong?[] EventIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IgnoreStatus", this.IgnoreStatus);
            this.SetParamArraySimple(map, prefix + "RuleIdList.", this.RuleIdList);
            this.SetParamArraySimple(map, prefix + "EventIdList.", this.EventIdList);
        }
    }
}

