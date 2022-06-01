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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 四层代理名称
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 调度模式：
        /// ip表示Anycast IP
        /// domain表示CNAME
        /// </summary>
        [JsonProperty("PlatType")]
        public string PlatType{ get; set; }

        /// <summary>
        /// 0关闭安全，1开启安全
        /// </summary>
        [JsonProperty("SecurityType")]
        public long? SecurityType{ get; set; }

        /// <summary>
        /// 0关闭加速，1开启加速
        /// </summary>
        [JsonProperty("AccelerateType")]
        public long? AccelerateType{ get; set; }

        /// <summary>
        /// 字段已经移至Rule.ForwardClientIp
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// 字段已经移至Rule.SessionPersist
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }

        /// <summary>
        /// 规则详细信息
        /// </summary>
        [JsonProperty("Rule")]
        public ApplicationProxyRule[] Rule{ get; set; }

        /// <summary>
        /// 会话保持时间，取值范围：30-3600，单位：秒
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// 服务类型
        /// hostname：子域名
        /// instance：实例
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "PlatType", this.PlatType);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "AccelerateType", this.AccelerateType);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamArrayObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
        }
    }
}

