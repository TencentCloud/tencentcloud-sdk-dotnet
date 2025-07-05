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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SuccessCreateStaffData : AbstractModel
    {
        
        /// <summary>
        /// 员工名
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 员工在电子签平台的id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 提示，当创建已存在未实名用户时，该字段有值
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 传入的企微账号id
        /// </summary>
        [JsonProperty("WeworkOpenId")]
        public string WeworkOpenId{ get; set; }

        /// <summary>
        /// 员工邀请返回链接 根据入参的 InvitationNotifyType 和 Endpoint 返回链接 <table><tbody><tr><td>链接类型</td><td>有效期</td><td>示例</td></tr><tr><td>HTTP_SHORT_URL（短链）</td><td>一天</td><td>https://test.essurl.cn/fvG7UBEd0F</td></tr><tr><td>HTTP（长链）</td><td>一天</td><td>https://res.ess.tencent.cn/cdn/h5-activity-dev/jump-mp.html?where=mini&from=MSG&to=USER_VERIFY&verifyToken=yDCVbUUckpwocmfpUySko7IS83LTV0u0&expireTime=1710840183</td></tr><tr><td>H5</td><td>30 天</td><td>https://quick.test.qian.tencent.cn/guide?Code=yDCVbUUckpwtvxqoUbTw4VBBjLbfAtW7&CodeType=QUICK&shortKey=yDCVbUY7lhqV7mZlCL2d</td></tr><tr><td>APP</td><td>一天</td><td>/pages/guide/index?to=USER_VERIFY&verifyToken=yDCVbUUckpwocm96UySko7ISvEIZH7Yz&expireTime=1710840455 </td></tr></tbody></table>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "WeworkOpenId", this.WeworkOpenId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

