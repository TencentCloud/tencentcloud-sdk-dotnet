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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitVideoStylizationJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 风格ID。取值说明：
        /// 2d_anime：2D动漫；
        /// 3d_cartoon：3D卡通；
        /// 3d_china：3D国潮；
        /// pixel_art：像素风。
        /// </summary>
        [JsonProperty("StyleId")]
        public string StyleId{ get; set; }

        /// <summary>
        /// 输入视频URL。视频要求：
        /// - 视频格式：mp4、mov；
        /// - 视频时长：1～60秒；
        /// - 视频分辨率：540P~2056P，即长宽像素数均在540px～2056px范围内；
        /// - 视频大小：不超过200M；
        /// - 视频FPS：15～60fps。
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 风格化强度。取值说明：
        /// low：风格化强度弱；
        /// medium：风格化强度中等；
        /// high：风格化强度强。
        /// 默认值为medium。
        /// </summary>
        [JsonProperty("StyleStrength")]
        public string StyleStrength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StyleId", this.StyleId);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "StyleStrength", this.StyleStrength);
        }
    }
}

