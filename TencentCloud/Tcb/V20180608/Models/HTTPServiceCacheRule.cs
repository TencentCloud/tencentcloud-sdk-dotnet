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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceCacheRule : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义描述，最多 128 字节</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>规则开关：nil/true 启用，false 禁用</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>HTTPService 规则匹配条件（必填）</p>
        /// </summary>
        [JsonProperty("Condition")]
        public HTTPServiceRuleCondition Condition{ get; set; }

        /// <summary>
        /// <p>HTTPService 缓存动作列表，同一规则内相同 Type 至多一个</p>
        /// </summary>
        [JsonProperty("Actions")]
        public HTTPServiceCacheAction[] Actions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamArrayObj(map, prefix + "Actions.", this.Actions);
        }
    }
}

