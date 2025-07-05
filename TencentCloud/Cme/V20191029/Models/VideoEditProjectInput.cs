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

    public class VideoEditProjectInput : AbstractModel
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
        /// 视频编辑模板媒体 ID ，通过模板媒体导入项目轨道数据时填写。
        /// </summary>
        [JsonProperty("VideoEditTemplateId")]
        public string VideoEditTemplateId{ get; set; }

        /// <summary>
        /// 输入的媒体轨道列表，包括视频、音频，等媒体组成的多个轨道信息。其中：<li>输入的多个轨道在时间轴上和输出媒体文件的时间轴对齐；</li><li>时间轴上相同时间点的各个轨道的素材进行重叠，视频或者图片按轨道顺序进行图像的叠加，轨道顺序高的素材叠加在上面，音频素材进行混音；</li><li>视频、音频，每一种类型的轨道最多支持10个。</li>
        /// 注：当从模板导入项目时（即 VideoEditTemplateId 不为空时），该参数无效。
        /// </summary>
        [JsonProperty("InitTracks")]
        public MediaTrack[] InitTracks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "VideoEditTemplateId", this.VideoEditTemplateId);
            this.SetParamArrayObj(map, prefix + "InitTracks.", this.InitTracks);
        }
    }
}

