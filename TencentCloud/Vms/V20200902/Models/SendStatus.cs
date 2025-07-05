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

namespace TencentCloud.Vms.V20200902.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendStatus : AbstractModel
    {
        
        /// <summary>
        /// 标识本次发送 ID，标识一次下发记录。
        /// </summary>
        [JsonProperty("CallId")]
        public string CallId{ get; set; }

        /// <summary>
        /// 用户的 session 内容，腾讯 server 回包中会原样返回。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallId", this.CallId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
        }
    }
}

