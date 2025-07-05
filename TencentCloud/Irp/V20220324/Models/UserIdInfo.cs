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

namespace TencentCloud.Irp.V20220324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserIdInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户ID类型：
        /// 1 - qq
        /// 2 - qq_md5：md5后的qq
        /// 3 - imei：设备imei（安卓10之后不会再授权imei，安卓10之后的imei映射关系可能拿不到，故安卓10之后的设备建议用oaid）
        /// 4 - imei_md5：md5后的imei
        /// 5 - idfa: Apple 向用户设备随机分配的设备标识符
        /// 6 - idfa_md5：md5之后的idfa
        /// 7 - gdt_openid：广点通生成的openid
        /// 8 - oaid：安卓10之后一种非永久性设备标识符
        /// 9 - oaid_md5：md5后的oaid
        /// 10 - wx_openid：微信openid
        /// 11 - qq_openid：QQ的openid
        /// 12 - phone：电话号码
        /// 13 - phone_md5：md5后的电话号码
        /// 14 - phone_sha256：SHA256加密的手机号
        /// 15 - phone_sm3：国密SM3加密的手机号
        /// 1000 - 客户自定义id
        /// </summary>
        [JsonProperty("UserIdType")]
        public long? UserIdType{ get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserIdType", this.UserIdType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

