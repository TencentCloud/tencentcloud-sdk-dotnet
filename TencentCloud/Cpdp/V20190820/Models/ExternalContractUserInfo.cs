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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalContractUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 第三方用户类型，例如:  WX_OPENID, WX_SUB_OPENID,WX_PAYER_OPENID
        /// </summary>
        [JsonProperty("ExternalUserType")]
        public string ExternalUserType{ get; set; }

        /// <summary>
        /// 第三方用户ID
        /// </summary>
        [JsonProperty("ExternalUserId")]
        public string ExternalUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalUserType", this.ExternalUserType);
            this.SetParamSimple(map, prefix + "ExternalUserId", this.ExternalUserId);
        }
    }
}

