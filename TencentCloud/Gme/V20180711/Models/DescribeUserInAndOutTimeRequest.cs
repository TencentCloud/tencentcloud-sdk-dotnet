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

    public class DescribeUserInAndOutTimeRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BizId")]
        public long? BizId{ get; set; }

        /// <summary>
        /// 房间ID
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public long? UserId{ get; set; }

        /// <summary>
        /// 字符串类型用户ID
        /// </summary>
        [JsonProperty("UserIdStr")]
        public string UserIdStr{ get; set; }

        /// <summary>
        /// 字符串类型房间ID
        /// </summary>
        [JsonProperty("RoomIdStr")]
        public string RoomIdStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserIdStr", this.UserIdStr);
            this.SetParamSimple(map, prefix + "RoomIdStr", this.RoomIdStr);
        }
    }
}

