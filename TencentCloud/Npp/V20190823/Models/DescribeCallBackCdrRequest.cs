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

    public class DescribeCallBackCdrRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务appid
        /// </summary>
        [JsonProperty("BizAppId")]
        public string BizAppId{ get; set; }

        /// <summary>
        /// 回拨请求响应中返回的 callId，按 callId 查询该话单详细信息
        /// </summary>
        [JsonProperty("CallId")]
        public string CallId{ get; set; }

        /// <summary>
        /// 查询主叫用户产生的呼叫话单，如填空表示拉取这个时间段所有话单
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 话单开始时间戳
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public string StartTimeStamp{ get; set; }

        /// <summary>
        /// 话单结束时间戳
        /// </summary>
        [JsonProperty("EndTimeStamp")]
        public string EndTimeStamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizAppId", this.BizAppId);
            this.SetParamSimple(map, prefix + "CallId", this.CallId);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "StartTimeStamp", this.StartTimeStamp);
            this.SetParamSimple(map, prefix + "EndTimeStamp", this.EndTimeStamp);
        }
    }
}

