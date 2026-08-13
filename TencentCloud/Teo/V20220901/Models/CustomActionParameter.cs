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

    public class CustomActionParameter : AbstractModel
    {
        
        /// <summary>
        /// <p>定制配置项下各参数字段名称。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters[].Name 获取，如 &quot;Seconds&quot;、&quot;Ports&quot;、&quot;StatusCode&quot;。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>定制配置项下各参数字段值的类型。</p><p>枚举值：</p><ul><li>String： 字符串类型。</li><li>Integer： 整型类型。</li><li>Float： 浮点数类型。</li><li>Boolean： 布尔类型。</li><li>ArrayOfString： 字符串数组类型。</li><li>ArrayOfInteger： 整型数组类型。</li><li>ArrayOfFloat： 浮点数数组类型。</li></ul><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters[].Type 获取。</p>
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// <p>字符串类型参数值。当 ValueType 为 String 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("StringValue")]
        public string StringValue{ get; set; }

        /// <summary>
        /// <p>整型类型参数值。当 ValueType 为 Integer 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("IntegerValue")]
        public long? IntegerValue{ get; set; }

        /// <summary>
        /// <p>浮点数类型参数值。当 ValueType 为 Float 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("FloatValue")]
        public float? FloatValue{ get; set; }

        /// <summary>
        /// <p>布尔类型参数值。当 ValueType 为 Boolean 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("BooleanValue")]
        public bool? BooleanValue{ get; set; }

        /// <summary>
        /// <p>字符串数组类型参数值。当 ValueType 为 ArrayOfString 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("StringArrayValue")]
        public string[] StringArrayValue{ get; set; }

        /// <summary>
        /// <p>整型数组类型参数值。当 ValueType 为 ArrayOfInteger 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("IntegerArrayValue")]
        public long?[] IntegerArrayValue{ get; set; }

        /// <summary>
        /// <p>浮点数数组类型参数值。当 ValueType 为 ArrayOfFloat 时，该参数必填。</p><p>您可以通过 DescribeAvailableCustomActionsForRuleEngine 接口返回值 CustomActionSet[].Parameters 获取参数值的默认值、单位、限制等说明。</p>
        /// </summary>
        [JsonProperty("FloatArrayValue")]
        public float?[] FloatArrayValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "StringValue", this.StringValue);
            this.SetParamSimple(map, prefix + "IntegerValue", this.IntegerValue);
            this.SetParamSimple(map, prefix + "FloatValue", this.FloatValue);
            this.SetParamSimple(map, prefix + "BooleanValue", this.BooleanValue);
            this.SetParamArraySimple(map, prefix + "StringArrayValue.", this.StringArrayValue);
            this.SetParamArraySimple(map, prefix + "IntegerArrayValue.", this.IntegerArrayValue);
            this.SetParamArraySimple(map, prefix + "FloatArrayValue.", this.FloatArrayValue);
        }
    }
}

