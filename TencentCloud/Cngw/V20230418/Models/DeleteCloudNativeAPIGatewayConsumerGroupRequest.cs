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

    public class DeleteCloudNativeAPIGatewayConsumerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关实例id
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 消费者组ID<p>CustomOrganization 时必须为当前网关自定义部门 UUID，保留系统节点、子部门、成员与授权/MCP 依赖检查。Legacy 原 cg-* 及已有 UUID 兼容行为不变。成功响应不新增 Result。</p>
        /// </summary>
        [JsonProperty("ConsumerGroupId")]
        public string ConsumerGroupId{ get; set; }

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
            this.SetParamSimple(map, prefix + "ConsumerGroupId", this.ConsumerGroupId);
            this.SetParamSimple(map, prefix + "OperationSource", this.OperationSource);
        }
    }
}

