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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCloudNativeAPIGatewayMCPToolACLRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>MCP服务ID</p>
        /// </summary>
        [JsonProperty("ServerId")]
        public string ServerId{ get; set; }

        /// <summary>
        /// <p>MCP工具ID</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>鉴权类型</p><p>枚举值：</p><ul><li>None： 继承server鉴权类型</li><li>Allow： 白名单</li><li>Deny： 黑名单</li></ul>
        /// </summary>
        [JsonProperty("ACLType")]
        public string ACLType{ get; set; }

        /// <summary>
        /// <p>需要关联的消费者ID列表</p>
        /// </summary>
        [JsonProperty("ACLConsumerIds")]
        public string[] ACLConsumerIds{ get; set; }

        /// <summary>
        /// <p>需要关联的消费者组ID列表</p>
        /// </summary>
        [JsonProperty("ACLConsumerGroupIds")]
        public string[] ACLConsumerGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ServerId", this.ServerId);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ACLType", this.ACLType);
            this.SetParamArraySimple(map, prefix + "ACLConsumerIds.", this.ACLConsumerIds);
            this.SetParamArraySimple(map, prefix + "ACLConsumerGroupIds.", this.ACLConsumerGroupIds);
        }
    }
}

