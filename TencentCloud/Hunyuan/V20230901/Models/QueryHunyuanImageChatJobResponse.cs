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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryHunyuanImageChatJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前任务状态码：
        /// 1：等待中、2：运行中、4：处理失败、5：处理完成。
        /// </summary>
        [JsonProperty("JobStatusCode")]
        public string JobStatusCode{ get; set; }

        /// <summary>
        /// 当前任务状态：排队中、处理中、处理失败或者处理完成。
        /// </summary>
        [JsonProperty("JobStatusMsg")]
        public string JobStatusMsg{ get; set; }

        /// <summary>
        /// 任务处理失败错误码。
        /// </summary>
        [JsonProperty("JobErrorCode")]
        public string JobErrorCode{ get; set; }

        /// <summary>
        /// 任务处理失败错误信息。
        /// </summary>
        [JsonProperty("JobErrorMsg")]
        public string JobErrorMsg{ get; set; }

        /// <summary>
        /// 本轮对话的 ChatId，ChatId 用于唯一标识一轮对话。
        /// 一个对话组中，最多支持进行100轮对话。
        /// 每轮对话数据有效期为7天，到期后 ChatId 失效，有效期内的历史对话数据可通过 History 查询，如有长期使用需求请及时保存输入输出数据。
        /// </summary>
        [JsonProperty("ChatId")]
        public string ChatId{ get; set; }

        /// <summary>
        /// 生成图 URL 列表，有效期7天，请及时保存。
        /// </summary>
        [JsonProperty("ResultImage")]
        public string[] ResultImage{ get; set; }

        /// <summary>
        /// 结果 detail 数组，Success 代表成功。
        /// </summary>
        [JsonProperty("ResultDetails")]
        public string[] ResultDetails{ get; set; }

        /// <summary>
        /// 本轮对话前置的历史对话数据（不含生成图）。
        /// </summary>
        [JsonProperty("History")]
        public History[] History{ get; set; }

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
            this.SetParamSimple(map, prefix + "JobStatusCode", this.JobStatusCode);
            this.SetParamSimple(map, prefix + "JobStatusMsg", this.JobStatusMsg);
            this.SetParamSimple(map, prefix + "JobErrorCode", this.JobErrorCode);
            this.SetParamSimple(map, prefix + "JobErrorMsg", this.JobErrorMsg);
            this.SetParamSimple(map, prefix + "ChatId", this.ChatId);
            this.SetParamArraySimple(map, prefix + "ResultImage.", this.ResultImage);
            this.SetParamArraySimple(map, prefix + "ResultDetails.", this.ResultDetails);
            this.SetParamArrayObj(map, prefix + "History.", this.History);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

