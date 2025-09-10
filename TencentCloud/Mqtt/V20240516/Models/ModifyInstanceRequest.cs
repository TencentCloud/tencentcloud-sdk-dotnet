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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要修改实例名称，不能为空, 3-64个字符，只能包含数字、字母、“-”和“_”。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 要修改的备注信息，最多128个字符。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 需要变更的配置规格
        /// 基础版和专业版集群不能升配到铂金版规格，铂金版集群不能降配至基础版和增强版规格。
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 客户端证书注册方式：
        /// JITP：自动注册
        /// API：手动通过API注册
        /// </summary>
        [JsonProperty("DeviceCertificateProvisionType")]
        [System.Obsolete]
        public string DeviceCertificateProvisionType{ get; set; }

        /// <summary>
        /// 自动注册证书是否自动激活
        /// </summary>
        [JsonProperty("AutomaticActivation")]
        [System.Obsolete]
        public bool? AutomaticActivation{ get; set; }

        /// <summary>
        /// 授权策略开关
        /// </summary>
        [JsonProperty("AuthorizationPolicy")]
        public bool? AuthorizationPolicy{ get; set; }

        /// <summary>
        /// 是否使用默认的服务端证书
        /// </summary>
        [JsonProperty("UseDefaultServerCert")]
        public bool? UseDefaultServerCert{ get; set; }

        /// <summary>
        /// TLS：单向认证
        /// mTLS；双向认证
        /// BYOC：一机一证
        /// </summary>
        [JsonProperty("X509Mode")]
        public string X509Mode{ get; set; }

        /// <summary>
        /// 单客户端消息收发限速单位 条/秒
        /// </summary>
        [JsonProperty("MessageRate")]
        public long? MessageRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "DeviceCertificateProvisionType", this.DeviceCertificateProvisionType);
            this.SetParamSimple(map, prefix + "AutomaticActivation", this.AutomaticActivation);
            this.SetParamSimple(map, prefix + "AuthorizationPolicy", this.AuthorizationPolicy);
            this.SetParamSimple(map, prefix + "UseDefaultServerCert", this.UseDefaultServerCert);
            this.SetParamSimple(map, prefix + "X509Mode", this.X509Mode);
            this.SetParamSimple(map, prefix + "MessageRate", this.MessageRate);
        }
    }
}

