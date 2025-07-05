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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParameterInfo : AbstractModel
    {
        
        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("Default")]
        public long? Default{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 类型, integer|string
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 最小
        /// </summary>
        [JsonProperty("Minimum")]
        public long? Minimum{ get; set; }

        /// <summary>
        /// 最大
        /// </summary>
        [JsonProperty("Maximum")]
        public long? Maximum{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifedTime")]
        [System.Obsolete]
        public string ModifedTime{ get; set; }

        /// <summary>
        /// 字符类型的值，当Type为string时才有意义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueString")]
        public string ValueString{ get; set; }

        /// <summary>
        /// 字符类型的默认值，当Type为string时才有意义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultValueString")]
        public string DefaultValueString{ get; set; }

        /// <summary>
        /// 可调整范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Range")]
        public string Range{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Minimum", this.Minimum);
            this.SetParamSimple(map, prefix + "Maximum", this.Maximum);
            this.SetParamSimple(map, prefix + "ModifedTime", this.ModifedTime);
            this.SetParamSimple(map, prefix + "ValueString", this.ValueString);
            this.SetParamSimple(map, prefix + "DefaultValueString", this.DefaultValueString);
            this.SetParamSimple(map, prefix + "Range", this.Range);
        }
    }
}

