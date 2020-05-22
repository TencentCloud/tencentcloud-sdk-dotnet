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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInfoGjh : AbstractModel
    {
        
        /// <summary>
        /// 消息发表人简介，非必填，如填写，会结合简介内容判定该条是否有害。评论消息如展示简介则建议填写。
        /// </summary>
        [JsonProperty("StrDesc")]
        public string StrDesc{ get; set; }

        /// <summary>
        /// 消息发表人头像url，非必填，如填写，头像有害，该条消息会被判断为有害。评论消息如展示头像则建议填写。
        /// </summary>
        [JsonProperty("StrHeadUrl")]
        public string StrHeadUrl{ get; set; }

        /// <summary>
        /// 消息发表人昵称，非必填，如填写，会结合昵称信息判断该条内容是否有害。评论消息如展示昵称则建议填写。
        /// </summary>
        [JsonProperty("StrNick")]
        public string StrNick{ get; set; }

        /// <summary>
        /// 发表评论账号ID，如填写，会根据账号历史恶意情况，判定消息有害结果.
        /// </summary>
        [JsonProperty("StrUin")]
        public string StrUin{ get; set; }

        /// <summary>
        /// 1-微信uin 2-QQ号 3-微信群uin 4-qq群号 5-微信openid 6-QQopenid 7-其它string
        /// </summary>
        [JsonProperty("UiAcntType")]
        public long? UiAcntType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrDesc", this.StrDesc);
            this.SetParamSimple(map, prefix + "StrHeadUrl", this.StrHeadUrl);
            this.SetParamSimple(map, prefix + "StrNick", this.StrNick);
            this.SetParamSimple(map, prefix + "StrUin", this.StrUin);
            this.SetParamSimple(map, prefix + "UiAcntType", this.UiAcntType);
        }
    }
}

