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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClassicalListener : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 负载均衡监听器端口
        /// </summary>
        [JsonProperty("ListenerPort")]
        public long? ListenerPort{ get; set; }

        /// <summary>
        /// 监听器后端转发端口
        /// </summary>
        [JsonProperty("InstancePort")]
        public long? InstancePort{ get; set; }

        /// <summary>
        /// 监听器名称
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 监听器协议类型
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 会话保持时间
        /// </summary>
        [JsonProperty("SessionExpire")]
        public long? SessionExpire{ get; set; }

        /// <summary>
        /// 是否开启了健康检查：1（开启）、0（关闭）
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// 响应超时时间
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// 检查间隔
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// 健康阈值
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// 不健康阈值
        /// </summary>
        [JsonProperty("UnhealthNum")]
        public long? UnhealthNum{ get; set; }

        /// <summary>
        /// 传统型公网负载均衡的 HTTP、HTTPS 监听器的请求均衡方法。wrr 表示按权重轮询，ip_hash 表示根据访问的源 IP 进行一致性哈希方式来分发
        /// </summary>
        [JsonProperty("HttpHash")]
        public string HttpHash{ get; set; }

        /// <summary>
        /// 传统型公网负载均衡的 HTTP、HTTPS 监听器的健康检查返回码。具体可参考创建监听器中对该字段的解释
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// 传统型公网负载均衡的 HTTP、HTTPS 监听器的健康检查路径
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// 传统型公网负载均衡的 HTTPS 监听器的认证方式
        /// </summary>
        [JsonProperty("SSLMode")]
        public string SSLMode{ get; set; }

        /// <summary>
        /// 传统型公网负载均衡的 HTTPS 监听器的服务端证书 ID
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 传统型公网负载均衡的 HTTPS 监听器的客户端证书 ID
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 监听器的状态，0 表示创建中，1 表示运行中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "InstancePort", this.InstancePort);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SessionExpire", this.SessionExpire);
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnhealthNum", this.UnhealthNum);
            this.SetParamSimple(map, prefix + "HttpHash", this.HttpHash);
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "SSLMode", this.SSLMode);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

