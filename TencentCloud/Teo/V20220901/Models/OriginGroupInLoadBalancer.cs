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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginGroupInLoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// 优先级，填写格式为 "priority_" + "数字"，最高优先级为 "priority_1"。参考取值有：
        /// <li>priority_1：第一优先级；</li>
        /// <li>priority_2：第二优先级；</li>
        /// <li>priority_3：第三优先级。</li>其他优先级可以将数字递增，最多可以递增至 "priority_10"。
        /// </summary>
        [JsonProperty("Priority")]
        public string Priority{ get; set; }

        /// <summary>
        /// 源站组 ID。
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
        }
    }
}

