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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BrowseEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>当前浏览网页的类型，例如主页、搜索页等</p>
        /// </summary>
        [JsonProperty("PageType")]
        public string PageType{ get; set; }

        /// <summary>
        /// <p>当前浏览的网页URL</p>
        /// </summary>
        [JsonProperty("PageUrl")]
        public string PageUrl{ get; set; }

        /// <summary>
        /// <p>浏览耗时</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>网页内容类型，例如广告、视频、文章等</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>网页内容ID</p>
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// <p>上一个网页的类型，例如主页、搜索页等</p>
        /// </summary>
        [JsonProperty("ReferPageType")]
        public string ReferPageType{ get; set; }

        /// <summary>
        /// <p>上一个网页URL</p>
        /// </summary>
        [JsonProperty("ReferPageUrl")]
        public string ReferPageUrl{ get; set; }

        /// <summary>
        /// <p>游客账号ID</p>
        /// </summary>
        [JsonProperty("GuestId")]
        public string GuestId{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageType", this.PageType);
            this.SetParamSimple(map, prefix + "PageUrl", this.PageUrl);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamSimple(map, prefix + "ReferPageType", this.ReferPageType);
            this.SetParamSimple(map, prefix + "ReferPageUrl", this.ReferPageUrl);
            this.SetParamSimple(map, prefix + "GuestId", this.GuestId);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

