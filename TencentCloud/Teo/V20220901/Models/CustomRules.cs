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

    public class CustomRules : AbstractModel
    {
        
        /// <summary>
        /// 自定义规则的定义列表。<br>使用 ModifySecurityPolicy 修改 Web 防护配置时: <br> -  若未指定 Rules 参数，或 Rules 参数长度为零：清空所有自定义规则配置。<br> - 若 SecurityPolicy 参数中，未指定 CustomRules 参数值：保持已有自定义规则配置，不做修改。
        /// </summary>
        [JsonProperty("Rules")]
        public CustomRule[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

