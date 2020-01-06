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

    public class BrandReportArticle : AbstractModel
    {
        
        /// <summary>
        /// 文章标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 文章url地址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 文章来源
        /// </summary>
        [JsonProperty("FromSite")]
        public string FromSite{ get; set; }

        /// <summary>
        /// 文章发表日期
        /// </summary>
        [JsonProperty("PubTime")]
        public string PubTime{ get; set; }

        /// <summary>
        /// 文章标识
        /// </summary>
        [JsonProperty("Flag")]
        public ulong? Flag{ get; set; }

        /// <summary>
        /// 文章热度值
        /// </summary>
        [JsonProperty("Hot")]
        public ulong? Hot{ get; set; }

        /// <summary>
        /// 文章来源等级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 文章摘要
        /// </summary>
        [JsonProperty("Abstract")]
        public string Abstract{ get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        [JsonProperty("ArticleId")]
        public string ArticleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FromSite", this.FromSite);
            this.SetParamSimple(map, prefix + "PubTime", this.PubTime);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Hot", this.Hot);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Abstract", this.Abstract);
            this.SetParamSimple(map, prefix + "ArticleId", this.ArticleId);
        }
    }
}

