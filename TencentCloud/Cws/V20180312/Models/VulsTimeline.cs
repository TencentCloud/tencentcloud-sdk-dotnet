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

    public class VulsTimeline : AbstractModel
    {
        
        /// <summary>
        /// ID。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 云用户appid。
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 日期。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 扫描页面总数量。
        /// </summary>
        [JsonProperty("PageCount")]
        public ulong? PageCount{ get; set; }

        /// <summary>
        /// 已验证网站总数量。
        /// </summary>
        [JsonProperty("SiteNum")]
        public ulong? SiteNum{ get; set; }

        /// <summary>
        /// 受影响的网站总数量。
        /// </summary>
        [JsonProperty("ImpactSiteNum")]
        public ulong? ImpactSiteNum{ get; set; }

        /// <summary>
        /// 高危漏洞总数量。
        /// </summary>
        [JsonProperty("VulsHighNum")]
        public ulong? VulsHighNum{ get; set; }

        /// <summary>
        /// 中危漏洞总数量。
        /// </summary>
        [JsonProperty("VulsMiddleNum")]
        public ulong? VulsMiddleNum{ get; set; }

        /// <summary>
        /// 低危漏洞总数量。
        /// </summary>
        [JsonProperty("VulsLowNum")]
        public ulong? VulsLowNum{ get; set; }

        /// <summary>
        /// 风险提示总数量
        /// </summary>
        [JsonProperty("VulsNoticeNum")]
        public ulong? VulsNoticeNum{ get; set; }

        /// <summary>
        /// 记录添加时间。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 记录最近修改时间。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "PageCount", this.PageCount);
            this.SetParamSimple(map, prefix + "SiteNum", this.SiteNum);
            this.SetParamSimple(map, prefix + "ImpactSiteNum", this.ImpactSiteNum);
            this.SetParamSimple(map, prefix + "VulsHighNum", this.VulsHighNum);
            this.SetParamSimple(map, prefix + "VulsMiddleNum", this.VulsMiddleNum);
            this.SetParamSimple(map, prefix + "VulsLowNum", this.VulsLowNum);
            this.SetParamSimple(map, prefix + "VulsNoticeNum", this.VulsNoticeNum);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

