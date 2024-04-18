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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveStreamMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 监播任务ID。
        /// </summary>
        [JsonProperty("MonitorId")]
        public string MonitorId{ get; set; }

        /// <summary>
        /// 监播任务的名称。长度128字节以内（一个汉字两个字节）。
        /// </summary>
        [JsonProperty("MonitorName")]
        public string MonitorName{ get; set; }

        /// <summary>
        /// 监播任务输出信息。
        /// </summary>
        [JsonProperty("OutputInfo")]
        public LiveStreamMonitorOutputInfo OutputInfo{ get; set; }

        /// <summary>
        /// 待监播的输入流信息。
        /// </summary>
        [JsonProperty("InputList")]
        public LiveStreamMonitorInputInfo[] InputList{ get; set; }

        /// <summary>
        /// 监播事件通知策略。
        /// </summary>
        [JsonProperty("NotifyPolicy")]
        public LiveStreamMonitorNotifyPolicy NotifyPolicy{ get; set; }

        /// <summary>
        /// 智能语音识别语种：
        /// 0 关闭 1 中文 2 英文 3 日文 4 韩文。
        /// </summary>
        [JsonProperty("AsrLanguage")]
        public ulong? AsrLanguage{ get; set; }

        /// <summary>
        /// 智能文字识别语种：
        /// 0 关闭 1 中、英文。
        /// </summary>
        [JsonProperty("OcrLanguage")]
        public ulong? OcrLanguage{ get; set; }

        /// <summary>
        /// 语音识别输入流列表，1代表第一条输入流。
        /// </summary>
        [JsonProperty("AiAsrInputIndexList")]
        public ulong?[] AiAsrInputIndexList{ get; set; }

        /// <summary>
        /// 文字识别输入流列表，1代表第一条输入流。
        /// </summary>
        [JsonProperty("AiOcrInputIndexList")]
        public ulong?[] AiOcrInputIndexList{ get; set; }

        /// <summary>
        /// 是否开启断流检测。
        /// </summary>
        [JsonProperty("CheckStreamBroken")]
        public ulong? CheckStreamBroken{ get; set; }

        /// <summary>
        /// 是否开启低帧率检测。
        /// </summary>
        [JsonProperty("CheckStreamLowFrameRate")]
        public ulong? CheckStreamLowFrameRate{ get; set; }

        /// <summary>
        /// 是否存储监播事件到监播报告，以及是否允许查询监播报告。
        /// </summary>
        [JsonProperty("AllowMonitorReport")]
        public ulong? AllowMonitorReport{ get; set; }

        /// <summary>
        /// 是否开启格式诊断。
        /// </summary>
        [JsonProperty("AiFormatDiagnose")]
        public ulong? AiFormatDiagnose{ get; set; }

        /// <summary>
        /// 是否开启内容质检。
        /// </summary>
        [JsonProperty("AiQualityControl")]
        public ulong? AiQualityControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamSimple(map, prefix + "MonitorName", this.MonitorName);
            this.SetParamObj(map, prefix + "OutputInfo.", this.OutputInfo);
            this.SetParamArrayObj(map, prefix + "InputList.", this.InputList);
            this.SetParamObj(map, prefix + "NotifyPolicy.", this.NotifyPolicy);
            this.SetParamSimple(map, prefix + "AsrLanguage", this.AsrLanguage);
            this.SetParamSimple(map, prefix + "OcrLanguage", this.OcrLanguage);
            this.SetParamArraySimple(map, prefix + "AiAsrInputIndexList.", this.AiAsrInputIndexList);
            this.SetParamArraySimple(map, prefix + "AiOcrInputIndexList.", this.AiOcrInputIndexList);
            this.SetParamSimple(map, prefix + "CheckStreamBroken", this.CheckStreamBroken);
            this.SetParamSimple(map, prefix + "CheckStreamLowFrameRate", this.CheckStreamLowFrameRate);
            this.SetParamSimple(map, prefix + "AllowMonitorReport", this.AllowMonitorReport);
            this.SetParamSimple(map, prefix + "AiFormatDiagnose", this.AiFormatDiagnose);
            this.SetParamSimple(map, prefix + "AiQualityControl", this.AiQualityControl);
        }
    }
}

