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

    public class ModifyInstanceCertBindingRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 服务端证书id
        /// </summary>
        [JsonProperty("SSLServerCertId")]
        public string SSLServerCertId{ get; set; }

        /// <summary>
        /// CA证书id
        /// </summary>
        [JsonProperty("SSLCaCertId")]
        public string SSLCaCertId{ get; set; }

        /// <summary>
        /// 加密通信方式
        /// TLS：单向证书认证
        /// mTLS：双向证书认证
        /// BYOC：一设备一证书认证
        /// </summary>
        [JsonProperty("X509Mode")]
        public string X509Mode{ get; set; }

        /// <summary>
        /// 设备证书注册类型：
        /// JITP，自动注册；
        /// MANUAL 手动注册
        /// </summary>
        [JsonProperty("DeviceCertificateProvisionType")]
        public string DeviceCertificateProvisionType{ get; set; }

        /// <summary>
        /// 是否自动激活，默认为false
        /// </summary>
        [JsonProperty("AutomaticActivation")]
        public bool? AutomaticActivation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SSLServerCertId", this.SSLServerCertId);
            this.SetParamSimple(map, prefix + "SSLCaCertId", this.SSLCaCertId);
            this.SetParamSimple(map, prefix + "X509Mode", this.X509Mode);
            this.SetParamSimple(map, prefix + "DeviceCertificateProvisionType", this.DeviceCertificateProvisionType);
            this.SetParamSimple(map, prefix + "AutomaticActivation", this.AutomaticActivation);
        }
    }
}

