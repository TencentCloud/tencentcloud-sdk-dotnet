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

    public class MonitorsDetail : AbstractModel
    {
        
        /// <summary>
        /// 监控任务基础信息。
        /// </summary>
        [JsonProperty("Basic")]
        public Monitor Basic{ get; set; }

        /// <summary>
        /// 监控任务包含的站点列表。
        /// </summary>
        [JsonProperty("Sites")]
        public MonitorMiniSite[] Sites{ get; set; }

        /// <summary>
        /// 监控任务包含的站点列表数量。
        /// </summary>
        [JsonProperty("SiteNumber")]
        public ulong? SiteNumber{ get; set; }

        /// <summary>
        /// 监控任务包含的受漏洞威胁的站点列表。
        /// </summary>
        [JsonProperty("ImpactSites")]
        public MonitorMiniSite[] ImpactSites{ get; set; }

        /// <summary>
        /// 监控任务包含的受漏洞威胁的站点列表数量。
        /// </summary>
        [JsonProperty("ImpactSiteNumber")]
        public ulong? ImpactSiteNumber{ get; set; }

        /// <summary>
        /// 高风险漏洞数量。
        /// </summary>
        [JsonProperty("VulsHighNumber")]
        public ulong? VulsHighNumber{ get; set; }

        /// <summary>
        /// 中风险漏洞数量。
        /// </summary>
        [JsonProperty("VulsMiddleNumber")]
        public ulong? VulsMiddleNumber{ get; set; }

        /// <summary>
        /// 低风险漏洞数量。
        /// </summary>
        [JsonProperty("VulsLowNumber")]
        public ulong? VulsLowNumber{ get; set; }

        /// <summary>
        /// 提示数量。
        /// </summary>
        [JsonProperty("VulsNoticeNumber")]
        public ulong? VulsNoticeNumber{ get; set; }

        /// <summary>
        /// 监控任务包含的站点列表的平均扫描进度。
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 扫描页面总数。
        /// </summary>
        [JsonProperty("PageCount")]
        public ulong? PageCount{ get; set; }

        /// <summary>
        /// 内容检测数量。
        /// </summary>
        [JsonProperty("ContentNumber")]
        public ulong? ContentNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Basic.", this.Basic);
            this.SetParamArrayObj(map, prefix + "Sites.", this.Sites);
            this.SetParamSimple(map, prefix + "SiteNumber", this.SiteNumber);
            this.SetParamArrayObj(map, prefix + "ImpactSites.", this.ImpactSites);
            this.SetParamSimple(map, prefix + "ImpactSiteNumber", this.ImpactSiteNumber);
            this.SetParamSimple(map, prefix + "VulsHighNumber", this.VulsHighNumber);
            this.SetParamSimple(map, prefix + "VulsMiddleNumber", this.VulsMiddleNumber);
            this.SetParamSimple(map, prefix + "VulsLowNumber", this.VulsLowNumber);
            this.SetParamSimple(map, prefix + "VulsNoticeNumber", this.VulsNoticeNumber);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "PageCount", this.PageCount);
            this.SetParamSimple(map, prefix + "ContentNumber", this.ContentNumber);
        }
    }
}

