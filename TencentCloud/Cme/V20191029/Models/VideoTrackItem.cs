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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTrackItem : AbstractModel
    {
        
        /// <summary>
        /// 视频媒体来源类型，取值有：
        /// <ul>
        /// <li>VOD ：媒体来源于云点播文件 。</li>
        /// <li>CME ：视频来源制作云媒体文件。</li>
        /// <li>EXTERNAL ：视频来源于媒资绑定，如果媒体不是存储在腾讯云点播中或者云创中，都需要使用媒资绑定。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 视频片段的媒体文件来源，取值为：
        /// <ul>
        /// <li>当 SourceType 为 VOD 时，为云点播的媒体文件 FileId ，会默认将该 FileId 导入到项目中；</li>
        /// <li>当 SourceType 为 CME 时，为制作云的媒体 ID，项目归属者必须对该云媒资有访问权限；</li>
        /// <li>当 SourceType 为 EXTERNAL 时，为媒资绑定的 Definition 与 MediaKey 中间用冒号分隔合并后的字符串，格式为 Definition:MediaKey 。</li>
        /// </ul>
        /// 
        /// 注：当 SourceType 为 EXTERNAL 时，目前仅支持外部 URL 的媒体直接导入项目中。当外部 URL Scheme 为 https 时，Definiton 为 1000000，MediaKey 为 URL 去掉 'https://'；当外部 URL Scheme 为 http 时，Definiton 为 1000001，MediaKey 为 URL 去掉 'http://'。
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// 视频片段取自媒体文件的起始时间，单位为秒。默认为0。
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// 视频片段时长，单位为秒。默认取视频媒体文件本身长度，表示截取全部媒体文件。如果源文件是图片，Duration需要大于0。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 视频片段原点距离画布原点的水平位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 XPos 为画布宽度指定百分比的位置，如 10% 表示 XPos 为画布口宽度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示视频片段 XPos 单位为像素，如 100px 表示 XPos 为100像素。</li>
        /// 默认值：0px。
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// 视频片段原点距离画布原点的垂直位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 YPos 为画布高度指定百分比的位置，如 10% 表示 YPos 为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示视频片段 YPos 单位为像素，如 100px 表示 YPos 为100像素。</li>
        /// 默认值：0px。
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 视频原点位置，取值有：
        /// <li>Center：坐标原点为中心位置，如画布中心。</li>
        /// 默认值 ：Center。
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// 视频片段的高度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 Height 为画布高度的百分比大小，如 10% 表示 Height 为画布高度的 10%；</li>
        /// <li>当字符串以 px 结尾，表示视频片段 Height 单位为像素，如 100px 表示 Height 为100像素；</li>
        /// <li>当 Width、Height 均为空，则 Width 和 Height 取视频媒体文件本身的 Width、Height；</li>
        /// <li>当 Width 为空，Height 非空，则 Width 按比例缩放；</li>
        /// <li>当 Width 非空，Height 为空，则 Height 按比例缩放。</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 视频片段的宽度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 Width 为画布宽度的百分比大小，如 10% 表示 Width 为画布宽度的 10%；</li>
        /// <li>当字符串以 px 结尾，表示视频片段 Width 单位为像素，如 100px 表示 Width 为100像素；</li>
        /// <li>当 Width、Height 均为空，则 Width 和 Height 取视频媒体文件本身的 Width、Height；</li>
        /// <li>当 Width 为空，Height 非空，则 Width 按比例缩放；</li>
        /// <li>当 Width 非空，Height 为空，则 Height 按比例缩放。</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "SourceMediaStartTime", this.SourceMediaStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
        }
    }
}

