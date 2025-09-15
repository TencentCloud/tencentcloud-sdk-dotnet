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

    public class UpdateScanUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 需要送检的所有用户号。多个用户号之间用","分隔，长度不超过1024字符。示例："0001,0002,0003"
        /// </summary>
        [JsonProperty("UserIdString")]
        public string UserIdString{ get; set; }

        /// <summary>
        /// 符合此正则表达式规则的用户号将被送检，最大不能超过10个。示例：["^6.*"] 表示所有以6开头的用户号将被送检
        /// </summary>
        [JsonProperty("UserIdRegex")]
        public string[] UserIdRegex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "UserIdString", this.UserIdString);
            this.SetParamArraySimple(map, prefix + "UserIdRegex.", this.UserIdRegex);
        }
    }
}

