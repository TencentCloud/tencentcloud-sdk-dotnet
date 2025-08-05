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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestIdInfo : AbstractModel
    {
        
        /// <summary>
        /// 请求 api 的 requestid
        /// </summary>
        [JsonProperty("ApiRequestId")]
        public string ApiRequestId{ get; set; }

        /// <summary>
        /// 请求 api 的错误码
        /// </summary>
        [JsonProperty("ApiErrorCode")]
        public string ApiErrorCode{ get; set; }

        /// <summary>
        /// 告警码
        /// </summary>
        [JsonProperty("WarnCodes")]
        public long?[] WarnCodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiRequestId", this.ApiRequestId);
            this.SetParamSimple(map, prefix + "ApiErrorCode", this.ApiErrorCode);
            this.SetParamArraySimple(map, prefix + "WarnCodes.", this.WarnCodes);
        }
    }
}

