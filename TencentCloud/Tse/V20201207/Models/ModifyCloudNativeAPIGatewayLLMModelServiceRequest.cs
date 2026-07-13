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

    public class ModifyCloudNativeAPIGatewayLLMModelServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关 id。</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>模型服务 ID，全局唯一标识。</p>
        /// </summary>
        [JsonProperty("ModelServiceId")]
        public string ModelServiceId{ get; set; }

        /// <summary>
        /// <p>修改服务名称，长度2-50字符，支持中英文、数字、下划线。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>修改默认模型，模型选择方式为 Specify 时必填。</p>
        /// </summary>
        [JsonProperty("DefaultModel")]
        public string DefaultModel{ get; set; }

        /// <summary>
        /// <p>修改模型选择方式，选项：Specify（指定模型）、PassThrough（透传请求模型）。</p>
        /// </summary>
        [JsonProperty("ModelSelector")]
        public string ModelSelector{ get; set; }

        /// <summary>
        /// <p>修改开启模型降级，模型选择方式为 Specify 时必填。</p>
        /// </summary>
        [JsonProperty("EnableModelFallback")]
        public bool? EnableModelFallback{ get; set; }

        /// <summary>
        /// <p>修改可以配置备用模型规则，EnableSpecifyModelFallback 为 true 时必填。</p>
        /// </summary>
        [JsonProperty("ModelFallbackRule")]
        public CloudNativeAPIGatewayLLMModelFallbackRule ModelFallbackRule{ get; set; }

        /// <summary>
        /// <p>修改开启模型参数校验，是否校验客户端传递的 model 参数, 模型选择方式为 PassThrough 时必填</p>
        /// </summary>
        [JsonProperty("EnableModelParamCheck")]
        public bool? EnableModelParamCheck{ get; set; }

        /// <summary>
        /// <p>修改模型检验信息，EnableModelParamCheck 为 true 时必填。</p>
        /// </summary>
        [JsonProperty("ModelParamCheckRule")]
        public CloudNativeAPIGatewayLLMModelParamCheckInfo ModelParamCheckRule{ get; set; }

        /// <summary>
        /// <p>修改描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>修改模型服务地址</p>
        /// </summary>
        [JsonProperty("UpstreamURL")]
        public string UpstreamURL{ get; set; }

        /// <summary>
        /// <p>连接超时时间</p><p>取值范围：[1, 3600000]</p><p>单位：毫秒</p><p>默认值：10000</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public long? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>写入超时时间</p><p>取值范围：[1, 3600000]</p><p>单位：毫秒</p><p>默认值：60000</p>
        /// </summary>
        [JsonProperty("WriteTimeout")]
        public long? WriteTimeout{ get; set; }

        /// <summary>
        /// <p>读取超时时间</p><p>取值范围：[1, 3600000]</p><p>单位：毫秒</p><p>默认值：60000</p>
        /// </summary>
        [JsonProperty("ReadTimeout")]
        public long? ReadTimeout{ get; set; }

        /// <summary>
        /// <p>重试次数</p><p>取值范围：[0, 5]</p><p>单位：次</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Retries")]
        public long? Retries{ get; set; }

        /// <summary>
        /// <p>路径拼接模式</p><p>枚举值：</p><ul><li>FixedPath： 固定路径</li><li>AutoConcat： 自动拼接</li></ul>
        /// </summary>
        [JsonProperty("UpstreamUrlMode")]
        public string UpstreamUrlMode{ get; set; }

        /// <summary>
        /// <p>SNI</p>
        /// </summary>
        [JsonProperty("SNI")]
        public string SNI{ get; set; }

        /// <summary>
        /// <p>模型服务级别的配额上限（RPM/TPM）。需要网关版本 ≥ 3.9.4。</p>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public AIGWLLMQuotaLimit QuotaLimit{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>模型改写规则</p>
        /// </summary>
        [JsonProperty("ModelRewriteRules")]
        public AIGWModelRewriteRule[] ModelRewriteRules{ get; set; }

        /// <summary>
        /// <p>来源 id</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>服务名字</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>扩展参数</p>
        /// </summary>
        [JsonProperty("ExtParams")]
        public KeyValue[] ExtParams{ get; set; }

        /// <summary>
        /// <p>密钥轮转开关</p>
        /// </summary>
        [JsonProperty("KeyRotationEnabled")]
        public bool? KeyRotationEnabled{ get; set; }

        /// <summary>
        /// <p>密钥轮转天数</p>
        /// </summary>
        [JsonProperty("KeyRotationPeriodDays")]
        public ulong? KeyRotationPeriodDays{ get; set; }

        /// <summary>
        /// <p>外部服务来源ID</p>
        /// </summary>
        [JsonProperty("ExternalInstanceId")]
        public string ExternalInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ModelServiceId", this.ModelServiceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DefaultModel", this.DefaultModel);
            this.SetParamSimple(map, prefix + "ModelSelector", this.ModelSelector);
            this.SetParamSimple(map, prefix + "EnableModelFallback", this.EnableModelFallback);
            this.SetParamObj(map, prefix + "ModelFallbackRule.", this.ModelFallbackRule);
            this.SetParamSimple(map, prefix + "EnableModelParamCheck", this.EnableModelParamCheck);
            this.SetParamObj(map, prefix + "ModelParamCheckRule.", this.ModelParamCheckRule);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "UpstreamURL", this.UpstreamURL);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "WriteTimeout", this.WriteTimeout);
            this.SetParamSimple(map, prefix + "ReadTimeout", this.ReadTimeout);
            this.SetParamSimple(map, prefix + "Retries", this.Retries);
            this.SetParamSimple(map, prefix + "UpstreamUrlMode", this.UpstreamUrlMode);
            this.SetParamSimple(map, prefix + "SNI", this.SNI);
            this.SetParamObj(map, prefix + "QuotaLimit.", this.QuotaLimit);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "ModelRewriteRules.", this.ModelRewriteRules);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "ExtParams.", this.ExtParams);
            this.SetParamSimple(map, prefix + "KeyRotationEnabled", this.KeyRotationEnabled);
            this.SetParamSimple(map, prefix + "KeyRotationPeriodDays", this.KeyRotationPeriodDays);
            this.SetParamSimple(map, prefix + "ExternalInstanceId", this.ExternalInstanceId);
        }
    }
}

