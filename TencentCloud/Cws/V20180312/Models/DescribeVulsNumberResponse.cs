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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulsNumberResponse : AbstractModel
    {
        
        /// <summary>
        /// 受影响的网站总数。
        /// </summary>
        [JsonProperty("ImpactSiteNumber")]
        public ulong? ImpactSiteNumber{ get; set; }

        /// <summary>
        /// 已验证的网站总数。
        /// </summary>
        [JsonProperty("SiteNumber")]
        public ulong? SiteNumber{ get; set; }

        /// <summary>
        /// 高风险漏洞总数。
        /// </summary>
        [JsonProperty("VulsHighNumber")]
        public ulong? VulsHighNumber{ get; set; }

        /// <summary>
        /// 中风险漏洞总数。
        /// </summary>
        [JsonProperty("VulsMiddleNumber")]
        public ulong? VulsMiddleNumber{ get; set; }

        /// <summary>
        /// 低高风险漏洞总数。
        /// </summary>
        [JsonProperty("VulsLowNumber")]
        public ulong? VulsLowNumber{ get; set; }

        /// <summary>
        /// 风险提示总数。
        /// </summary>
        [JsonProperty("VulsNoticeNumber")]
        public ulong? VulsNoticeNumber{ get; set; }

        /// <summary>
        /// 扫描页面总数。
        /// </summary>
        [JsonProperty("PageCount")]
        public ulong? PageCount{ get; set; }

        /// <summary>
        /// 已验证的网站列表。
        /// </summary>
        [JsonProperty("Sites")]
        public MonitorMiniSite[] Sites{ get; set; }

        /// <summary>
        /// 受影响的网站列表。
        /// </summary>
        [JsonProperty("ImpactSites")]
        public MonitorMiniSite[] ImpactSites{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImpactSiteNumber", this.ImpactSiteNumber);
            this.SetParamSimple(map, prefix + "SiteNumber", this.SiteNumber);
            this.SetParamSimple(map, prefix + "VulsHighNumber", this.VulsHighNumber);
            this.SetParamSimple(map, prefix + "VulsMiddleNumber", this.VulsMiddleNumber);
            this.SetParamSimple(map, prefix + "VulsLowNumber", this.VulsLowNumber);
            this.SetParamSimple(map, prefix + "VulsNoticeNumber", this.VulsNoticeNumber);
            this.SetParamSimple(map, prefix + "PageCount", this.PageCount);
            this.SetParamArrayObj(map, prefix + "Sites.", this.Sites);
            this.SetParamArrayObj(map, prefix + "ImpactSites.", this.ImpactSites);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

