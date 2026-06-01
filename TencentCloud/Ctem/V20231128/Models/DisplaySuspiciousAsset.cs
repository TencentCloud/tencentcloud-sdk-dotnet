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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplaySuspiciousAsset : AbstractModel
    {
        
        /// <summary>
        /// <p>主键ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>公共字段</p>
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// <p>Url</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>报文长度</p>
        /// </summary>
        [JsonProperty("ContentLength")]
        public long? ContentLength{ get; set; }

        /// <summary>
        /// <p>报文内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>截图缩略图URL</p>
        /// </summary>
        [JsonProperty("ScreenshotThumbUrl")]
        public string ScreenshotThumbUrl{ get; set; }

        /// <summary>
        /// <p>截图URL</p>
        /// </summary>
        [JsonProperty("ScreenshotUrl")]
        public string ScreenshotUrl{ get; set; }

        /// <summary>
        /// <p>状态码</p>
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// <p>Api</p>
        /// </summary>
        [JsonProperty("Api")]
        public string Api{ get; set; }

        /// <summary>
        /// <p>解析的IP</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>证书信息</p>
        /// </summary>
        [JsonProperty("Ssl")]
        public string Ssl{ get; set; }

        /// <summary>
        /// <p>ssl证书过期时间</p>
        /// </summary>
        [JsonProperty("SslExpiredTime")]
        public string SslExpiredTime{ get; set; }

        /// <summary>
        /// <p>来源类型</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>来源值</p>
        /// </summary>
        [JsonProperty("SourceValue")]
        public string SourceValue{ get; set; }

        /// <summary>
        /// <p>是否信任</p>
        /// </summary>
        [JsonProperty("Trusted")]
        public bool? Trusted{ get; set; }

        /// <summary>
        /// <p>所属者</p>
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// <p>根域名</p>
        /// </summary>
        [JsonProperty("RootDomain")]
        public string RootDomain{ get; set; }

        /// <summary>
        /// <p>聚合视角下该组真实子项总数；非聚合视角为 0</p>
        /// </summary>
        [JsonProperty("AggregationCount")]
        public long? AggregationCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "ContentLength", this.ContentLength);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ScreenshotThumbUrl", this.ScreenshotThumbUrl);
            this.SetParamSimple(map, prefix + "ScreenshotUrl", this.ScreenshotUrl);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Api", this.Api);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Ssl", this.Ssl);
            this.SetParamSimple(map, prefix + "SslExpiredTime", this.SslExpiredTime);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceValue", this.SourceValue);
            this.SetParamSimple(map, prefix + "Trusted", this.Trusted);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "RootDomain", this.RootDomain);
            this.SetParamSimple(map, prefix + "AggregationCount", this.AggregationCount);
        }
    }
}

