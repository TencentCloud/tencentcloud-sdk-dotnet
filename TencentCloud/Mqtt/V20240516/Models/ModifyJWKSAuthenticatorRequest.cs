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

    public class ModifyJWKSAuthenticatorRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// JWKS服务器地址，（Text字段和Endpoint字段必须选择一个填写）
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 认证器状态：open-启用（默认）；close-关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 认证文本刷新间隔时间，单位：秒，最小值60，默认值60，最大值1000。填写认证服务器地址时生效。
        /// </summary>
        [JsonProperty("RefreshInterval")]
        public long? RefreshInterval{ get; set; }

        /// <summary>
        /// JWKS文本，认证服务器地址为空时生效。（Text字段和Endpoint字段必须选择一个填写）
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 认证字段；
        /// username-对应 MQTT CONNECT Packet 中 username 字段， 
        /// password-对应 MQTT CONNECT Packet 中 password 字段。默认username
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 说明，不能超过 128 个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RefreshInterval", this.RefreshInterval);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

