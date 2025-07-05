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

    public class DetectLengthLimitCondition : AbstractModel
    {
        
        /// <summary>
        /// 匹配条件的参数名称，取值有：
        /// <li>body_depth：请求正文包部分的检测深度。</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 匹配条件的参数值，取值与 Name 成对使用。
        /// 当 Name 值为 body_depth 时， Values 只支持传入单个值，取值有：
        /// <li>10KB；</li>
        /// <li>64KB；</li>
        /// <li>128KB。</li>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

