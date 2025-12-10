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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchMediaBySemanticsRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 需要进行搜索的内容
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 返回的记录条数，默认值：20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 文件类型。匹配集合中的任意元素： <li>Video: 视频文件</li> <li>Audio: 音频文件</li> <li>Image: 图片文件</li>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }

        /// <summary>
        /// 标签集合，匹配集合中任意元素。 <li>单个标签长度限制：32个字符。</li> <li>数组长度限制：16。</li>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 搜索的任务类型，可选值有： 
        /// - AiAnalysis.DescriptionTask 
        /// - SmartSubtitle.AsrFullTextTask
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
        }
    }
}

