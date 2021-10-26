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

    public class AccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("AccountType")]
        public ulong? AccountType{ get; set; }

        /// <summary>
        /// QQ账号信息，AccountType是1时，该字段必填。
        /// </summary>
        [JsonProperty("QQAccount")]
        public QQAccountInfo QQAccount{ get; set; }

        /// <summary>
        /// 微信账号信息，AccountType是2时，该字段必填。
        /// </summary>
        [JsonProperty("WeChatAccount")]
        public WeChatAccountInfo WeChatAccount{ get; set; }

        /// <summary>
        /// 其它账号信息，AccountType是0、4、8或10004时，该字段必填。
        /// </summary>
        [JsonProperty("OtherAccount")]
        public OtherAccountInfo OtherAccount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamObj(map, prefix + "QQAccount.", this.QQAccount);
            this.SetParamObj(map, prefix + "WeChatAccount.", this.WeChatAccount);
            this.SetParamObj(map, prefix + "OtherAccount.", this.OtherAccount);
        }
    }
}

