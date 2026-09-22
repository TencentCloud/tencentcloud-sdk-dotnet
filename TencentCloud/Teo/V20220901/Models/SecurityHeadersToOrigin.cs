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

    public class SecurityHeadersToOrigin : AbstractModel
    {
        
        /// <summary>
        /// <p>Bot 标识信息回源头部配置。</p><p>枚举值：</p><ul><li>EO-Bot-Botnet-ID： 基于 Bot 请求特征生成的识别标识。</li></ul>
        /// </summary>
        [JsonProperty("BotIdentificationHeaders")]
        public string[] BotIdentificationHeaders{ get; set; }

        /// <summary>
        /// <p>高级 Bot 管理模块识别结果回源头部配置。</p><p>枚举值：</p><ul><li>EO-Bot-Client-Attestation： 高级 Bot 管理 - 客户端认证模块认证票据校验结果；</li><li>EO-Bot-Client-Risk： 高级 Bot 管理 - 客户端认证模块设备风险评估结果；</li><li>EO-Bot-Intelligence： 高级 Bot 管理 - Bot 智能分析模块识别结果；</li><li>EO-Bot-IP-Reputation： 高级 Bot 管理 - 客户端画像分析识别结果；</li><li>EO-Bot-Known-Tool： 高级 Bot 管理 - 基础特征管理 - UA 特征规则模块识别结果；</li><li>EO-Bot-Search-Engine： 高级 Bot 管理 - 基础特征管理 - 搜索引擎规则模块识别结果；</li><li>EO-Bot-Source-IDC： 高级 Bot 管理 - 基础特征管理 - IDC 规则模块识别结果；</li><li>EO-Bot-User-Risk： 高级 Bot 管理 - 客户端认证模块账号风险评估结果。</li></ul>
        /// </summary>
        [JsonProperty("BotManagementHeaders")]
        public string[] BotManagementHeaders{ get; set; }

        /// <summary>
        /// <p>客户端指纹信息回源头部配置。</p><p>枚举值：</p><ul><li>EO-Bot-Fingerprint： 客户端指纹信息。</li></ul>
        /// </summary>
        [JsonProperty("ClientFingerprintHeaders")]
        public string[] ClientFingerprintHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BotIdentificationHeaders.", this.BotIdentificationHeaders);
            this.SetParamArraySimple(map, prefix + "BotManagementHeaders.", this.BotManagementHeaders);
            this.SetParamArraySimple(map, prefix + "ClientFingerprintHeaders.", this.ClientFingerprintHeaders);
        }
    }
}

