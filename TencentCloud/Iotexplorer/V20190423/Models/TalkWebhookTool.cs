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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TalkWebhookTool : AbstractModel
    {
        
        /// <summary>
        /// Webhook工具名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Webhook工具描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工具参数JSON Schema，JSON对象字符串，必须为type=object
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// Webhook HTTP端点配置
        /// </summary>
        [JsonProperty("Endpoint")]
        public TalkWebhookEndpoint Endpoint{ get; set; }

        /// <summary>
        /// 必填参数名列表，必须存在于Parameters.properties中
        /// </summary>
        [JsonProperty("Required")]
        public string[] Required{ get; set; }

        /// <summary>
        /// Webhook鉴权配置
        /// </summary>
        [JsonProperty("Auth")]
        public TalkWebhookAuth Auth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamObj(map, prefix + "Endpoint.", this.Endpoint);
            this.SetParamArraySimple(map, prefix + "Required.", this.Required);
            this.SetParamObj(map, prefix + "Auth.", this.Auth);
        }
    }
}

