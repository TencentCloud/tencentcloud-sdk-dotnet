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

    public class MPSAIAnalysisTemplate : AbstractModel
    {
        
        /// <summary>
        /// <p>视频内容分析模板名称，长度限制：64 个字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>视频内容分析模板描述信息，长度限制：256 个字符。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>智能分类任务控制参数。</p>
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public MPSAIAnalysisConfigureInfo ClassificationConfigure{ get; set; }

        /// <summary>
        /// <p>智能标签任务控制参数。</p>
        /// </summary>
        [JsonProperty("TagConfigure")]
        public MPSAIAnalysisConfigureInfo TagConfigure{ get; set; }

        /// <summary>
        /// <p>智能封面任务控制参数。</p>
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public MPSAIAnalysisConfigureInfo CoverConfigure{ get; set; }

        /// <summary>
        /// <p>智能按帧标签任务控制参数。</p>
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public MPSAIAnalysisConfigureInfo FrameTagConfigure{ get; set; }

        /// <summary>
        /// <p>智能拆条任务控制参数。</p>
        /// </summary>
        [JsonProperty("SplitConfigure")]
        public MPSAIAnalysisConfigureInfo SplitConfigure{ get; set; }

        /// <summary>
        /// <p>智能集锦任务控制参数。</p>
        /// </summary>
        [JsonProperty("HighlightConfigure")]
        public MPSAIAnalysisConfigureInfo HighlightConfigure{ get; set; }

        /// <summary>
        /// <p>智能片头片尾任务控制参数。</p>
        /// </summary>
        [JsonProperty("OpeningAndEndingConfigure")]
        public MPSAIAnalysisConfigureInfo OpeningAndEndingConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "ClassificationConfigure.", this.ClassificationConfigure);
            this.SetParamObj(map, prefix + "TagConfigure.", this.TagConfigure);
            this.SetParamObj(map, prefix + "CoverConfigure.", this.CoverConfigure);
            this.SetParamObj(map, prefix + "FrameTagConfigure.", this.FrameTagConfigure);
            this.SetParamObj(map, prefix + "SplitConfigure.", this.SplitConfigure);
            this.SetParamObj(map, prefix + "HighlightConfigure.", this.HighlightConfigure);
            this.SetParamObj(map, prefix + "OpeningAndEndingConfigure.", this.OpeningAndEndingConfigure);
        }
    }
}

