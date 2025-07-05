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

    public class ModifyJWTAuthenticatorRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 签名方式：hmac-based，public-key
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// 认证字段
        /// password：对应 MQTT CONNECT Packet 中 password 字段，
        /// username：对应 MQTT CONNECT Packet 中 username 字段
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 密钥，Algorithm为hmac-based需要传递该字段。
        /// </summary>
        [JsonProperty("Secret")]
        public string Secret{ get; set; }

        /// <summary>
        /// 公钥，Algorithm为public-key时需要传递该字段。
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// 认证器是否开启：open-启用；close-关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 说明，不能超过 128 个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// JSKS文本
        /// </summary>
        [JsonProperty("Text")]
        [System.Obsolete]
        public string Text{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Secret", this.Secret);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Text", this.Text);
        }
    }
}

