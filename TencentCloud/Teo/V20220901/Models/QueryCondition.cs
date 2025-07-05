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

    public class QueryCondition : AbstractModel
    {
        
        /// <summary>
        /// 筛选条件的key。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 查询条件操作符，操作类型有：
        /// <li>equals: 等于；</li>
        /// <li>notEquals: 不等于；</li>
        /// <li>include: 包含；</li>
        /// <li>notInclude: 不包含; </li>
        /// <li>startWith: 开始的值是value；</li>
        /// <li>notStartWith: 不以value的值开始；</li>
        /// <li>endWith: 结尾是value值；</li>
        /// <li>notEndWith: 不以value的值结尾。</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 筛选条件的值。
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

