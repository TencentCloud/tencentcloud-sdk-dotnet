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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 协议端口模板名称。
        /// </summary>
        [JsonProperty("ServiceTemplateName")]
        public string ServiceTemplateName{ get; set; }

        /// <summary>
        /// 支持单个端口、多个端口、连续端口及所有端口，协议支持：TCP、UDP、ICMP、GRE 协议。Services与ServicesExtra必填其一。
        /// </summary>
        [JsonProperty("Services")]
        public string[] Services{ get; set; }

        /// <summary>
        /// 支持添加备注，单个端口、多个端口、连续端口及所有端口，协议支持：TCP、UDP、ICMP、GRE 协议。Services与ServicesExtra必填其一。
        /// </summary>
        [JsonProperty("ServicesExtra")]
        public ServicesInfo[] ServicesExtra{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceTemplateName", this.ServiceTemplateName);
            this.SetParamArraySimple(map, prefix + "Services.", this.Services);
            this.SetParamArrayObj(map, prefix + "ServicesExtra.", this.ServicesExtra);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

