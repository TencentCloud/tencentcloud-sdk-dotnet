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

    public class BotManagement : AbstractModel
    {
        
        /// <summary>
        /// Bot 管理是否开启。取值有：<li>on：开启；</li><li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Bot 管理的自定义规则，组合各类爬虫和请求行为特征，精准定义 Bot 并配置定制化处置方式。
        /// </summary>
        [JsonProperty("CustomRules")]
        public BotManagementCustomRules CustomRules{ get; set; }

        /// <summary>
        /// Bot 管理的基础配置，对策略关联的所有域名生效。可以通过 CustomRules 进行精细化定制。
        /// </summary>
        [JsonProperty("BasicBotSettings")]
        public BasicBotSettings BasicBotSettings{ get; set; }

        /// <summary>
        /// 客户端认证规则的定义列表。该功能内测中，如需使用，请提工单。
        /// </summary>
        [JsonProperty("ClientAttestationRules")]
        public ClientAttestationRules ClientAttestationRules{ get; set; }

        /// <summary>
        /// 配置浏览器伪造识别规则（原主动特征识别规则）。设置注入 JavaScript 的响应页面范围，浏览器校验选项，以及对非浏览器客户端的处置方式。
        /// </summary>
        [JsonProperty("BrowserImpersonationDetection")]
        public BrowserImpersonationDetection BrowserImpersonationDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "CustomRules.", this.CustomRules);
            this.SetParamObj(map, prefix + "BasicBotSettings.", this.BasicBotSettings);
            this.SetParamObj(map, prefix + "ClientAttestationRules.", this.ClientAttestationRules);
            this.SetParamObj(map, prefix + "BrowserImpersonationDetection.", this.BrowserImpersonationDetection);
        }
    }
}

