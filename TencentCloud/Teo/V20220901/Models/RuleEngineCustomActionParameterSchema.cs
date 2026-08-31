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

    public class RuleEngineCustomActionParameterSchema : AbstractModel
    {
        
        /// <summary>
        /// <p>参数字段名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>参数字段类型，取值有：<li>Boolean：布尔；</li><li>Integer：整型；</li><li>Float：浮点型；</li><li>String：字符串；</li><li>ArrayOfInteger：整型数组；</li><li>ArrayOfFloat：浮点型数组；</li><li>ArrayOfString：字符串数组。</li></p>
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// <p>参数字段描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>参数字段默认值。</p>
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// <p>参数字段单位。</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>参数字段是否必填。</p><p>默认值：false</p><p>若填充，则适用于所有参数字段类型校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("Required")]
        public bool? Required{ get; set; }

        /// <summary>
        /// <p>参数字段最小值。</p><p>若填充，适用于整数、浮点数、整数数组、浮点数数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MinValue")]
        public float? MinValue{ get; set; }

        /// <summary>
        /// <p>参数字段最大值。</p><p>若填充，适用于整数、浮点数、整数数组、浮点数数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MaxValue")]
        public float? MaxValue{ get; set; }

        /// <summary>
        /// <p>参数字段最小长度。</p><p>若填充，适用于字符串、字符串数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MinLength")]
        public long? MinLength{ get; set; }

        /// <summary>
        /// <p>参数字段最大长度。</p><p>若填充，适用于字符串、字符串数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// <p>参数字段最小项数。</p><p>若填充，适用于各类数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MinItems")]
        public long? MinItems{ get; set; }

        /// <summary>
        /// <p>参数字段最大项数。</p><p>若填充，适用于各类数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MaxItems")]
        public long? MaxItems{ get; set; }

        /// <summary>
        /// <p>参数字段项是否唯一。</p><p>默认值：false</p><p>若填充，适用于各类数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("UniqueItems")]
        public bool? UniqueItems{ get; set; }

        /// <summary>
        /// <p>参数字段允许的格式。</p><p>若填充，需要校验字符串或者字符串数组内容合适；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("AllowedPattern")]
        public string AllowedPattern{ get; set; }

        /// <summary>
        /// <p>参数字段允许的取值，若为空则不校验。</p><p>若本参数填充，则说明对应参数为枚举类型，仅允许填充本参数数组中的值；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("AllowedValues")]
        public string[] AllowedValues{ get; set; }

        /// <summary>
        /// <p>参数字段最小步长。若填充，适用于浮点型和浮点型数组类型参数的数值校验；若不填充则不校验。</p>
        /// </summary>
        [JsonProperty("MultipleOf")]
        public string MultipleOf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "MinValue", this.MinValue);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
            this.SetParamSimple(map, prefix + "MaxLength", this.MaxLength);
            this.SetParamSimple(map, prefix + "MinItems", this.MinItems);
            this.SetParamSimple(map, prefix + "MaxItems", this.MaxItems);
            this.SetParamSimple(map, prefix + "UniqueItems", this.UniqueItems);
            this.SetParamSimple(map, prefix + "AllowedPattern", this.AllowedPattern);
            this.SetParamArraySimple(map, prefix + "AllowedValues.", this.AllowedValues);
            this.SetParamSimple(map, prefix + "MultipleOf", this.MultipleOf);
        }
    }
}

