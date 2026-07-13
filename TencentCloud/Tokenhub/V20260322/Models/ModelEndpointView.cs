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

    public class ModelEndpointView : AbstractModel
    {
        
        /// <summary>
        /// <p>推理服务 ID。网关默认创建的 id 与模型 id 相同；控制台自定义推理服务以 ep- 开头。</p>
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }

        /// <summary>
        /// <p>推理服务名称。未激活时与 ModelId 相同。</p>
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// <p>模型 ID。</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>模型名称。</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>状态。取值：ACTIVE（运行中）、INACTIVE（已停止）。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>服务类型。固定为 TEXT_GENERATION（文本生成）。</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>计费方式。取值：FREE（免费体验）、TOKEN（按 Token 计费）。未激活时为空。</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>是否已开启后付费。true 表示已开启，false 表示未开启。未激活时为 false。</p>
        /// </summary>
        [JsonProperty("PaymentEnabled")]
        public bool? PaymentEnabled{ get; set; }

        /// <summary>
        /// <p>计费详情信息，JSON 格式字符串，包含免费额度用量等信息。未激活时为空。</p>
        /// </summary>
        [JsonProperty("ChargeDetail")]
        public string ChargeDetail{ get; set; }

        /// <summary>
        /// <p>停止原因。当状态为 INACTIVE 时返回。取值：FREE_QUOTA_EXHAUSTED（免费额度已用尽）、NO_FREE_PACKAGE（无可用免费包）、INSUFFICIENT_BALANCE（余额不足）、BILLING_ISOLATED（账户欠费隔离）、INTERNAL_ERROR（内部错误）。</p>
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// <p>推理服务的 rpm 限制，没设置就按模型维度 rpm 限制展示</p>
        /// </summary>
        [JsonProperty("RPM")]
        public long? RPM{ get; set; }

        /// <summary>
        /// <p>推理服务的tpm 限制，没设置就按模型维度 tpm 限制展示</p>
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
            this.SetParamSimple(map, prefix + "EndpointName", this.EndpointName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "PaymentEnabled", this.PaymentEnabled);
            this.SetParamSimple(map, prefix + "ChargeDetail", this.ChargeDetail);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "RPM", this.RPM);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
        }
    }
}

