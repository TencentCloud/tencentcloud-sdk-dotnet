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

    public class RuleInput : AbstractModel
    {
        
        /// <summary>
        /// 转发规则的域名。长度限制为：1~80。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 转发规则的路径。长度限制为：1~200。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 会话保持时间。设置为0表示关闭会话保持，开启会话保持可取值30~3600，单位：秒。
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// 健康检查信息
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// 证书信息
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// 规则的请求转发方式，可选值：WRR、LEAST_CONN、IP_HASH
        /// 分别表示按权重轮询、最小连接数、按IP哈希， 默认为 WRR。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 负载均衡与后端服务之间的转发协议，目前支持 HTTP/HTTPS/TRPC
        /// </summary>
        [JsonProperty("ForwardType")]
        public string ForwardType{ get; set; }

        /// <summary>
        /// 是否将该域名设为默认域名，注意，一个监听器下只能设置一个默认域名。
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }

        /// <summary>
        /// 是否开启Http2，注意，只有HTTPS域名才能开启Http2。
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// 后端目标类型，NODE表示绑定普通节点，TARGETGROUP表示绑定目标组
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// TRPC被调服务器路由，ForwardType为TRPC时必填
        /// </summary>
        [JsonProperty("TrpcCallee")]
        public string TrpcCallee{ get; set; }

        /// <summary>
        /// TRPC调用服务接口，ForwardType为TRPC时必填
        /// </summary>
        [JsonProperty("TrpcFunc")]
        public string TrpcFunc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "ForwardType", this.ForwardType);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "TrpcCallee", this.TrpcCallee);
            this.SetParamSimple(map, prefix + "TrpcFunc", this.TrpcFunc);
        }
    }
}

