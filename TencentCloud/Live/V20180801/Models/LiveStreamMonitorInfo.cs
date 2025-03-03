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

    public class LiveStreamMonitorInfo : AbstractModel
    {
        
        /// <summary>
        /// 监播任务ID。
        /// </summary>
        [JsonProperty("MonitorId")]
        public string MonitorId{ get; set; }

        /// <summary>
        /// 监播任务名称。128字节以内。
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
        /// 监播任务状态。
        /// 0： 代表空闲
        /// 1： 代表监播中。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 上一次的启动时间，unix时间戳。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 上一次的停止时间，unix时间戳。
        /// </summary>
        [JsonProperty("StopTime")]
        public ulong? StopTime{ get; set; }

        /// <summary>
        /// 监播任务创建时间，unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 监播任务更新时间，unix时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 监播事件通知策略。
        /// </summary>
        [JsonProperty("NotifyPolicy")]
        public LiveStreamMonitorNotifyPolicy NotifyPolicy{ get; set; }

        /// <summary>
        /// 输出音频的输入Index列表。
        /// </summary>
        [JsonProperty("AudibleInputIndexList")]
        public ulong?[] AudibleInputIndexList{ get; set; }

        /// <summary>
        /// 开启智能语音识别的输入Index列表
        /// </summary>
        [JsonProperty("AiAsrInputIndexList")]
        public ulong?[] AiAsrInputIndexList{ get; set; }

        /// <summary>
        /// 是否开启断流检测
        /// </summary>
        [JsonProperty("CheckStreamBroken")]
        public ulong? CheckStreamBroken{ get; set; }

        /// <summary>
        /// 是否开启低帧率检测
        /// </summary>
        [JsonProperty("CheckStreamLowFrameRate")]
        public ulong? CheckStreamLowFrameRate{ get; set; }

        /// <summary>
        /// 智能语音识别语种：
        /// 0 关闭 1 中文 2 英文 3日文 4 韩文
        /// </summary>
        [JsonProperty("AsrLanguage")]
        public ulong? AsrLanguage{ get; set; }

        /// <summary>
        /// 智能文字识别语种：
        /// 0 关闭 1 中、英文
        /// </summary>
        [JsonProperty("OcrLanguage")]
        public ulong? OcrLanguage{ get; set; }

        /// <summary>
        /// 开启智能文字识别的输入Index列表
        /// </summary>
        [JsonProperty("AiOcrInputIndexList")]
        public ulong?[] AiOcrInputIndexList{ get; set; }

        /// <summary>
        /// 是否存储监播事件到监播报告，以及是否允许查询监播报告
        /// </summary>
        [JsonProperty("AllowMonitorReport")]
        public ulong? AllowMonitorReport{ get; set; }

        /// <summary>
        /// 是否开启格式诊断
        /// </summary>
        [JsonProperty("AiFormatDiagnose")]
        public ulong? AiFormatDiagnose{ get; set; }

        /// <summary>
        /// 是否开启内容质检。
        /// </summary>
        [JsonProperty("AiQualityControl")]
        public ulong? AiQualityControl{ get; set; }

        /// <summary>
        /// 导播台监播对应的导播台场次id
        /// </summary>
        [JsonProperty("CasterId")]
        public string CasterId{ get; set; }

        /// <summary>
        /// 拉流转推监播对应的拉流转推任务id
        /// </summary>
        [JsonProperty("PullPushTaskId")]
        public string PullPushTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamSimple(map, prefix + "MonitorName", this.MonitorName);
            this.SetParamObj(map, prefix + "OutputInfo.", this.OutputInfo);
            this.SetParamArrayObj(map, prefix + "InputList.", this.InputList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "NotifyPolicy.", this.NotifyPolicy);
            this.SetParamArraySimple(map, prefix + "AudibleInputIndexList.", this.AudibleInputIndexList);
            this.SetParamArraySimple(map, prefix + "AiAsrInputIndexList.", this.AiAsrInputIndexList);
            this.SetParamSimple(map, prefix + "CheckStreamBroken", this.CheckStreamBroken);
            this.SetParamSimple(map, prefix + "CheckStreamLowFrameRate", this.CheckStreamLowFrameRate);
            this.SetParamSimple(map, prefix + "AsrLanguage", this.AsrLanguage);
            this.SetParamSimple(map, prefix + "OcrLanguage", this.OcrLanguage);
            this.SetParamArraySimple(map, prefix + "AiOcrInputIndexList.", this.AiOcrInputIndexList);
            this.SetParamSimple(map, prefix + "AllowMonitorReport", this.AllowMonitorReport);
            this.SetParamSimple(map, prefix + "AiFormatDiagnose", this.AiFormatDiagnose);
            this.SetParamSimple(map, prefix + "AiQualityControl", this.AiQualityControl);
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "PullPushTaskId", this.PullPushTaskId);
        }
    }
}

