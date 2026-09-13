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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAudioModerationSyncResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>返回传入的DataId</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>审核返回的任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>文件名</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>1：语音。 2：图片。</p>
        /// </summary>
        [JsonProperty("MediaType")]
        public long? MediaType{ get; set; }

        /// <summary>
        /// <p>0：建议通过。 1 ：建议人工重新内容识别。 2：建议屏蔽。</p>
        /// </summary>
        [JsonProperty("Suggest")]
        public long? Suggest{ get; set; }

        /// <summary>
        /// <p>置信度分数，取值范围：0（置信度最低）-100（置信度最高 ），越高代表越有可能属于当前返回的标签。 实例值：100</p>
        /// </summary>
        [JsonProperty("Rate")]
        public long? Rate{ get; set; }

        /// <summary>
        /// <p>Normal：正常文本  Ad:广告 Porn：色情 Abuse：谩骂 Illegal: 违禁 Polity: 涉政 Terror: 暴恐 Sexy: 性感 Moan: 呻吟/娇喘 QRCode: 二维码 Custom: 自定义</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>子标签</p>
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// <p>音频链接地址</p>
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }

        /// <summary>
        /// <p>审核识别音频文本</p>
        /// </summary>
        [JsonProperty("AudioText")]
        public string AudioText{ get; set; }

        /// <summary>
        /// <p>音频时长，单位 ms</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>审核明细</p>
        /// </summary>
        [JsonProperty("CheckDetail")]
        public ModerationCheckDetail[] CheckDetail{ get; set; }

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
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "Suggest", this.Suggest);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
            this.SetParamSimple(map, prefix + "AudioText", this.AudioText);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArrayObj(map, prefix + "CheckDetail.", this.CheckDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

