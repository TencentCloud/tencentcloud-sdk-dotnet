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

    public class DefaultDenySecurityActionParameters : AbstractModel
    {
        
        /// <summary>
        /// 托管规则默认拦截处置动作配置。	DenyActionParameters 支持的配置参数：<li>ReturnCustomPage：是否使用自定义页面。</li><li>ResponseCode：自定义页面的状态码。</li><li>ErrorPageId：自定义页面的 PageId。</li>
        /// </summary>
        [JsonProperty("ManagedRules")]
        public DenyActionParameters ManagedRules{ get; set; }

        /// <summary>
        /// 除托管规则外的安全防护规则（自定义规则、速率限制 和 Bot 管理功能）默认拦截处置动作配置。	DenyActionParameters 支持的配置参数：<li>ReturnCustomPage：是否使用自定义页面。</li><li>ResponseCode：自定义页面的状态码。</li><li>ErrorPageId：自定义页面的 PageId。</li>
        /// </summary>
        [JsonProperty("OtherModules")]
        public DenyActionParameters OtherModules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ManagedRules.", this.ManagedRules);
            this.SetParamObj(map, prefix + "OtherModules.", this.OtherModules);
        }
    }
}

