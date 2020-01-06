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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIAnalysisTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 视频内容分析模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 视频内容分析模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 智能分类任务控制参数。
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public ClassificationConfigureInfo ClassificationConfigure{ get; set; }

        /// <summary>
        /// 智能标签任务控制参数。
        /// </summary>
        [JsonProperty("TagConfigure")]
        public TagConfigureInfo TagConfigure{ get; set; }

        /// <summary>
        /// 智能封面任务控制参数。
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public CoverConfigureInfo CoverConfigure{ get; set; }

        /// <summary>
        /// 智能按帧标签任务控制参数。
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public FrameTagConfigureInfo FrameTagConfigure{ get; set; }

        /// <summary>
        /// 智能精彩集锦任务控制参数。
        /// </summary>
        [JsonProperty("HighlightConfigure")]
        public HighlightsConfigureInfo HighlightConfigure{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "ClassificationConfigure.", this.ClassificationConfigure);
            this.SetParamObj(map, prefix + "TagConfigure.", this.TagConfigure);
            this.SetParamObj(map, prefix + "CoverConfigure.", this.CoverConfigure);
            this.SetParamObj(map, prefix + "FrameTagConfigure.", this.FrameTagConfigure);
            this.SetParamObj(map, prefix + "HighlightConfigure.", this.HighlightConfigure);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

