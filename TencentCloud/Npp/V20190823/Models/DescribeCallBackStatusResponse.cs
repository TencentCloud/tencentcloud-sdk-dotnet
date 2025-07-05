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

namespace TencentCloud.Npp.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCallBackStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 业务appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 回拨请求响应中返回的 callId
        /// </summary>
        [JsonProperty("CallId")]
        public string CallId{ get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("Dst")]
        public string Dst{ get; set; }

        /// <summary>
        /// 通话最后状态：0：未知状态 1：主叫响铃中 2：主叫接听 3：被叫响铃中 4：正常通话中 5：通话结束
        /// </summary>
        [JsonProperty("CallStatus")]
        public string CallStatus{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CallId", this.CallId);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "Dst", this.Dst);
            this.SetParamSimple(map, prefix + "CallStatus", this.CallStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

