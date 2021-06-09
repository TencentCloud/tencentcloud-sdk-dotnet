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

    public class VideoEnhance : AbstractModel
    {
        
        /// <summary>
        /// 去编码毛刺、伪影参数。
        /// </summary>
        [JsonProperty("ArtifactReduction")]
        public ArtifactReduction ArtifactReduction{ get; set; }

        /// <summary>
        /// 去噪声参数。
        /// </summary>
        [JsonProperty("Denoising")]
        public Denoising Denoising{ get; set; }

        /// <summary>
        /// 颜色增强参数。
        /// </summary>
        [JsonProperty("ColorEnhance")]
        public ColorEnhance ColorEnhance{ get; set; }

        /// <summary>
        /// 细节增强参数。
        /// </summary>
        [JsonProperty("Sharp")]
        public Sharp Sharp{ get; set; }

        /// <summary>
        /// 超分参数，可选项：2，目前仅支持2倍超分。
        /// 注意：此参数已经弃用，超分可以使用VideoSuperResolution参数
        /// </summary>
        [JsonProperty("WdSuperResolution")]
        public long? WdSuperResolution{ get; set; }

        /// <summary>
        /// 人脸保护信息。
        /// </summary>
        [JsonProperty("FaceProtect")]
        public FaceProtect FaceProtect{ get; set; }

        /// <summary>
        /// 插帧，取值范围：[0, 60]，单位：Hz。
        /// 注意：当取值为 0，表示帧率和原始视频保持一致。
        /// </summary>
        [JsonProperty("WdFps")]
        public long? WdFps{ get; set; }

        /// <summary>
        /// 去划痕参数
        /// </summary>
        [JsonProperty("ScratchRepair")]
        public ScratchRepair ScratchRepair{ get; set; }

        /// <summary>
        /// 低光照增强参数
        /// </summary>
        [JsonProperty("LowLightEnhance")]
        public LowLightEnhance LowLightEnhance{ get; set; }

        /// <summary>
        /// 视频超分参数
        /// </summary>
        [JsonProperty("VideoSuperResolution")]
        public VideoSuperResolution VideoSuperResolution{ get; set; }

        /// <summary>
        /// 视频画质修复参数
        /// </summary>
        [JsonProperty("VideoRepair")]
        public VideoRepair VideoRepair{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ArtifactReduction.", this.ArtifactReduction);
            this.SetParamObj(map, prefix + "Denoising.", this.Denoising);
            this.SetParamObj(map, prefix + "ColorEnhance.", this.ColorEnhance);
            this.SetParamObj(map, prefix + "Sharp.", this.Sharp);
            this.SetParamSimple(map, prefix + "WdSuperResolution", this.WdSuperResolution);
            this.SetParamObj(map, prefix + "FaceProtect.", this.FaceProtect);
            this.SetParamSimple(map, prefix + "WdFps", this.WdFps);
            this.SetParamObj(map, prefix + "ScratchRepair.", this.ScratchRepair);
            this.SetParamObj(map, prefix + "LowLightEnhance.", this.LowLightEnhance);
            this.SetParamObj(map, prefix + "VideoSuperResolution.", this.VideoSuperResolution);
            this.SetParamObj(map, prefix + "VideoRepair.", this.VideoRepair);
        }
    }
}

