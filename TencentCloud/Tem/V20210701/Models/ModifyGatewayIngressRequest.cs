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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGatewayIngressRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境 ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 网关名称
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// 网关类型，如 clb
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 转发配置名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// rules 配置
        /// </summary>
        [JsonProperty("Rules")]
        public IngressRule[] Rules{ get; set; }

        /// <summary>
        /// 是否混合 https，默认 false，可选值 true 代表有 https 协议监听
        /// </summary>
        [JsonProperty("Mixed")]
        public bool? Mixed{ get; set; }

        /// <summary>
        /// tls 配置
        /// </summary>
        [JsonProperty("Tls")]
        public IngressTls[] Tls{ get; set; }

        /// <summary>
        /// 重定向模式，可选值：
        /// - AUTO（自动重定向http到https）
        /// - NONE（不使用重定向）
        /// </summary>
        [JsonProperty("RewriteType")]
        public string RewriteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "Mixed", this.Mixed);
            this.SetParamArrayObj(map, prefix + "Tls.", this.Tls);
            this.SetParamSimple(map, prefix + "RewriteType", this.RewriteType);
        }
    }
}

