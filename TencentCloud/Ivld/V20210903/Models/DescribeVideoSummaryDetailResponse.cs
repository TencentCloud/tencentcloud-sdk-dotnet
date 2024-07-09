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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoSummaryDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务的状态
        /// 1: 等待处理中
        /// 2: 处理中
        /// 3: 处理成功
        /// 4: 处理失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 如果处理失败，返回失败的原因
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// 提取出的视频的 Asr 结果
        /// </summary>
        [JsonProperty("AsrSet")]
        public AsrResult[] AsrSet{ get; set; }

        /// <summary>
        /// 文本摘要结果
        /// </summary>
        [JsonProperty("TextSummary")]
        public string TextSummary{ get; set; }

        /// <summary>
        /// 文本摘要分割结果
        /// </summary>
        [JsonProperty("TextSegSet")]
        public string[] TextSegSet{ get; set; }

        /// <summary>
        /// 镜头分割结果
        /// </summary>
        [JsonProperty("ShotSegSet")]
        public ShotInfo[] ShotSegSet{ get; set; }

        /// <summary>
        /// 数组第 i 个结构 TextSegMatchShotConfidenceSet[i] 表示第 i 个文本摘要分割结果和所有镜头的匹配度。
        /// </summary>
        [JsonProperty("TextSegMatchShotScoreSet")]
        public TextSegMatchShotScore[] TextSegMatchShotScoreSet{ get; set; }

        /// <summary>
        /// TTS 输出音频下载地址列表
        /// </summary>
        [JsonProperty("TTSResultURLSet")]
        public string[] TTSResultURLSet{ get; set; }

        /// <summary>
        /// 合成视频输出下载地址
        /// </summary>
        [JsonProperty("VideoResultURL")]
        public string VideoResultURL{ get; set; }

        /// <summary>
        /// 合成后的视频横竖屏转换后的视频下载地址
        /// </summary>
        [JsonProperty("VideoRotateResultURL")]
        public string VideoRotateResultURL{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamArrayObj(map, prefix + "AsrSet.", this.AsrSet);
            this.SetParamSimple(map, prefix + "TextSummary", this.TextSummary);
            this.SetParamArraySimple(map, prefix + "TextSegSet.", this.TextSegSet);
            this.SetParamArrayObj(map, prefix + "ShotSegSet.", this.ShotSegSet);
            this.SetParamArrayObj(map, prefix + "TextSegMatchShotScoreSet.", this.TextSegMatchShotScoreSet);
            this.SetParamArraySimple(map, prefix + "TTSResultURLSet.", this.TTSResultURLSet);
            this.SetParamSimple(map, prefix + "VideoResultURL", this.VideoResultURL);
            this.SetParamSimple(map, prefix + "VideoRotateResultURL", this.VideoRotateResultURL);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

