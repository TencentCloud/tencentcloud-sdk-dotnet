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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgRecordResult : AbstractModel
    {
        
        /// <summary>
        /// 表示该条消息的调用结果：0=CALL_RESULT_UNKNOWN（全部/未知）, 1=CALL_RESULT_SUCCESS（成功）, 2=CALL_RESULT_FAILED（失败）；fail_reason（string）为调用失败时的失败原因描述。
        /// </summary>
        [JsonProperty("CallResult")]
        public long? CallResult{ get; set; }

        /// <summary>
        /// 自定义变量，json字符串
        /// </summary>
        [JsonProperty("CustomerVariable")]
        public string CustomerVariable{ get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 首token耗时
        /// </summary>
        [JsonProperty("FirstTokenLatency")]
        public ulong? FirstTokenLatency{ get; set; }

        /// <summary>
        /// 输入token数
        /// </summary>
        [JsonProperty("InputToken")]
        public ulong? InputToken{ get; set; }

        /// <summary>
        /// 输出token数
        /// </summary>
        [JsonProperty("OutputToken")]
        public ulong? OutputToken{ get; set; }

        /// <summary>
        /// 总token数
        /// </summary>
        [JsonProperty("TotalToken")]
        public ulong? TotalToken{ get; set; }

        /// <summary>
        /// 总token耗时
        /// </summary>
        [JsonProperty("TotalTokenLatency")]
        public ulong? TotalTokenLatency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallResult", this.CallResult);
            this.SetParamSimple(map, prefix + "CustomerVariable", this.CustomerVariable);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "FirstTokenLatency", this.FirstTokenLatency);
            this.SetParamSimple(map, prefix + "InputToken", this.InputToken);
            this.SetParamSimple(map, prefix + "OutputToken", this.OutputToken);
            this.SetParamSimple(map, prefix + "TotalToken", this.TotalToken);
            this.SetParamSimple(map, prefix + "TotalTokenLatency", this.TotalTokenLatency);
        }
    }
}

