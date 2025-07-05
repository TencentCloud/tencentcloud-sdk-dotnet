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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTemplateListRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页Limit, 最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页Offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 演练名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 标签键
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// 状态，1---使用中， 2---停用
        /// </summary>
        [JsonProperty("IsUsed")]
        public long? IsUsed{ get; set; }

        /// <summary>
        /// 标签对
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }

        /// <summary>
        /// 经验来源 0-自建 1-专家推荐
        /// </summary>
        [JsonProperty("TemplateSource")]
        public long? TemplateSource{ get; set; }

        /// <summary>
        /// 经验ID
        /// </summary>
        [JsonProperty("TemplateIdList")]
        public long?[] TemplateIdList{ get; set; }

        /// <summary>
        /// 过滤参数
        /// </summary>
        [JsonProperty("Filters")]
        public ActionFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "IsUsed", this.IsUsed);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TemplateSource", this.TemplateSource);
            this.SetParamArraySimple(map, prefix + "TemplateIdList.", this.TemplateIdList);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

