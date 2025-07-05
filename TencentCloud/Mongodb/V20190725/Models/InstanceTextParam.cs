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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTextParam : AbstractModel
    {
        
        /// <summary>
        /// 参数当前值。
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 参数默认值。
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 修改参数值之后是否需要重启。
        /// </summary>
        [JsonProperty("NeedRestart")]
        public string NeedRestart{ get; set; }

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// Text 类型参数对应的值。
        /// </summary>
        [JsonProperty("TextValue")]
        public string TextValue{ get; set; }

        /// <summary>
        /// 参数说明。
        /// </summary>
        [JsonProperty("Tips")]
        public string[] Tips{ get; set; }

        /// <summary>
        /// 参数值类型说明。
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// 是否为运行中的参数值。
        /// - 1：运行中参数值。
        /// - 0：非运行中参数值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "TextValue", this.TextValue);
            this.SetParamArraySimple(map, prefix + "Tips.", this.Tips);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

