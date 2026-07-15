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

    public class ModifyHealthCheckTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>健康检查模板 ID，格式为 hct- 后接字母数字。</p>
        /// </summary>
        [JsonProperty("HealthCheckTemplateId")]
        public string HealthCheckTemplateId{ get; set; }

        /// <summary>
        /// <p>是否预览此次请求。</p><ul><li><strong>false</strong>（默认）：发送普通请求，直接修改健康检查模板。</li><li><strong>true</strong>：发送预览请求，检查修改健康检查模板的参数、格式、业务限制等是否符合要求。</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>健康检查状态码。取值：</p><ul><li>当健康检查协议为<strong>HTTP/HTTPS</strong>时：<ul><li><strong>http_1xx</strong></li><li><strong>http_2xx</strong>（默认值）</li><li><strong>http_3xx</strong></li><li><strong>http_4xx</strong></li><li><strong>http_5xx</strong></li></ul></li><li>当健康检查协议为<strong>GRPC/GRPCS</strong>时：默认值为<strong>12</strong>，数值范围为<strong>0-99</strong>，输入值可为数值、多个数值或者范围以及相互组合，如：<ul><li><strong>&quot;20&quot;</strong></li><li><strong>&quot;0-99&quot;</strong></li></ul></li></ul>
        /// </summary>
        [JsonProperty("HealthCheckCodes")]
        public string[] HealthCheckCodes{ get; set; }

        /// <summary>
        /// <p>判定后端服务健康的阈值，当健康检查连续成功多少次后，后端服务的状态由<strong>不健康</strong>变为<strong>健康</strong>。<br>取值范围：<strong>2</strong>-<strong>10</strong>。<br>默认值：<strong>2</strong>。</p>
        /// </summary>
        [JsonProperty("HealthCheckHealthyThreshold")]
        public ulong? HealthCheckHealthyThreshold{ get; set; }

        /// <summary>
        /// <p>健康检查域名。<br>长度限制为 <strong>1-255</strong> 个字符。<br>可包含小写字母、数字、短划线（-）和半角句号（.）。</p><blockquote><p>仅当 <strong>HealthCheckProtocol</strong> 设置为 <strong>HTTP/HTTPS/GRPC/GRPCS</strong> 时，该参数生效。</p></blockquote>
        /// </summary>
        [JsonProperty("HealthCheckHost")]
        public string HealthCheckHost{ get; set; }

        /// <summary>
        /// <p>健康检查 HTTP 协议版本，取值：</p><ul><li><strong>HTTP1.1</strong>（默认）</li><li><strong>HTTP1.0</strong> <blockquote><p>仅当<strong>HealthCheckProtocol</strong>设置为<strong>HTTP</strong> 或 <strong>HTTPS</strong> 时，该参数生效。</p></blockquote></li></ul>
        /// </summary>
        [JsonProperty("HealthCheckHttpVersion")]
        public string HealthCheckHttpVersion{ get; set; }

        /// <summary>
        /// <p>健康检查的时间间隔。单位：秒。 取值范围：<strong>2</strong>-<strong>300</strong>。 默认值：<strong>5</strong>。</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>健康检查方法，取值： - <strong>GET</strong> - <strong>HEAD</strong>（默认值） </p><blockquote><p>仅当<strong>HealthCheckProtocol</strong>设置为<strong>HTTP</strong> 或 <strong>HTTPS</strong> 时，该参数生效。</p></blockquote>
        /// </summary>
        [JsonProperty("HealthCheckMethod")]
        public string HealthCheckMethod{ get; set; }

        /// <summary>
        /// <p>健康检查的转发规则路径。 长度为 <strong>1-80</strong> 个字符，只能使用字母、数字、字符<code>-/.%?#&amp;=</code>以及扩展字符<code>_;~!（)*[]@$^:&#39;,+</code>。 URL 必须以正斜线（/）开头。 </p><blockquote><p>仅当<strong>HealthCheckProtocol</strong>为<strong>HTTP/HTTPS/GRPC/GRPCS</strong>时，转发规则路径参数生效。</p></blockquote>
        /// </summary>
        [JsonProperty("HealthCheckPath")]
        public string HealthCheckPath{ get; set; }

        /// <summary>
        /// <p>健康检查访问后端服务器的端口。  取值范围：<strong>0-65535</strong>。  默认值：<strong>0</strong>，表示后端服务器的端口。</p>
        /// </summary>
        [JsonProperty("HealthCheckPort")]
        public ulong? HealthCheckPort{ get; set; }

        /// <summary>
        /// <p>健康检查协议。取值：</p><ul><li><strong>HTTP</strong>（默认）：通过发送 HEAD 或 GET 请求模拟浏览器的访问行为来检查服务器应用是否健康。</li><li><strong>HTTPS</strong>：通过发送 HEAD 或 GET 请求模拟浏览器的访问行为来检查服务器应用是否健康。（数据加密，相比 HTTP 更安全。）</li><li><strong>TCP</strong>：通过发送 SYN 握手报文来检测服务器端口是否存活。</li><li><strong>GRPC</strong>：通过发送 POST 或 GET 请求来检查服务器应用是否健康。</li><li><strong>GRPCS</strong>：通过发送 POST 或 GET 请求来检查服务器应用是否健康。</li></ul>
        /// </summary>
        [JsonProperty("HealthCheckProtocol")]
        public string HealthCheckProtocol{ get; set; }

        /// <summary>
        /// <p>健康检查模板名称。长度为 <strong>1-255</strong> 个字符，可包含数字、大小写字母、中文、半角句号（.）、下划线（_）和短划线（-）。</p>
        /// </summary>
        [JsonProperty("HealthCheckTemplateName")]
        public string HealthCheckTemplateName{ get; set; }

        /// <summary>
        /// <p>健康检查的响应超时时间。单位：秒。<br>取值范围：<strong>2</strong>-<strong>60</strong>。<br>默认值：<strong>2</strong>。</p>
        /// </summary>
        [JsonProperty("HealthCheckTimeout")]
        public ulong? HealthCheckTimeout{ get; set; }

        /// <summary>
        /// <p>判定后端服务不健康的阈值，当健康检查连续失败多少次后，后端服务的状态由<strong>健康</strong>变为<strong>不健康</strong>。<br>取值范围：<strong>2</strong>-<strong>10</strong>。<br>默认值：<strong>2</strong>。</p>
        /// </summary>
        [JsonProperty("HealthCheckUnhealthyThreshold")]
        public ulong? HealthCheckUnhealthyThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckTemplateId", this.HealthCheckTemplateId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamArraySimple(map, prefix + "HealthCheckCodes.", this.HealthCheckCodes);
            this.SetParamSimple(map, prefix + "HealthCheckHealthyThreshold", this.HealthCheckHealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckHost", this.HealthCheckHost);
            this.SetParamSimple(map, prefix + "HealthCheckHttpVersion", this.HealthCheckHttpVersion);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "HealthCheckMethod", this.HealthCheckMethod);
            this.SetParamSimple(map, prefix + "HealthCheckPath", this.HealthCheckPath);
            this.SetParamSimple(map, prefix + "HealthCheckPort", this.HealthCheckPort);
            this.SetParamSimple(map, prefix + "HealthCheckProtocol", this.HealthCheckProtocol);
            this.SetParamSimple(map, prefix + "HealthCheckTemplateName", this.HealthCheckTemplateName);
            this.SetParamSimple(map, prefix + "HealthCheckTimeout", this.HealthCheckTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckUnhealthyThreshold", this.HealthCheckUnhealthyThreshold);
        }
    }
}

