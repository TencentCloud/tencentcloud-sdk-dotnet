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
        /// 用户账号类型；默认开通QQOpenId、手机号MD5权限；如果需要使用微信OpenId入参，则需要"提交工单"或联系对接人进行资格审核，审核通过后方可正常使用微信开放账号。
        /// 1：QQ开放账号
        /// 2：微信开放账号
        /// 10004：手机号MD5，中国大陆11位手机号进行MD5加密，取32位小写值。
        /// </summary>
        [JsonProperty("AccountType")]
        public ulong? AccountType{ get; set; }

        /// <summary>
        /// QQ账号信息，AccountType是"1"时，该字段必填。
        /// </summary>
        [JsonProperty("QQAccount")]
        public QQAccountInfo QQAccount{ get; set; }

        /// <summary>
        /// 微信账号信息，AccountType是"2"时，该字段必填。
        /// </summary>
        [JsonProperty("WeChatAccount")]
        public WeChatAccountInfo WeChatAccount{ get; set; }

        /// <summary>
        /// 其它账号信息，AccountType是10004时，该字段必填。
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

