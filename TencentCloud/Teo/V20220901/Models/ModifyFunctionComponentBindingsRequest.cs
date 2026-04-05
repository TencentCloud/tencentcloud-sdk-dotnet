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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyFunctionComponentBindingsRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 函数 ID。
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 操作类型，取值有：
        /// <li>bind：绑定组件；</li>
        /// <li>bind-override：绑定组件。若绑定已存在则为重绑定行为，否则为绑定行为；</li>
        /// <li>unbind：解绑组件；</li>
        /// <li>rebind：重置绑定关系。清空所有现有绑定，并设置为传入的绑定列表。若传入空列表，则清空所有绑定。</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 操作的函数组件绑定列表。当 Operation 为 rebind 且传入空列表时，表示清空所有绑定。
        /// </summary>
        [JsonProperty("FunctionComponentBindings")]
        public FunctionComponentBinding[] FunctionComponentBindings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamArrayObj(map, prefix + "FunctionComponentBindings.", this.FunctionComponentBindings);
        }
    }
}

