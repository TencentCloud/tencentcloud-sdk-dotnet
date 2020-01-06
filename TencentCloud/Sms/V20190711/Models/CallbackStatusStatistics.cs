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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallbackStatusStatistics : AbstractModel
    {
        
        /// <summary>
        /// 短信回执量统计。
        /// </summary>
        [JsonProperty("CallbackCount")]
        public ulong? CallbackCount{ get; set; }

        /// <summary>
        /// 短信提交成功量统计。
        /// </summary>
        [JsonProperty("RequestSuccessCount")]
        public ulong? RequestSuccessCount{ get; set; }

        /// <summary>
        /// 短信回执失败量统计。
        /// </summary>
        [JsonProperty("CallbackFailCount")]
        public ulong? CallbackFailCount{ get; set; }

        /// <summary>
        /// 短信回执成功量统计。
        /// </summary>
        [JsonProperty("CallbackSuccessCount")]
        public ulong? CallbackSuccessCount{ get; set; }

        /// <summary>
        /// 运营商内部错误统计。
        /// </summary>
        [JsonProperty("InternalErrorCount")]
        public ulong? InternalErrorCount{ get; set; }

        /// <summary>
        /// 号码无效或空号统计。
        /// </summary>
        [JsonProperty("InvalidNumberCount")]
        public ulong? InvalidNumberCount{ get; set; }

        /// <summary>
        /// 停机、关机等错误统计。
        /// </summary>
        [JsonProperty("ShutdownErrorCount")]
        public ulong? ShutdownErrorCount{ get; set; }

        /// <summary>
        /// 号码拉入黑名单统计。
        /// </summary>
        [JsonProperty("BlackListCount")]
        public ulong? BlackListCount{ get; set; }

        /// <summary>
        /// 运营商频率限制统计。
        /// </summary>
        [JsonProperty("FrequencyLimitCount")]
        public ulong? FrequencyLimitCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackCount", this.CallbackCount);
            this.SetParamSimple(map, prefix + "RequestSuccessCount", this.RequestSuccessCount);
            this.SetParamSimple(map, prefix + "CallbackFailCount", this.CallbackFailCount);
            this.SetParamSimple(map, prefix + "CallbackSuccessCount", this.CallbackSuccessCount);
            this.SetParamSimple(map, prefix + "InternalErrorCount", this.InternalErrorCount);
            this.SetParamSimple(map, prefix + "InvalidNumberCount", this.InvalidNumberCount);
            this.SetParamSimple(map, prefix + "ShutdownErrorCount", this.ShutdownErrorCount);
            this.SetParamSimple(map, prefix + "BlackListCount", this.BlackListCount);
            this.SetParamSimple(map, prefix + "FrequencyLimitCount", this.FrequencyLimitCount);
        }
    }
}

