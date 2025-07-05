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

namespace TencentCloud.Tts.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTtsTaskStatusRespData : AbstractModel
    {
        
        /// <summary>
        /// 任务标识。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

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
        /// 合成音频COS地址（链接有效期1天）。
        /// </summary>
        [JsonProperty("ResultUrl")]
        public string ResultUrl{ get; set; }

        /// <summary>
        /// 时间戳信息，若未开启时间戳，则返回空数组。
        /// </summary>
        [JsonProperty("Subtitles")]
        public Subtitle[] Subtitles{ get; set; }

        /// <summary>
        /// 失败原因说明。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusStr", this.StatusStr);
            this.SetParamSimple(map, prefix + "ResultUrl", this.ResultUrl);
            this.SetParamArrayObj(map, prefix + "Subtitles.", this.Subtitles);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
        }
    }
}

