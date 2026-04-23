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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerStrategyItem : AbstractModel
    {
        
        /// <summary>
        /// <p>http 接口相关参数</p>
        /// </summary>
        [JsonProperty("InterfaceConfig")]
        public HttpCallbackConfig InterfaceConfig{ get; set; }

        /// <summary>
        /// <p>挂断类型</p>
        /// </summary>
        [JsonProperty("HangupTypes")]
        public string[] HangupTypes{ get; set; }

        /// <summary>
        /// <p>通话标签</p>
        /// </summary>
        [JsonProperty("CallTags")]
        public RetryTagItem[] CallTags{ get; set; }

        /// <summary>
        /// <p>触发模式</p><p>枚举值：</p><ul><li>ONCE_PER_NUMBER： 每个号码仅第一次命中条件时触发</li><li>ALWAYS_ON_MATCH： 每次命中条件均触发</li></ul>
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InterfaceConfig.", this.InterfaceConfig);
            this.SetParamArraySimple(map, prefix + "HangupTypes.", this.HangupTypes);
            this.SetParamArrayObj(map, prefix + "CallTags.", this.CallTags);
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
        }
    }
}

