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

    public class AppTriggerWebhookConfigExt : AbstractModel
    {
        
        /// <summary>
        /// 访问外部平台的 OAuth 凭证 ID，不能为空。
        /// </summary>
        [JsonProperty("CredentialId")]
        public string CredentialId{ get; set; }

        /// <summary>
        /// <p>绑定凭证的只读摘要；创建和修改时忽略</p>
        /// </summary>
        [JsonProperty("Credential")]
        public AppTriggerWebhookCredential Credential{ get; set; }

        /// <summary>
        /// 工蜂配置，仅 WebhookProvider=1 时使用，与 TAPDConfig 互斥。
        /// </summary>
        [JsonProperty("GongfengConfig")]
        public AppTriggerGongfengWebhookConfig GongfengConfig{ get; set; }

        /// <summary>
        /// TAPD 配置，仅 WebhookProvider=2 时使用，与 GongfengConfig 互斥。
        /// </summary>
        [JsonProperty("TAPDConfig")]
        public AppTriggerTAPDWebhookConfig TAPDConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CredentialId", this.CredentialId);
            this.SetParamObj(map, prefix + "Credential.", this.Credential);
            this.SetParamObj(map, prefix + "GongfengConfig.", this.GongfengConfig);
            this.SetParamObj(map, prefix + "TAPDConfig.", this.TAPDConfig);
        }
    }
}

