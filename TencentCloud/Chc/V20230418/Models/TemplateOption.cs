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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateOption : AbstractModel
    {
        
        /// <summary>
        /// 选项名称
        /// </summary>
        [JsonProperty("OptionName")]
        public string OptionName{ get; set; }

        /// <summary>
        /// 腾讯的标准
        /// </summary>
        [JsonProperty("Standard")]
        public string Standard{ get; set; }

        /// <summary>
        /// 腾讯标准的展示字段
        /// </summary>
        [JsonProperty("StandardInfo")]
        public string StandardInfo{ get; set; }

        /// <summary>
        /// 选项的唯一标识
        /// </summary>
        [JsonProperty("OptionKey")]
        public string OptionKey{ get; set; }

        /// <summary>
        /// 输入的类型
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 输入值的类型
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// 是否符合腾讯标准的比较方式，-- 为不做比较
        /// </summary>
        [JsonProperty("CompareType")]
        public string CompareType{ get; set; }

        /// <summary>
        /// 下拉列表中填充的选项值
        /// </summary>
        [JsonProperty("OptionValueSet")]
        public OptionValueItem[] OptionValueSet{ get; set; }

        /// <summary>
        /// 输入框中的占位的提示符
        /// </summary>
        [JsonProperty("InputHint")]
        public string InputHint{ get; set; }

        /// <summary>
        /// 输入框下方的提示文案
        /// </summary>
        [JsonProperty("InputInfo")]
        public string InputInfo{ get; set; }

        /// <summary>
        /// 客户写入的值
        /// </summary>
        [JsonProperty("OptionValue")]
        public string OptionValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OptionName", this.OptionName);
            this.SetParamSimple(map, prefix + "Standard", this.Standard);
            this.SetParamSimple(map, prefix + "StandardInfo", this.StandardInfo);
            this.SetParamSimple(map, prefix + "OptionKey", this.OptionKey);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "CompareType", this.CompareType);
            this.SetParamArrayObj(map, prefix + "OptionValueSet.", this.OptionValueSet);
            this.SetParamSimple(map, prefix + "InputHint", this.InputHint);
            this.SetParamSimple(map, prefix + "InputInfo", this.InputInfo);
            this.SetParamSimple(map, prefix + "OptionValue", this.OptionValue);
        }
    }
}

