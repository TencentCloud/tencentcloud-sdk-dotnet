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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelDescribeUserAutoSignStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询用户是否已开通自动签
        /// </summary>
        [JsonProperty("IsOpen")]
        public bool? IsOpen{ get; set; }

        /// <summary>
        /// 自动签许可生效时间。当且仅当已通过许可开通自动签时有值。
        /// 
        /// 值为unix时间戳,单位为秒。
        /// </summary>
        [JsonProperty("LicenseFrom")]
        public long? LicenseFrom{ get; set; }

        /// <summary>
        /// 自动签许可到期时间。当且仅当已通过许可开通自动签时有值。
        /// 
        /// 值为unix时间戳,单位为秒。
        /// </summary>
        [JsonProperty("LicenseTo")]
        public long? LicenseTo{ get; set; }

        /// <summary>
        /// 设置用户开通自动签时是否绑定个人自动签账号许可。<ul><li>**0**: 使用个人自动签账号许可进行开通，个人自动签账号许可有效期1年，注: `不可解绑释放更换他人`</li><li>**1**: 不绑定自动签账号许可开通，后续使用合同份额进行合同发起</li></ul>
        /// </summary>
        [JsonProperty("LicenseType")]
        public long? LicenseType{ get; set; }

        /// <summary>
        /// 用户开通自动签指定使用的印章，为空则未设置印章，需重新进入开通链接设置印章。
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "LicenseFrom", this.LicenseFrom);
            this.SetParamSimple(map, prefix + "LicenseTo", this.LicenseTo);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

