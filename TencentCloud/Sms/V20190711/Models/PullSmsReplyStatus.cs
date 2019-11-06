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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullSmsReplyStatus : AbstractModel
    {
        
        /// <summary>
        /// 通道扩展码，默认没有开通（需要填空）
        /// </summary>
        [JsonProperty("ExtendCode")]
        public string ExtendCode{ get; set; }

        /// <summary>
        /// 国家（或地区）码
        /// </summary>
        [JsonProperty("NationCode")]
        public string NationCode{ get; set; }

        /// <summary>
        /// 手机号码（ e.164 标准）
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 短信签名
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// 用户回复的内容
        /// </summary>
        [JsonProperty("ReplyContent")]
        public string ReplyContent{ get; set; }

        /// <summary>
        /// 回复时间，UNIX 时间戳（单位：秒）
        /// </summary>
        [JsonProperty("ReplyTime")]
        public ulong? ReplyTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExtendCode", this.ExtendCode);
            this.SetParamSimple(map, prefix + "NationCode", this.NationCode);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamSimple(map, prefix + "ReplyContent", this.ReplyContent);
            this.SetParamSimple(map, prefix + "ReplyTime", this.ReplyTime);
        }
    }
}

