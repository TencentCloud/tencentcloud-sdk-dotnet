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

    public class VideoSegmentationProjectInput : AbstractModel
    {
        
        /// <summary>
        /// 画布宽高比，取值有：
        /// <li>16:9；</li>
        /// <li>9:16；</li>
        /// <li>2:1。</li>
        /// 默认值 16:9 。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 视频拆条处理模型，不填则默认为手工分割视频。取值 ：
        /// <li>AI.GameHighlights.PUBG：和平精英集锦 ;</li>
        /// <li>AI.GameHighlights.Honor OfKings：王者荣耀集锦 ;</li>
        /// <li>AI.SportHighlights.Football：足球集锦 </li>
        /// <li>AI.SportHighlights.Basketball：篮球集锦 ；</li>
        /// <li>AI.PersonSegmentation：人物集锦  ;</li>
        /// <li>AI.NewsSegmentation：新闻拆条。</li>
        /// </summary>
        [JsonProperty("ProcessModel")]
        public string ProcessModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "ProcessModel", this.ProcessModel);
        }
    }
}

