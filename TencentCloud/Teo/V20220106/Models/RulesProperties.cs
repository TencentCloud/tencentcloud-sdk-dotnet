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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RulesProperties : AbstractModel
    {
        
        /// <summary>
        /// 值为参数名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数值参数的最小值，非数值参数或 Min 和 Max 值都为 0 则此项无意义。
        /// </summary>
        [JsonProperty("Min")]
        public long? Min{ get; set; }

        /// <summary>
        /// 参数值的可选值。
        /// 注意：若参数值为用户自定义则该数组为空数组。
        /// </summary>
        [JsonProperty("ChoicesValue")]
        public string[] ChoicesValue{ get; set; }

        /// <summary>
        /// 参数值类型。
        /// <li> CHOICE：参数值只能在 ChoicesValue 中选择； </li>
        /// <li> TOGGLE：参数值为开关类型，可在 ChoicesValue 中选择；</li>
        /// <li> OBJECT：参数值为对象类型，ChoiceProperties 为改对象类型关联的属性；</li>
        /// <li> CUSTOM_NUM：参数值用户自定义，整型类型；</li>
        /// <li> CUSTOM_STRING：参数值用户自定义，字符串类型。</li>注意：当参数类型为 OBJECT 类型时，请注意参考 [示例2 参数为 OBJECT 类型的创建](https://tcloud4api.woa.com/document/product/1657/79382?!preview&!document=1)
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

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
        /// 该参数对应的关联配置参数，属于调用接口的必填参数。
        /// 注意：如果可选参数无特殊新增参数则该数组为空数组。
        /// </summary>
        [JsonProperty("ChoiceProperties")]
        public RuleChoicePropertiesItem[] ChoiceProperties{ get; set; }

        /// <summary>
        /// <li> 为 NULL：无特殊参数，RuleAction 选择 NormalAction；</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraParameter")]
        public RuleExtraParameter ExtraParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamArraySimple(map, prefix + "ChoicesValue.", this.ChoicesValue);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "IsMultiple", this.IsMultiple);
            this.SetParamSimple(map, prefix + "IsAllowEmpty", this.IsAllowEmpty);
            this.SetParamArrayObj(map, prefix + "ChoiceProperties.", this.ChoiceProperties);
            this.SetParamObj(map, prefix + "ExtraParameter.", this.ExtraParameter);
        }
    }
}

