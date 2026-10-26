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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteCloudNativeAPIGatewayConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关实例id
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 消费者ID
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }

        /// <summary>
        /// <p>调用业务来源，可选 Legacy 或 CustomOrganization；省略或空串按 Legacy。Legacy 保持原行为，CustomOrganization 用于自定义组织架构。该字段不替代鉴权，不改变资源归属，不覆盖 RequestSource。来源保存在操作记录请求内容中。</p>
        /// </summary>
        [JsonProperty("OperationSource")]
        public string OperationSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
            this.SetParamSimple(map, prefix + "OperationSource", this.OperationSource);
        }
    }
}

