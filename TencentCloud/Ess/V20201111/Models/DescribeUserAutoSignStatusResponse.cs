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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserAutoSignStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询用户是否已开通自动签
        /// </summary>
        [JsonProperty("IsOpen")]
        public bool? IsOpen{ get; set; }

        /// <summary>
        /// 自动签许可生效时间。当且仅当已开通自动签时有值。
        /// 
        /// 值为unix时间戳,单位为秒。
        /// </summary>
        [JsonProperty("LicenseFrom")]
        public long? LicenseFrom{ get; set; }

        /// <summary>
        /// 自动签许可到期时间。当且仅当已开通自动签时有值。
        /// 值为unix时间戳,单位为秒。
        /// </summary>
        [JsonProperty("LicenseTo")]
        public long? LicenseTo{ get; set; }

        /// <summary>
        /// 设置用户开通自动签时是否绑定个人自动签账号许可。一旦绑定后，将扣减购买的个人自动签账号许可一次（1年有效期），不可解绑释放。不传默认为绑定自动签账号许可。
        /// 0-绑定个人自动签账号许可，开通后将扣减购买的个人自动签账号许可一次
        /// 1-不绑定，发起合同时将按标准合同套餐进行扣减
        /// </summary>
        [JsonProperty("LicenseType")]
        public long? LicenseType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "LicenseFrom", this.LicenseFrom);
            this.SetParamSimple(map, prefix + "LicenseTo", this.LicenseTo);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

