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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRealtimeScanConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回结果码，0正常，非0失败
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 送检类型，0: 全量送审，1: 自定义送审
        /// </summary>
        [JsonProperty("AuditType")]
        public long? AuditType{ get; set; }

        /// <summary>
        /// 用户号正则表达式。
        /// 符合此正则表达式规则的用户号将被送检。示例：^6.*（表示所有以6开头的用户号将被送检）
        /// </summary>
        [JsonProperty("UserIdRegex")]
        public string[] UserIdRegex{ get; set; }

        /// <summary>
        /// 房间号正则表达式。
        /// 符合此正则表达式规则的房间号将被送检。示例：^6.*（表示所有以6开头的房间号将被送检）
        /// </summary>
        [JsonProperty("RoomIdRegex")]
        public string[] RoomIdRegex{ get; set; }

        /// <summary>
        /// 用户号字符串，逗号分隔，示例："0001,0002,0003"
        /// </summary>
        [JsonProperty("UserIdString")]
        public string UserIdString{ get; set; }

        /// <summary>
        /// 房间号字符串，逗号分隔，示例："0001,0002,0003"
        /// </summary>
        [JsonProperty("RoomIdString")]
        public string RoomIdString{ get; set; }

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
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "AuditType", this.AuditType);
            this.SetParamArraySimple(map, prefix + "UserIdRegex.", this.UserIdRegex);
            this.SetParamArraySimple(map, prefix + "RoomIdRegex.", this.RoomIdRegex);
            this.SetParamSimple(map, prefix + "UserIdString", this.UserIdString);
            this.SetParamSimple(map, prefix + "RoomIdString", this.RoomIdString);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

