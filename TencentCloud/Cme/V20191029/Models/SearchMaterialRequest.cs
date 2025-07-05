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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchMaterialRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 指定搜索空间，数组长度不得超过5。
        /// </summary>
        [JsonProperty("SearchScopes")]
        public SearchScope[] SearchScopes{ get; set; }

        /// <summary>
        /// 媒体类型，可取值有：
        /// <li>AUDIO：音频；</li>
        /// <li>VIDEO：视频 ；</li>
        /// <li>IMAGE：图片；</li>
        /// <li>VIDEO_EDIT_TEMPLATE：剪辑模板。</li>
        /// </summary>
        [JsonProperty("MaterialTypes")]
        public string[] MaterialTypes{ get; set; }

        /// <summary>
        /// 搜索文本，模糊匹配媒体名称或描述信息，匹配项越多，匹配度越高，排序越优先。长度限制：15个字符。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 按画质检索，取值为：LD/SD/HD/FHD/2K/4K。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 按媒体时长检索，单位s。
        /// </summary>
        [JsonProperty("DurationRange")]
        public IntegerRange DurationRange{ get; set; }

        /// <summary>
        /// 按照媒体创建时间检索。
        /// </summary>
        [JsonProperty("CreateTimeRange")]
        public TimeRange CreateTimeRange{ get; set; }

        /// <summary>
        /// 按标签检索，填入检索的标签名。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 排序方式。Sort.Field 可选值：CreateTime。指定 Text 搜索时，将根据匹配度排序，该字段无效。
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// 偏移量。默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：50。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以搜索任意媒体的信息。如果指定操作者，则操作者必须对媒体有读权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamArrayObj(map, prefix + "SearchScopes.", this.SearchScopes);
            this.SetParamArraySimple(map, prefix + "MaterialTypes.", this.MaterialTypes);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamObj(map, prefix + "DurationRange.", this.DurationRange);
            this.SetParamObj(map, prefix + "CreateTimeRange.", this.CreateTimeRange);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

