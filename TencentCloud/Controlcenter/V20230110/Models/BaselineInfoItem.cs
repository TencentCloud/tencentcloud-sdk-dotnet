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

namespace TencentCloud.Controlcenter.V20230110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 账号工厂基线项唯一标识，只能包含英文字母、数字和@、,._[]-:()（）【】+=，。，长度2-128个字符。
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// 账号工厂基线项配置，不同的基线项配置参数不同。
        /// </summary>
        [JsonProperty("Configuration")]
        public string Configuration{ get; set; }

        /// <summary>
        /// 基线应用的账号数量。
        /// </summary>
        [JsonProperty("ApplyCount")]
        public long? ApplyCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "Configuration", this.Configuration);
            this.SetParamSimple(map, prefix + "ApplyCount", this.ApplyCount);
        }
    }
}

