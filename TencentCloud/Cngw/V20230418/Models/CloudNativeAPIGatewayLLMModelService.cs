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

    public class CloudNativeAPIGatewayLLMModelService : AbstractModel
    {
        
        /// <summary>
        /// <p>模型服务 ID。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>模型服务名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间。</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>服务类型，目前只支持xa0LLMService。</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>选择模型提供商, 选项：OpenAI、Anthropic、Azure OpenAI、自定义HTTP。</p>
        /// </summary>
        [JsonProperty("ModelProvider")]
        public string ModelProvider{ get; set; }

        /// <summary>
        /// <p>API协议标准，根据供应商动态变化：OpenAI→OpenAI/v1，Anthropic→Anthropic/v1等</p>
        /// </summary>
        [JsonProperty("ModelProtocol")]
        public string ModelProtocol{ get; set; }

        /// <summary>
        /// <p>自定义的模型请求 URL。</p>
        /// </summary>
        [JsonProperty("UpstreamURL")]
        public string UpstreamURL{ get; set; }

        /// <summary>
        /// <p>模型选择方式，选项：Specify（指定模型）、PassThrough（透传请求模型）。</p>
        /// </summary>
        [JsonProperty("ModelSelector")]
        public string ModelSelector{ get; set; }

        /// <summary>
        /// <p>默认模型，模型选择方式为 Specify 时必填。</p>
        /// </summary>
        [JsonProperty("DefaultModel")]
        public string DefaultModel{ get; set; }

        /// <summary>
        /// <p>开启模型降级，模型选择方式为 Specify 时必填。</p>
        /// </summary>
        [JsonProperty("EnableModelFallback")]
        public bool? EnableModelFallback{ get; set; }

        /// <summary>
        /// <p>可以配置备用模型规则，EnableSpecifyModelFallbackxa0为 true 时必填。</p>
        /// </summary>
        [JsonProperty("ModelFallbackRule")]
        public CloudNativeAPIGatewayLLMModelFallbackRule ModelFallbackRule{ get; set; }

        /// <summary>
        /// <p>开启模型参数校验，是否校验客户端传递的 model 参数,xa0模型选择方式为 PassThrough 时必填。</p>
        /// </summary>
        [JsonProperty("EnableModelParamCheck")]
        public bool? EnableModelParamCheck{ get; set; }

        /// <summary>
        /// <p>模型检验信息，EnableModelParamCheckxa0为 true 时必填。</p>
        /// </summary>
        [JsonProperty("ModelParamCheckRule")]
        public CloudNativeAPIGatewayLLMModelParamCheckInfo ModelParamCheckRule{ get; set; }

        /// <summary>
        /// <p>描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

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
        /// <p>读取超时时间</p><p>取值范围：[1, 3600000]</p><p>单位：毫秒</p>
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
        /// <p>sni</p>
        /// </summary>
        [JsonProperty("SNI")]
        public string SNI{ get; set; }

        /// <summary>
        /// <p>配额限制</p>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public AIGWLLMQuotaLimit QuotaLimit{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// <p>绑定的模型服务秘钥</p>
        /// </summary>
        [JsonProperty("SecretKeyIds")]
        public string[] SecretKeyIds{ get; set; }

        /// <summary>
        /// <p>模型改写规则</p>
        /// </summary>
        [JsonProperty("ModelRewriteRules")]
        public AIGWModelRewriteRule[] ModelRewriteRules{ get; set; }

        /// <summary>
        /// <p>服务来源</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>服务名称</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>扩展参数</p>
        /// </summary>
        [JsonProperty("ExtParams")]
        public KeyValue[] ExtParams{ get; set; }

        /// <summary>
        /// <p>模型自定义供应商名称</p>
        /// </summary>
        [JsonProperty("CustomProviderName")]
        public string CustomProviderName{ get; set; }

        /// <summary>
        /// <p>是否开启密钥轮转</p>
        /// </summary>
        [JsonProperty("KeyRotationEnabled")]
        public bool? KeyRotationEnabled{ get; set; }

        /// <summary>
        /// <p>密钥轮转周期</p><p>单位：天</p>
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
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ModelProvider", this.ModelProvider);
            this.SetParamSimple(map, prefix + "ModelProtocol", this.ModelProtocol);
            this.SetParamSimple(map, prefix + "UpstreamURL", this.UpstreamURL);
            this.SetParamSimple(map, prefix + "ModelSelector", this.ModelSelector);
            this.SetParamSimple(map, prefix + "DefaultModel", this.DefaultModel);
            this.SetParamSimple(map, prefix + "EnableModelFallback", this.EnableModelFallback);
            this.SetParamObj(map, prefix + "ModelFallbackRule.", this.ModelFallbackRule);
            this.SetParamSimple(map, prefix + "EnableModelParamCheck", this.EnableModelParamCheck);
            this.SetParamObj(map, prefix + "ModelParamCheckRule.", this.ModelParamCheckRule);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "WriteTimeout", this.WriteTimeout);
            this.SetParamSimple(map, prefix + "ReadTimeout", this.ReadTimeout);
            this.SetParamSimple(map, prefix + "Retries", this.Retries);
            this.SetParamSimple(map, prefix + "UpstreamUrlMode", this.UpstreamUrlMode);
            this.SetParamSimple(map, prefix + "SNI", this.SNI);
            this.SetParamObj(map, prefix + "QuotaLimit.", this.QuotaLimit);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamArraySimple(map, prefix + "SecretKeyIds.", this.SecretKeyIds);
            this.SetParamArrayObj(map, prefix + "ModelRewriteRules.", this.ModelRewriteRules);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "ExtParams.", this.ExtParams);
            this.SetParamSimple(map, prefix + "CustomProviderName", this.CustomProviderName);
            this.SetParamSimple(map, prefix + "KeyRotationEnabled", this.KeyRotationEnabled);
            this.SetParamSimple(map, prefix + "KeyRotationPeriodDays", this.KeyRotationPeriodDays);
            this.SetParamSimple(map, prefix + "ExternalInstanceId", this.ExternalInstanceId);
        }
    }
}

