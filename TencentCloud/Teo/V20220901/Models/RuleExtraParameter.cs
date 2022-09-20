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

    public class RuleExtraParameter : AbstractModel
    {
        
        /// <summary>
        /// 参数名，取值有：
        /// <li> Action：修改 HTTP 头部所需参数，RuleAction 选择 RewirteAction；</li>
        /// <li> StatusCode：状态码相关功能所需参数，RuleAction 选择 CodeAction。</li>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 参数值类型。
        /// <li> CHOICE：参数值只能在 Values 中选择； </li>
        /// <li> CUSTOM_NUM：参数值用户自定义，整型类型；</li>
        /// <li> CUSTOM_STRING：参数值用户自定义，字符串类型。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 可选参数值。
        /// 注意：当 Id 的值为 StatusCode 时数组中的值为整型，填写参数值时请填写字符串的整型数值。
        /// </summary>
        [JsonProperty("Choices")]
        public string[] Choices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Choices.", this.Choices);
        }
    }
}

