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

    public class CreateVideoSummaryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 目前只支持 1，表示新闻缩编。
        /// </summary>
        [JsonProperty("SummaryType")]
        public long? SummaryType{ get; set; }

        /// <summary>
        /// 待处理的视频的URL，目前只支持*不带签名的*COS地址，长度最长1KB
        /// </summary>
        [JsonProperty("VideoURL")]
        public string VideoURL{ get; set; }

        /// <summary>
        /// 任务处理完成的回调地址。
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }

        /// <summary>
        /// 如果需要你输出 TTS 或者视频，该字段为转存的cos桶地址且不可为空; 示例：https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${PathPrefix}/  (注意，cos路径需要以/分隔符结尾)。
        /// </summary>
        [JsonProperty("WriteBackCosPath")]
        public string WriteBackCosPath{ get; set; }

        /// <summary>
        /// 是否开启结果视频生成功能，如果开启，需要指定WriteBackCosPath 参数
        /// </summary>
        [JsonProperty("ActiveVideoGenerate")]
        public bool? ActiveVideoGenerate{ get; set; }

        /// <summary>
        /// 生成结果视频的时候，控制生成的结果视频的横转竖参数。如果 ActiveVideoGenerate 为 false, 该参数无效。
        /// </summary>
        [JsonProperty("VideoRotationMode")]
        public VideoRotationMode VideoRotationMode{ get; set; }

        /// <summary>
        /// 语音合成相关的控制参数
        /// </summary>
        [JsonProperty("TTSMode")]
        public TTSMode TTSMode{ get; set; }

        /// <summary>
        /// 是否输出合成好的语音列表。
        /// </summary>
        [JsonProperty("ActiveTTSOutput")]
        public bool? ActiveTTSOutput{ get; set; }

        /// <summary>
        /// 用户指定的精确的 asr 结果列表 
        /// </summary>
        [JsonProperty("ExactAsrSet")]
        public AsrResult[] ExactAsrSet{ get; set; }

        /// <summary>
        /// 用户指定的精确的文本摘要
        /// </summary>
        [JsonProperty("ExactTextSummary")]
        public string ExactTextSummary{ get; set; }

        /// <summary>
        /// 用户指定的精确的文本摘要分割结果
        /// </summary>
        [JsonProperty("ExactTextSegSet")]
        public string[] ExactTextSegSet{ get; set; }

        /// <summary>
        /// 用户指定的精确的镜头分割结果
        /// </summary>
        [JsonProperty("ExactShotSegSet")]
        public ShotInfo[] ExactShotSegSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SummaryType", this.SummaryType);
            this.SetParamSimple(map, prefix + "VideoURL", this.VideoURL);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
            this.SetParamSimple(map, prefix + "WriteBackCosPath", this.WriteBackCosPath);
            this.SetParamSimple(map, prefix + "ActiveVideoGenerate", this.ActiveVideoGenerate);
            this.SetParamObj(map, prefix + "VideoRotationMode.", this.VideoRotationMode);
            this.SetParamObj(map, prefix + "TTSMode.", this.TTSMode);
            this.SetParamSimple(map, prefix + "ActiveTTSOutput", this.ActiveTTSOutput);
            this.SetParamArrayObj(map, prefix + "ExactAsrSet.", this.ExactAsrSet);
            this.SetParamSimple(map, prefix + "ExactTextSummary", this.ExactTextSummary);
            this.SetParamArraySimple(map, prefix + "ExactTextSegSet.", this.ExactTextSegSet);
            this.SetParamArrayObj(map, prefix + "ExactShotSegSet.", this.ExactShotSegSet);
        }
    }
}

