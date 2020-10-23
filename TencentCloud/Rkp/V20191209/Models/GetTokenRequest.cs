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

namespace TencentCloud.Rkp.V20191209.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("BusinessId")]
        public long? BusinessId{ get; set; }

        /// <summary>
        /// 业务子场景
        /// </summary>
        [JsonProperty("Scene")]
        public long? Scene{ get; set; }

        /// <summary>
        /// 业务侧账号体系下的用户ID
        /// </summary>
        [JsonProperty("BusinessUserId")]
        public string BusinessUserId{ get; set; }

        /// <summary>
        /// 用户侧的IP
        /// </summary>
        [JsonProperty("AppClientIp")]
        public string AppClientIp{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 上一个token
        /// </summary>
        [JsonProperty("OldToken")]
        public string OldToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "BusinessUserId", this.BusinessUserId);
            this.SetParamSimple(map, prefix + "AppClientIp", this.AppClientIp);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OldToken", this.OldToken);
        }
    }
}

