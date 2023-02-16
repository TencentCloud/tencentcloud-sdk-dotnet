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

    public class RebuildMediaTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 起始偏移时间，单位：秒，不填表示从视频开始截取。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 结束偏移时间，单位：秒，不填表示截取到视频末尾。
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 画质修复控制参数。
        /// </summary>
        [JsonProperty("RepairInfo")]
        public RepairInfo RepairInfo{ get; set; }

        /// <summary>
        /// 智能插帧控制参数。
        /// </summary>
        [JsonProperty("VideoFrameInterpolationInfo")]
        public VideoFrameInterpolationInfo VideoFrameInterpolationInfo{ get; set; }

        /// <summary>
        /// 画面超分控制参数。
        /// </summary>
        [JsonProperty("SuperResolutionInfo")]
        public SuperResolutionInfo SuperResolutionInfo{ get; set; }

        /// <summary>
        /// 高动态范围类型控制参数。
        /// </summary>
        [JsonProperty("HDRInfo")]
        public HDRInfo HDRInfo{ get; set; }

        /// <summary>
        /// 视频降噪控制参数。
        /// </summary>
        [JsonProperty("VideoDenoiseInfo")]
        public VideoDenoiseInfo VideoDenoiseInfo{ get; set; }

        /// <summary>
        /// 音频降噪控制参数。
        /// </summary>
        [JsonProperty("AudioDenoiseInfo")]
        public AudioDenoiseInfo AudioDenoiseInfo{ get; set; }

        /// <summary>
        /// 色彩增强控制参数。
        /// </summary>
        [JsonProperty("ColorInfo")]
        public ColorEnhanceInfo ColorInfo{ get; set; }

        /// <summary>
        /// 细节增强控制参数。
        /// </summary>
        [JsonProperty("SharpInfo")]
        public SharpEnhanceInfo SharpInfo{ get; set; }

        /// <summary>
        /// 人脸增强控制参数。
        /// </summary>
        [JsonProperty("FaceInfo")]
        public FaceEnhanceInfo FaceInfo{ get; set; }

        /// <summary>
        /// 低光照控制参数。
        /// </summary>
        [JsonProperty("LowLightInfo")]
        public LowLightEnhanceInfo LowLightInfo{ get; set; }

        /// <summary>
        /// 去划痕控制参数。
        /// </summary>
        [JsonProperty("ScratchRepairInfo")]
        public ScratchRepairInfo ScratchRepairInfo{ get; set; }

        /// <summary>
        /// 去伪影（毛刺）控制参数。
        /// </summary>
        [JsonProperty("ArtifactRepairInfo")]
        public ArtifactRepairInfo ArtifactRepairInfo{ get; set; }

        /// <summary>
        /// 音画质重生输出目标参数。
        /// </summary>
        [JsonProperty("TargetInfo")]
        public RebuildMediaTargetInfo TargetInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamObj(map, prefix + "RepairInfo.", this.RepairInfo);
            this.SetParamObj(map, prefix + "VideoFrameInterpolationInfo.", this.VideoFrameInterpolationInfo);
            this.SetParamObj(map, prefix + "SuperResolutionInfo.", this.SuperResolutionInfo);
            this.SetParamObj(map, prefix + "HDRInfo.", this.HDRInfo);
            this.SetParamObj(map, prefix + "VideoDenoiseInfo.", this.VideoDenoiseInfo);
            this.SetParamObj(map, prefix + "AudioDenoiseInfo.", this.AudioDenoiseInfo);
            this.SetParamObj(map, prefix + "ColorInfo.", this.ColorInfo);
            this.SetParamObj(map, prefix + "SharpInfo.", this.SharpInfo);
            this.SetParamObj(map, prefix + "FaceInfo.", this.FaceInfo);
            this.SetParamObj(map, prefix + "LowLightInfo.", this.LowLightInfo);
            this.SetParamObj(map, prefix + "ScratchRepairInfo.", this.ScratchRepairInfo);
            this.SetParamObj(map, prefix + "ArtifactRepairInfo.", this.ArtifactRepairInfo);
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
        }
    }
}

