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

    public class AppTriggerParamBindingValue : AbstractModel
    {
        
        /// <summary>
        /// <p>参数值</p>
        /// </summary>
        [JsonProperty("ParamValue")]
        public string ParamValue{ get; set; }

        /// <summary>
        /// <p>应用变量名</p>
        /// </summary>
        [JsonProperty("VariableName")]
        public string VariableName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamValue", this.ParamValue);
            this.SetParamSimple(map, prefix + "VariableName", this.VariableName);
        }
    }
}

