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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEndpointRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>服务名称。最大 64 字符。</p>
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// <p>模型 ID。可通过 DescribeModelList 接口获取。</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>计费方式。取值：FREE（免费体验）、TOKEN（按 Token 计费）、TPM（TPM 保障）、COMPUTE_UNIT（按算力单元计费）。</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>RPM（每分钟请求数）限流上限。可选。必须大于 0，且不能超过用户在该模型上的 RPM 上限。不传则使用默认值（60）。</p>
        /// </summary>
        [JsonProperty("RPM")]
        public long? RPM{ get; set; }

        /// <summary>
        /// <p>TPM（每分钟 Token 数）限流上限，单位为 tokens/min。可选。必须大于 0，且不能超过用户在该模型上的 TPM 上限。设置后会同时作用于输入 TPM 和输出 TPM。不传则使用默认值（0 表示不限流）。</p>
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }

        /// <summary>
        /// <p>自动调整配额</p>
        /// </summary>
        [JsonProperty("AutoAdjustQuota")]
        public long? AutoAdjustQuota{ get; set; }

        /// <summary>
        /// <p>自定义推理服务 id</p>
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointName", this.EndpointName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "RPM", this.RPM);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
            this.SetParamSimple(map, prefix + "AutoAdjustQuota", this.AutoAdjustQuota);
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
        }
    }
}

