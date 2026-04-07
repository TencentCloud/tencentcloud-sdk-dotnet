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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginSet : AbstractModel
    {
        
        /// <summary>
        /// 指定需要额外启用的插件列表
        /// </summary>
        [JsonProperty("Enabled")]
        public SchedulerPolicyPriority[] Enabled{ get; set; }

        /// <summary>
        /// 指定需要禁用的默认插件列表
        /// </summary>
        [JsonProperty("Disabled")]
        public SchedulerPolicyPriority[] Disabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Enabled.", this.Enabled);
            this.SetParamArrayObj(map, prefix + "Disabled.", this.Disabled);
        }
    }
}

