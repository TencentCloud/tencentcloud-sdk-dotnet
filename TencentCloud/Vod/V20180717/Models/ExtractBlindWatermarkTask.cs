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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtractBlindWatermarkTask : AbstractModel
    {
        
        /// <summary>
        /// 媒体处理任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务流状态，取值：
        /// <li>WAITING：等待中；</li>
        /// <li>PROCESSING：处理中；</li>
        /// <li>FINISH：已完成。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 错误码，0 表示成功，其他值表示失败。
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 提取数字水印的文件输入信息。
        /// </summary>
        [JsonProperty("InputInfo")]
        public ExtractBlindWatermarkInputInfo InputInfo{ get; set; }

        /// <summary>
        /// 数字水印类型，可选值：<li>blind-basic：基础版权数字水印；</li> <li>blind-ab：ab版权数字水印；</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 标记是否检测到水印，如果该参数为true， Result字段将返回水印提取结果，如果该参数为false，Result字段不会返回。
        /// </summary>
        [JsonProperty("IsDetected")]
        public bool? IsDetected{ get; set; }

        /// <summary>
        /// 提取出的数字水印内容，当没有检测到水印时该字段不会返回。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 溯源水印提取出的播放者的 ID，以十六进制表示，共6位。
        /// </summary>
        [JsonProperty("ResultUV")]
        public string ResultUV{ get; set; }

        /// <summary>
        /// 提取数字水印配置。
        /// </summary>
        [JsonProperty("ExtractBlindWatermarkConfig")]
        public ExtractBlindWatermarkTaskConfig ExtractBlindWatermarkConfig{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长 1000 个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 用于去重的识别码，如果七天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsDetected", this.IsDetected);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "ResultUV", this.ResultUV);
            this.SetParamObj(map, prefix + "ExtractBlindWatermarkConfig.", this.ExtractBlindWatermarkConfig);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

