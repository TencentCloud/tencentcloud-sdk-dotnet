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

namespace TencentCloud.Tms.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountTipoffAccessRequest : AbstractModel
    {
        
        /// <summary>
        /// 被举报账号，长度低于 128 个字符
        /// </summary>
        [JsonProperty("ReportedAccount")]
        public string ReportedAccount{ get; set; }

        /// <summary>
        /// 被举报账号类型(1-手机号 2-QQ号 3-微信号 4-QQ群号 5-微信openid 6-QQopenid 0-其它)
        /// </summary>
        [JsonProperty("ReportedAccountType")]
        public long? ReportedAccountType{ get; set; }

        /// <summary>
        /// 被举报账号所属恶意类型(1-诈骗，2-骚扰，3-广告，4-违法违规，5-赌博传销，0-其他)
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 举报者账号，长度低于 128 个字符
        /// </summary>
        [JsonProperty("SenderAccount")]
        public string SenderAccount{ get; set; }

        /// <summary>
        /// 举报者账号类型(1-手机号 2-QQ号 3-微信号 4-QQ群号 5-微信openid 6-QQopenid 0-其它)
        /// </summary>
        [JsonProperty("SenderAccountType")]
        public long? SenderAccountType{ get; set; }

        /// <summary>
        /// 举报者IP地址
        /// </summary>
        [JsonProperty("SenderIP")]
        public string SenderIP{ get; set; }

        /// <summary>
        /// 包含被举报账号的恶意内容（比如文本、图片链接，长度低于1024个字符）
        /// </summary>
        [JsonProperty("EvilContent")]
        public string EvilContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReportedAccount", this.ReportedAccount);
            this.SetParamSimple(map, prefix + "ReportedAccountType", this.ReportedAccountType);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "SenderAccount", this.SenderAccount);
            this.SetParamSimple(map, prefix + "SenderAccountType", this.SenderAccountType);
            this.SetParamSimple(map, prefix + "SenderIP", this.SenderIP);
            this.SetParamSimple(map, prefix + "EvilContent", this.EvilContent);
        }
    }
}

