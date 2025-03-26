/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class RegisterCaCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// CA证书内容，自签CA可参考 [自定义 X.509 证书实现 “一机一证”](https://cloud.tencent.com/document/product/1778/114817) 签发自签CA
        /// </summary>
        [JsonProperty("CaCertificate")]
        public string CaCertificate{ get; set; }

        /// <summary>
        /// 验证证书内容，可参考 [自定义 X.509 证书实现 “一机一证”](https://cloud.tencent.com/document/product/1778/114817) 手动注册CA证书章节
        /// </summary>
        [JsonProperty("VerificationCertificate")]
        public string VerificationCertificate{ get; set; }

        /// <summary>
        /// 证书格式，不传默认PEM格式，当前仅支持PEM格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 证书状态，不传默认ACTIVE状态
        ///     ACTIVE：激活
        ///     INACTIVE：未激活
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CaCertificate", this.CaCertificate);
            this.SetParamSimple(map, prefix + "VerificationCertificate", this.VerificationCertificate);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

