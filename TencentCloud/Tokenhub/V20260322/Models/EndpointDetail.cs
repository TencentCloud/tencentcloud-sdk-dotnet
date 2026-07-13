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

    public class EndpointDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>推理服务 ID。</p>
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }

        /// <summary>
        /// <p>服务名称。</p>
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// <p>模型名称。</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型 ID。</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>状态。取值：ACTIVE（使用中）、INACTIVE（停止中）。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>服务类型。取值：TEXT_GENERATION（文本生成）、IMAGE_GENERATION（图片生成）、VIDEO_GENERATION（视频生成）。</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>计费方式。取值：FREE（免费体验）、TOKEN（按 Token 计费）</p><p>枚举值：</p><ul><li>FREE： 免费体验</li><li>TOKEN： 按 Token 计费</li></ul>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>是否开启付费计费。true 表示已开启付费资源包，false 表示仅使用免费额度。</p>
        /// </summary>
        [JsonProperty("PaymentEnabled")]
        public bool? PaymentEnabled{ get; set; }

        /// <summary>
        /// <p>计费详情信息，JSON 格式字符串。不同 ChargeType 对应不同的 JSON 结构：</p><ul><li>免费额度信息（所有类型均可能包含）：{&quot;FreeQuota&quot;: {&quot;TotalQuota&quot;: 200, &quot;UsedQuota&quot;: 56, &quot;UsagePercent&quot;: 28, &quot;ExpireTime&quot;: &quot;2026-06-15T00:00:00Z&quot;}}</li><li>TPM 类型额外包含：{&quot;Tpm&quot;: {&quot;TpmInputLimit&quot;: 1000, &quot;TpmOutputLimit&quot;: 1000}}</li><li>其他类型：预留扩展。</li></ul>
        /// </summary>
        [JsonProperty("ChargeDetail")]
        public string ChargeDetail{ get; set; }

        /// <summary>
        /// <p>停止原因。当状态为 INACTIVE 时返回。取值：FREE_QUOTA_EXHAUSTED（免费额度已用尽）、NO_FREE_PACKAGE（无可用免费包）、INSUFFICIENT_BALANCE（余额不足，格式为 INSUFFICIENT_BALANCE:&lt;待支付资源ID&gt;）、BILLING_ISOLATED（账户欠费隔离）、INTERNAL_ERROR（内部错误）。当值为 INSUFFICIENT_BALANCE 时，冒号后附带待支付的 TPM 包资源 ID，前端可据此引导用户前往对应订单页完成支付。</p>
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// <p>TPM（每分钟 Token 限流）。当推理服务未单独设置时，回退为关联模型的默认 TPM 值。</p>
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }

        /// <summary>
        /// <p>自动调整配额</p>
        /// </summary>
        [JsonProperty("AutoAdjustQuota")]
        public long? AutoAdjustQuota{ get; set; }

        /// <summary>
        /// <p>RPM（每分钟请求数限流）。当推理服务未单独设置时，回退为关联模型的默认 RPM 值。</p>
        /// </summary>
        [JsonProperty("RPM")]
        public long? RPM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
            this.SetParamSimple(map, prefix + "EndpointName", this.EndpointName);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "PaymentEnabled", this.PaymentEnabled);
            this.SetParamSimple(map, prefix + "ChargeDetail", this.ChargeDetail);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
            this.SetParamSimple(map, prefix + "AutoAdjustQuota", this.AutoAdjustQuota);
            this.SetParamSimple(map, prefix + "RPM", this.RPM);
        }
    }
}

