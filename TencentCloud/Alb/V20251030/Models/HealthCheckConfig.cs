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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启健康检查。
        /// - **true**：开启。
        /// - **false**：不开启。
        /// </summary>
        [JsonProperty("HealthCheckEnabled")]
        public bool? HealthCheckEnabled{ get; set; }

        /// <summary>
        /// 健康检查状态码。取值：
        /// - 当健康检查协议为**HTTP/HTTPS**时：
        /// 	- **http_1xx**
        /// 	- **http_2xx**（默认值）
        /// 	-  **http_3xx**
        /// 	-  **http_4xx**
        /// 	-  **http_5xx**
        /// - 当健康检查协议为**gRPC**时：默认值为12，数值范围为0-99，输入值可为数值、多个数值或者范围以及相互组合，如：
        /// 	- **"20"**
        /// 	- **"0-99"**
        /// > 仅当**HealthCheckProtocol**设置为**HTTP** 、**HTTPS**、**GRPC** 或者**GRPCS**时，该参数生效。
        /// </summary>
        [JsonProperty("HealthCheckCodes")]
        public string[] HealthCheckCodes{ get; set; }

        /// <summary>
        /// 判定后端服务健康的阈值，当健康检查连续成功多少次后，后端服务的状态由**不健康**变为**健康**。
        /// 取值范围：**2**-**10**。
        /// 默认值：**2**。
        /// </summary>
        [JsonProperty("HealthCheckHealthyThreshold")]
        public ulong? HealthCheckHealthyThreshold{ get; set; }

        /// <summary>
        /// 健康检查域名。该参数不设置时默认使用后端服务的内网IP作为健康检查地址。
        /// 域名限制：
        /// - 长度限制为 **1-255** 个字符。
        /// - 可包含小写字母、数字、短划线（-）和半角句号（.）。
        /// - 至少包含一个半角句号（.），半角句号（.）不能出现在开头或结尾。
        /// - 最右侧的域标签，只能包含字母，不能包含数字或短划线（-）。
        /// - 短划线（-）不能出现在开头或结尾。
        /// >仅当 **HealthCheckProtocol** 设置为 **HTTP、HTTPS** 、**GRPC**、**GRPCS** 时，该参数生效。
        /// </summary>
        [JsonProperty("HealthCheckHost")]
        public string HealthCheckHost{ get; set; }

        /// <summary>
        /// 健康检查 HTTP 协议版本，取值：
        /// - **HTTP1.1**（默认）
        /// - **HTTP1.0** 
        /// > 仅当**HealthCheckProtocol**设置为**HTTP** 或 **HTTPS** 时，该参数生效。
        /// </summary>
        [JsonProperty("HealthCheckHttpVersion")]
        public string HealthCheckHttpVersion{ get; set; }

        /// <summary>
        /// 健康检查的时间间隔。单位：秒。
        /// 取值范围：**2**-**300**。
        /// 默认值：**5**。
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// 健康检查方法，取值：
        /// - **GET**
        /// - **HEAD**（默认值）
        /// > 仅当**HealthCheckProtocol**设置为**HTTP** 或 **HTTPS** 时，该参数生效。
        /// </summary>
        [JsonProperty("HealthCheckMethod")]
        public string HealthCheckMethod{ get; set; }

        /// <summary>
        /// 健康检查的转发规则路径。
        /// 长度为 1~80 个字符，只能使用字母、数字、字符`-/.%?#&=`以及扩展字符`_;~!（)*[]@$^:',+`。 URL 必须以正斜线（/）开头。
        /// > 仅当**HealthCheckProtocol**为**HTTP**、**HTTPS** 、**GRPC**、**GRPCS**时，转发规则路径参数生效。
        /// </summary>
        [JsonProperty("HealthCheckPath")]
        public string HealthCheckPath{ get; set; }

        /// <summary>
        /// 健康检查访问后端服务器的端口。
        /// 
        /// 取值范围：**0-65535**。
        /// 
        /// 默认值：**0**，表示后端服务器的端口。
        /// </summary>
        [JsonProperty("HealthCheckPort")]
        public ulong? HealthCheckPort{ get; set; }

        /// <summary>
        /// 健康检查协议。取值：
        /// - **HTTP**（默认）：通过发送 HEAD 或 GET 请求模拟浏览器的访问行为来检查服务器应用是否健康。
        /// - **HTTPS**：通过发送 HEAD 或 GET 请求模拟浏览器的访问行为来检查服务器应用是否健康。（数据加密，相比 HTTP 更安全。）
        /// - **TCP**：通过发送 SYN 握手报文来检测服务器端口是否存活。
        /// - **GRPC**：通过发送 POST 请求来检查服务器应用是否健康。
        /// - **GRPCS**：通过发送 POST 请求来检查服务器应用是否健康。
        /// </summary>
        [JsonProperty("HealthCheckProtocol")]
        public string HealthCheckProtocol{ get; set; }

        /// <summary>
        /// 健康检查的响应超时时间。单位：秒。
        /// 取值范围：**2**-**60**。
        /// 默认值：**2**。
        /// </summary>
        [JsonProperty("HealthCheckTimeout")]
        public ulong? HealthCheckTimeout{ get; set; }

        /// <summary>
        /// 判定后端服务不健康的阈值，当健康检查连续失败多少次后，后端服务的状态由**健康**变为**不健康**。
        /// 取值范围：**2**-**10**。
        /// 默认值：**2**。
        /// </summary>
        [JsonProperty("HealthCheckUnhealthyThreshold")]
        public ulong? HealthCheckUnhealthyThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckEnabled", this.HealthCheckEnabled);
            this.SetParamArraySimple(map, prefix + "HealthCheckCodes.", this.HealthCheckCodes);
            this.SetParamSimple(map, prefix + "HealthCheckHealthyThreshold", this.HealthCheckHealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckHost", this.HealthCheckHost);
            this.SetParamSimple(map, prefix + "HealthCheckHttpVersion", this.HealthCheckHttpVersion);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "HealthCheckMethod", this.HealthCheckMethod);
            this.SetParamSimple(map, prefix + "HealthCheckPath", this.HealthCheckPath);
            this.SetParamSimple(map, prefix + "HealthCheckPort", this.HealthCheckPort);
            this.SetParamSimple(map, prefix + "HealthCheckProtocol", this.HealthCheckProtocol);
            this.SetParamSimple(map, prefix + "HealthCheckTimeout", this.HealthCheckTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckUnhealthyThreshold", this.HealthCheckUnhealthyThreshold);
        }
    }
}

