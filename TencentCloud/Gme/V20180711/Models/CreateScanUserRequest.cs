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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateScanUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，登录控制台 - 服务管理创建应用得到的AppID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 需要新增送检的用户号。示例：1234
        /// (若UserId不填，则UserIdString必填；两者选其一；两者都填以UserIdString为准)
        /// </summary>
        [JsonProperty("UserId")]
        public ulong? UserId{ get; set; }

        /// <summary>
        /// 需要新增送检的用户号。示例："1234"
        /// (若UserIdString不填，则UserId必填；两者选其一；两者都填以UserIdString为准)
        /// </summary>
        [JsonProperty("UserIdString")]
        public string UserIdString{ get; set; }

        /// <summary>
        /// 当前用户送检过期时间，单位：秒。
        /// 若参数不为0，则在过期时间之后，用户不会被送检。
        /// 若参数为0，则送检配置不会自动失效。 
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public ulong? ExpirationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserIdString", this.UserIdString);
            this.SetParamSimple(map, prefix + "ExpirationTime", this.ExpirationTime);
        }
    }
}

