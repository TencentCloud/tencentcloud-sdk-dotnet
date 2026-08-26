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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserAKInfo : AbstractModel
    {
        
        /// <summary>
        /// APPID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 账号昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 账号下ak数量
        /// </summary>
        [JsonProperty("AKNum")]
        public long? AKNum{ get; set; }

        /// <summary>
        /// 是否被共享，1-被共享，2-未被共享
        /// </summary>
        [JsonProperty("IsShared")]
        public long? IsShared{ get; set; }

        /// <summary>
        /// 是否单独购买，1-单独购买，2-未单独购买
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public long? IsSelfBuy{ get; set; }

        /// <summary>
        /// 配额来源账号
        /// </summary>
        [JsonProperty("ShareFromAppID")]
        public long? ShareFromAppID{ get; set; }

        /// <summary>
        /// 云厂商类型
        /// 0:腾讯云
        /// 1:亚马逊云
        /// 2:微软云
        /// 3:谷歌云
        /// 4:阿里云
        /// 5:华为云
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "AKNum", this.AKNum);
            this.SetParamSimple(map, prefix + "IsShared", this.IsShared);
            this.SetParamSimple(map, prefix + "IsSelfBuy", this.IsSelfBuy);
            this.SetParamSimple(map, prefix + "ShareFromAppID", this.ShareFromAppID);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

