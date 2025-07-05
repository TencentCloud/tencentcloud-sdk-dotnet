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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskStatus : AbstractModel
    {
        
        /// <summary>
        /// 任务标识。注意：TaskId数据类型为uint64。
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 任务状态码，0：任务等待，1：任务执行中，2：任务成功，3：任务失败。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务状态，waiting：任务等待，doing：任务执行中，success：任务成功，failed：任务失败。
        /// </summary>
        [JsonProperty("StatusStr")]
        public string StatusStr{ get; set; }

        /// <summary>
        /// 识别结果。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 失败原因说明。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 识别结果详情，包含每个句子中的词时间偏移，一般用于生成字幕的场景。(录音识别请求中ResTextFormat=1时该字段不为空)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultDetail")]
        public SentenceDetail[] ResultDetail{ get; set; }

        /// <summary>
        /// 音频时长(秒)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioDuration")]
        public float? AudioDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusStr", this.StatusStr);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamArrayObj(map, prefix + "ResultDetail.", this.ResultDetail);
            this.SetParamSimple(map, prefix + "AudioDuration", this.AudioDuration);
        }
    }
}

