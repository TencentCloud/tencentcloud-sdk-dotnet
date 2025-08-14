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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupHealthCheck : AbstractModel
    {
        
        /// <summary>
        /// 是否开启健康检查。
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public bool? HealthSwitch{ get; set; }

        /// <summary>
        /// 健康检查方式， 其中仅V2新版目标组类型支持该参数， 支持取值 TCP | HTTP | HTTPS | PING | CUSTOM，其中:
        /// <ur><li>当目标组后端转发协议为TCP时， 健康检查方式支持 TCP/HTTP/CUSTOM， 默认为TCP。</li><li>当目标组后端转发协议为UDP时， 健康检查方式支持 PING/CUSTOM，默认为PING。</li><li>当目标组后端转发协议为HTTP时， 健康检查方式支持 HTTP/TCP， 默认为HTTP。</li><li>当目标组后端转发协议为HTTPS时， 健康检查方式支持 HTTPS/TCP， 默认为HTTPS。</li><li>当目标组后端转发协议为GRPC时， 健康检查方式支持GRPC/TCP， 默认为GRPC。</li></ur>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查端口，默认为后端服务的端口，除非您希望指定特定端口，否则建议留空。（仅适用于TCP/UDP目标组）。
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 健康检查超时时间。 默认为2秒。 可配置范围：2 - 30秒。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 检测间隔时间。 默认为5秒。 可配置范围：2 - 300秒。
        /// </summary>
        [JsonProperty("GapTime")]
        public long? GapTime{ get; set; }

        /// <summary>
        /// 检测健康阈值。 默认为3秒。 可配置范围：2 - 10次。
        /// </summary>
        [JsonProperty("GoodLimit")]
        public long? GoodLimit{ get; set; }

        /// <summary>
        /// 检测不健康阈值。 默认为3秒。 可配置范围：2 - 10次。
        /// </summary>
        [JsonProperty("BadLimit")]
        public long? BadLimit{ get; set; }

        /// <summary>
        /// 目标组下的所有rs的探测包是否开启巨帧。默认开启。仅GWLB类型目标组支持该参数。
        /// </summary>
        [JsonProperty("JumboFrame")]
        public bool? JumboFrame{ get; set; }

        /// <summary>
        /// 健康检查状态码（仅适用于HTTP/HTTPS目标组、TCP目标组的HTTP健康检查方式）。可选值：1~31，默认 31，其中：<url> <li>1 表示探测后返回值 1xx 代表健康。</li><li>2 表示返回 2xx 代表健康。</li><li>4 表示返回 3xx 代表健康。</li><li>8 表示返回 4xx 代表健康。</li><li>16 表示返回 5xx 代表健康。</li></url>若希望多种返回码都可代表健康，则将相应的值相加。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// 健康检查域名， 其中：<ur><li>仅适用于HTTP/HTTPS目标组和TCP目标组的HTTP健康检查方式。</li><li>针对HTTP/HTTPS目标组，当使用HTTP健康检查方式时，该参数为必填项。</li></ur>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// 健康检查路径（仅适用于HTTP/HTTPS转发规则、TCP监听器的HTTP健康检查方式）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// 健康检查方法（仅适用于HTTP/HTTPS转发规则、TCP监听器的HTTP健康检查方式），默认值：HEAD，可选值HEAD或GET。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpCheckMethod")]
        public string HttpCheckMethod{ get; set; }

        /// <summary>
        /// 健康检查的输入格式，健康检查方式取CUSTOM时，必填此字段，可取值：HEX或TEXT，其中：<ur><li>TEXT：文本格式。</li><li>HEX：十六进制格式， SendContext和RecvContext的字符只能在0123456789ABCDEF中选取且长度必须是偶数位。</li><li>仅适用于TCP/UDP目标组。</li></ur>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查协议CheckType的值取CUSTOM时，必填此字段，代表健康检查发送的请求内容，只允许ASCII可见字符，最大长度限制500。（仅适用于TCP/UDP目标组）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// 自定义探测相关参数。健康检查协议CheckType的值取CUSTOM时，必填此字段，代表健康检查返回的结果，只允许ASCII可见字符，最大长度限制500。（仅适用于TCP/UDP目标组）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// HTTP版本, 其中：<ur><li>健康检查协议CheckType的值取HTTP时，必传此字段。</li><li>支持配置选项：HTTP/1.0, HTTP/1.1。</li><li>仅适用于TCP目标组。</li></ur>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// GRPC健康检查状态码（仅适用于后端转发协议为GRPC的目标组）。默认值为 12，可输入值为数值、多个数值、或者范围，例如 20 或 20,25 或 0-99。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtendedCode")]
        public string ExtendedCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "GapTime", this.GapTime);
            this.SetParamSimple(map, prefix + "GoodLimit", this.GoodLimit);
            this.SetParamSimple(map, prefix + "BadLimit", this.BadLimit);
            this.SetParamSimple(map, prefix + "JumboFrame", this.JumboFrame);
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "HttpCheckDomain", this.HttpCheckDomain);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "HttpCheckMethod", this.HttpCheckMethod);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
            this.SetParamSimple(map, prefix + "ExtendedCode", this.ExtendedCode);
        }
    }
}

