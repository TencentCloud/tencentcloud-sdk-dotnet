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

    public class DescribeApplicationProxyDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 当ProxyType=hostname时，表示域名或子域名；
        /// 当ProxyType=instance时，表示代理名称。
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 调度模式，取值有：
        /// <li>ip：表示Anycast IP调度；</li>
        /// <li>domain：表示CNAME调度。</li>
        /// </summary>
        [JsonProperty("PlatType")]
        public string PlatType{ get; set; }

        /// <summary>
        /// 是否开启安全，取值有：
        /// <li>0：关闭安全；</li>
        /// <li>1：开启安全。</li>
        /// </summary>
        [JsonProperty("SecurityType")]
        public long? SecurityType{ get; set; }

        /// <summary>
        /// 是否开启加速，取值有：
        /// <li>0：关闭加速；</li>
        /// <li>1：开启加速。</li>
        /// </summary>
        [JsonProperty("AccelerateType")]
        public long? AccelerateType{ get; set; }

        /// <summary>
        /// 字段已经废弃。
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// 字段已经废弃。
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }

        /// <summary>
        /// 规则列表。
        /// </summary>
        [JsonProperty("Rule")]
        public ApplicationProxyRule[] Rule{ get; set; }

        /// <summary>
        /// 状态，取值有：
        /// <li>online：启用；</li>
        /// <li>offline：停用；</li>
        /// <li>progress：部署中。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 调度信息。
        /// </summary>
        [JsonProperty("ScheduleValue")]
        public string[] ScheduleValue{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点名称。
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 会话保持时间。
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// 四层代理模式，取值有：
        /// <li>hostname：表示子域名模式；</li>
        /// <li>instance：表示实例模式。</li>
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }

        /// <summary>
        /// 当ProxyType=hostname时：
        /// 表示代理加速唯一标识。
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// IPv6访问配置。
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6Access Ipv6{ get; set; }

        /// <summary>
        /// 加速区域，取值有：
        /// <li>mainland：中国大陆境内;</li>
        /// <li>overseas：全球（不含中国大陆）。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "PlatType", this.PlatType);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "AccelerateType", this.AccelerateType);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamArrayObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "ScheduleValue.", this.ScheduleValue);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

