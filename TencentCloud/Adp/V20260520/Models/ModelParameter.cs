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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelParameter : AbstractModel
    {
        
        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 枚举值列表（仅枚举类型有效）
        /// </summary>
        [JsonProperty("EnumValueList")]
        public string[] EnumValueList{ get; set; }

        /// <summary>
        /// 最大值（仅数值类型有效）
        /// </summary>
        [JsonProperty("MaxValue")]
        public float? MaxValue{ get; set; }

        /// <summary>
        /// 最小值（仅数值类型有效）
        /// </summary>
        [JsonProperty("MinValue")]
        public float? MinValue{ get; set; }

        /// <summary>
        /// 超参名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 超参类型。1-浮点数, 2-整数, 3-字符串, 4-枚举
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamArraySimple(map, prefix + "EnumValueList.", this.EnumValueList);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "MinValue", this.MinValue);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

