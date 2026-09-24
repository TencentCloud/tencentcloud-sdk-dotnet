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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindVirtualAccountResultData : AbstractModel
    {
        
        /// <summary>
        /// <p>账号Id（通过AccountIdList传入时回显）</p>
        /// </summary>
        [JsonProperty("AccountId")]
        public long? AccountId{ get; set; }

        /// <summary>
        /// <p>目录ID（通过AccountUserList传入时回显，否则为0）</p>
        /// </summary>
        [JsonProperty("MenuId")]
        public ulong? MenuId{ get; set; }

        /// <summary>
        /// <p>失败原因，仅失败项有值：ACCOUNT_NOT_FOUND / ACCOUNT_NOT_IN_GROUP / DB_ERROR</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// <p>登录账号（通过AccountUserList传入时回显，否则为空）</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "MenuId", this.MenuId);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

