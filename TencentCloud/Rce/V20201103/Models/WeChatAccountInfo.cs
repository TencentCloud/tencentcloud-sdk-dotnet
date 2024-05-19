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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WeChatAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 微信的OpenId/UnionId。
        /// </summary>
        [JsonProperty("WeChatOpenId")]
        public string WeChatOpenId{ get; set; }

        /// <summary>
        /// 微信开放账号类型：
        /// 1：微信公众号/微信第三方登录。
        /// 2：微信小程序。
        /// </summary>
        [JsonProperty("WeChatSubType")]
        public ulong? WeChatSubType{ get; set; }

        /// <summary>
        /// 随机串。如果WeChatSubType是2，该字段必填。Token签名随机数，建议16个字符。
        /// </summary>
        [JsonProperty("RandStr")]
        public string RandStr{ get; set; }

        /// <summary>
        /// 如果WeChatSubType 是1，填入授权的 access_token（注意：不是普通 access_token，详情请参阅官方说明文档。获取网页版本的 access_token 时，scope 字段必需填写snsapi_userinfo
        /// 如果WeChatSubType是2，填入以session_key 为密钥签名随机数RandStr（hmac_sha256签名算法）得到的字符串。
        /// </summary>
        [JsonProperty("WeChatAccessToken")]
        public string WeChatAccessToken{ get; set; }

        /// <summary>
        /// 用于标识微信用户登录后所关联业务自身的账号ID。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 账号绑定的MD5手机号，
        /// 注释：只支持标准中国大陆11位手机号MD5加密后位的32位小写字符串。
        /// </summary>
        [JsonProperty("MobilePhone")]
        public string MobilePhone{ get; set; }

        /// <summary>
        /// 用户设备号（已不推荐使用）。
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WeChatOpenId", this.WeChatOpenId);
            this.SetParamSimple(map, prefix + "WeChatSubType", this.WeChatSubType);
            this.SetParamSimple(map, prefix + "RandStr", this.RandStr);
            this.SetParamSimple(map, prefix + "WeChatAccessToken", this.WeChatAccessToken);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "MobilePhone", this.MobilePhone);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
        }
    }
}

