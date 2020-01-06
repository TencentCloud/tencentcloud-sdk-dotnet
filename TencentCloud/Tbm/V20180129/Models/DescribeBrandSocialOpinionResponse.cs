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

namespace TencentCloud.Tbm.V20180129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBrandSocialOpinionResponse : AbstractModel
    {
        
        /// <summary>
        /// 文章总数
        /// </summary>
        [JsonProperty("ArticleCount")]
        public ulong? ArticleCount{ get; set; }

        /// <summary>
        /// 来源统计总数
        /// </summary>
        [JsonProperty("FromCount")]
        public ulong? FromCount{ get; set; }

        /// <summary>
        /// 疑似负面报道总数
        /// </summary>
        [JsonProperty("AdverseCount")]
        public ulong? AdverseCount{ get; set; }

        /// <summary>
        /// 文章列表详情
        /// </summary>
        [JsonProperty("ArticleSet")]
        public BrandReportArticle[] ArticleSet{ get; set; }

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
            this.SetParamSimple(map, prefix + "ArticleCount", this.ArticleCount);
            this.SetParamSimple(map, prefix + "FromCount", this.FromCount);
            this.SetParamSimple(map, prefix + "AdverseCount", this.AdverseCount);
            this.SetParamArrayObj(map, prefix + "ArticleSet.", this.ArticleSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

