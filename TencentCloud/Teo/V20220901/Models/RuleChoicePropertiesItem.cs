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

    public class RuleChoicePropertiesItem : AbstractModel
    {
        
        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数值类型。
        /// <li> CHOICE：参数值只能在 ChoicesValue 中选择； </li>
        /// <li> TOGGLE：参数值为开关类型，可在 ChoicesValue 中选择；</li>
        /// <li> CUSTOM_NUM：参数值用户自定义，整型类型；</li>
        /// <li> CUSTOM_STRING：参数值用户自定义，字符串类型。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 参数值的可选值。
        /// 注意：若参数值为用户自定义则该数组为空数组。
        /// </summary>
        [JsonProperty("ChoicesValue")]
        public string[] ChoicesValue{ get; set; }

        /// <summary>
        /// 数值参数的最小值，非数值参数或 Min 和 Max 值都为 0 则此项无意义。
        /// </summary>
        [JsonProperty("Min")]
        public long? Min{ get; set; }

        /// <summary>
        /// 数值参数的最大值，非数值参数或 Min 和 Max 值都为 0 则此项无意义。
        /// </summary>
        [JsonProperty("Max")]
        public long? Max{ get; set; }

        /// <summary>
        /// 参数值是否支持多选或者填写多个。
        /// </summary>
        [JsonProperty("IsMultiple")]
        public bool? IsMultiple{ get; set; }

        /// <summary>
        /// 是否允许为空。
        /// </summary>
        [JsonProperty("IsAllowEmpty")]
        public bool? IsAllowEmpty{ get; set; }

        /// <summary>
        /// 特殊参数。
        /// <li> 为 NULL：RuleAction 选择 NormalAction；</li>
        /// <li> 成员参数 Id 为 Action：RuleAction 选择 RewirteAction；</li>
        /// <li> 成员参数 Id 为 StatusCode：RuleAction 选择 CodeAction。</li>
        /// </summary>
        [JsonProperty("ExtraParameter")]
        public RuleExtraParameter ExtraParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "ChoicesValue.", this.ChoicesValue);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "IsMultiple", this.IsMultiple);
            this.SetParamSimple(map, prefix + "IsAllowEmpty", this.IsAllowEmpty);
            this.SetParamObj(map, prefix + "ExtraParameter.", this.ExtraParameter);
        }
    }
}

