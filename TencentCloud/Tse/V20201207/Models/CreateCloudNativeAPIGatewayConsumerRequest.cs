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

    public class CreateCloudNativeAPIGatewayConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例id</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>消费者名称，最长 60 字符。同一网关下唯一。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>消费者优先级，默认medium</p><p>枚举值：</p><ul><li>Low： 低优先级</li><li>Medium： 中优先级</li><li>High： 高优先级</li></ul>
        /// </summary>
        [JsonProperty("Priority")]
        public string Priority{ get; set; }

        /// <summary>
        /// <p>消费者描述。最长 200 字符。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>密钥关联方式，三选一枚举。不传时兼容老逻辑（等价于 None 或 Existing，取决于是否传 SecretKeyId）。</p><p>枚举值：</p><ul><li>Existing： 选择已有密钥</li><li>AutoGenerate： 自动生成并关联密钥</li><li>None： 暂不关联密钥</li></ul><p>默认值：None</p>
        /// </summary>
        [JsonProperty("SecretBindType")]
        public string SecretBindType{ get; set; }

        /// <summary>
        /// <p>自动生成密钥的参数体。仅当 SecretBindType=&quot;AutoGenerate&quot; 时必填，其他分支禁止携带，否则返回 InvalidParameterValue.CreateError。</p>
        /// </summary>
        [JsonProperty("AutoSecretKey")]
        public AutoSecretKey AutoSecretKey{ get; set; }

        /// <summary>
        /// <p>调用业务来源，可选 Legacy 或 CustomOrganization；省略或空串按 Legacy。Legacy 保持原行为，CustomOrganization 用于自定义组织架构。该字段不替代鉴权，不改变资源归属，不覆盖 RequestSource。来源保存在操作记录请求内容中。</p>
        /// </summary>
        [JsonProperty("OperationSource")]
        public string OperationSource{ get; set; }

        /// <summary>
        /// <p>仅 CustomOrganization 使用 Active 或 Disabled，默认 Active。Legacy 不新增状态行为。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SecretBindType", this.SecretBindType);
            this.SetParamObj(map, prefix + "AutoSecretKey.", this.AutoSecretKey);
            this.SetParamSimple(map, prefix + "OperationSource", this.OperationSource);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

