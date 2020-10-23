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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditingInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频标签识别任务参数，不填则不开启。
        /// </summary>
        [JsonProperty("TagEditingInfo")]
        public TagEditingInfo TagEditingInfo{ get; set; }

        /// <summary>
        /// 视频分类识别任务参数，不填则不开启。
        /// </summary>
        [JsonProperty("ClassificationEditingInfo")]
        public ClassificationEditingInfo ClassificationEditingInfo{ get; set; }

        /// <summary>
        /// 智能拆条任务参数，不填则不开启。
        /// </summary>
        [JsonProperty("StripEditingInfo")]
        public StripEditingInfo StripEditingInfo{ get; set; }

        /// <summary>
        /// 智能集锦任务参数，不填则不开启。
        /// </summary>
        [JsonProperty("HighlightsEditingInfo")]
        public HighlightsEditingInfo HighlightsEditingInfo{ get; set; }

        /// <summary>
        /// 智能封面任务参数，不填则不开启。
        /// </summary>
        [JsonProperty("CoverEditingInfo")]
        public CoverEditingInfo CoverEditingInfo{ get; set; }

        /// <summary>
        /// 片头片尾识别任务参数，不填则不开启。
        /// </summary>
        [JsonProperty("OpeningEndingEditingInfo")]
        public OpeningEndingEditingInfo OpeningEndingEditingInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TagEditingInfo.", this.TagEditingInfo);
            this.SetParamObj(map, prefix + "ClassificationEditingInfo.", this.ClassificationEditingInfo);
            this.SetParamObj(map, prefix + "StripEditingInfo.", this.StripEditingInfo);
            this.SetParamObj(map, prefix + "HighlightsEditingInfo.", this.HighlightsEditingInfo);
            this.SetParamObj(map, prefix + "CoverEditingInfo.", this.CoverEditingInfo);
            this.SetParamObj(map, prefix + "OpeningEndingEditingInfo.", this.OpeningEndingEditingInfo);
        }
    }
}

