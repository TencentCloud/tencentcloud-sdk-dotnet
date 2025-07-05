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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentPluginHeader : AbstractModel
    {
        
        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [JsonProperty("ParamValue")]
        public string ParamValue{ get; set; }

        /// <summary>
        /// header参数配置是否隐藏不可见
        /// </summary>
        [JsonProperty("GlobalHidden")]
        public bool? GlobalHidden{ get; set; }

        /// <summary>
        /// 输入的值
        /// </summary>
        [JsonProperty("Input")]
        public AgentInput Input{ get; set; }

        /// <summary>
        /// 参数是否可以为空
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamValue", this.ParamValue);
            this.SetParamSimple(map, prefix + "GlobalHidden", this.GlobalHidden);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
        }
    }
}

