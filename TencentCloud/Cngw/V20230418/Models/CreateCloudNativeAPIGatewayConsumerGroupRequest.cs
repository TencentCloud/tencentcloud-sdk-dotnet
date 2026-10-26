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

    public class CreateCloudNativeAPIGatewayConsumerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例id</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>消费者组名称，最长 60 字符。同一网关下唯一。</p><p>CustomOrganization 时非空、最大 255 字符；Legacy 原规则不变。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>启用状态。</p><p>枚举值：</p><ul><li>Enable：启用</li><li>Disable：禁用</li></ul><p>CustomOrganization 时传 Active 或 Disabled；保持 Status 必填。Legacy 原 Enable/Disable 不变。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>消费者组描述。最长 200 字符。</p><p>CustomOrganization 时最大 500 字符；Legacy 原规则不变。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>调用业务来源，可选 Legacy 或 CustomOrganization；省略或空串按 Legacy。Legacy 保持原行为，CustomOrganization 用于自定义组织架构。该字段不替代鉴权，不改变资源归属，不覆盖 RequestSource。来源保存在操作记录请求内容中。</p>
        /// </summary>
        [JsonProperty("OperationSource")]
        public string OperationSource{ get; set; }

        /// <summary>
        /// <p>仅 CustomOrganization 使用。1–32 个当前网关自定义父部门 UUID，完整保留多父关系；省略时挂自定义根，空数组非法。不得使用同步部门或未归属组。Legacy 不使用此字段。</p>
        /// </summary>
        [JsonProperty("ParentConsumerGroupIds")]
        public string[] ParentConsumerGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OperationSource", this.OperationSource);
            this.SetParamArraySimple(map, prefix + "ParentConsumerGroupIds.", this.ParentConsumerGroupIds);
        }
    }
}

