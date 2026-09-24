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

    public class ZoneCustomVariables : AbstractModel
    {
        
        /// <summary>
        /// <p>站点级自定义变量列表。CustomVariable.Name 需要使用 user.zone. 作为前缀。变量按照数组顺序依次初始化，InitialValue 仅支持引用位于当前变量之前的变量，不支持引用当前变量自身或位于当前变量之后的变量。</p>
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>站点级自定义变量运算规则。运算中支持引用已定义的站点级自定义变量。此列表当前只支持填写一项规则，多填无效。</p>
        /// </summary>
        [JsonProperty("CustomVariableOperations")]
        public CustomVariableOperation[] CustomVariableOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamArrayObj(map, prefix + "CustomVariableOperations.", this.CustomVariableOperations);
        }
    }
}

