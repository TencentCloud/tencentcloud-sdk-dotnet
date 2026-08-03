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

    public class AppTriggerWebhookConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>触发器webhook参数配置</p>
        /// </summary>
        [JsonProperty("ParamSchemaConfig")]
        public AppTriggerWebhookParamSchemaConfig ParamSchemaConfig{ get; set; }

        /// <summary>
        /// <p>webhook的key</p>
        /// </summary>
        [JsonProperty("WebhookKey")]
        public string WebhookKey{ get; set; }

        /// <summary>
        /// <p>webhook的密钥</p>
        /// </summary>
        [JsonProperty("WebhookToken")]
        public string WebhookToken{ get; set; }

        /// <summary>
        /// <p>webhook的地址</p>
        /// </summary>
        [JsonProperty("WebhookUrl")]
        public string WebhookUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ParamSchemaConfig.", this.ParamSchemaConfig);
            this.SetParamSimple(map, prefix + "WebhookKey", this.WebhookKey);
            this.SetParamSimple(map, prefix + "WebhookToken", this.WebhookToken);
            this.SetParamSimple(map, prefix + "WebhookUrl", this.WebhookUrl);
        }
    }
}

