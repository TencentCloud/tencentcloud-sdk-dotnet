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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateParamInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 参数类型为enum时可选的值类型集合
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// 参数类型为float/integer时的最大值
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// 参数类型为float/integer时的最小值
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 是否需要重启
        /// </summary>
        [JsonProperty("NeedReboot")]
        public long? NeedReboot{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 参数类型，integer/float/string/enum
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
        }
    }
}

