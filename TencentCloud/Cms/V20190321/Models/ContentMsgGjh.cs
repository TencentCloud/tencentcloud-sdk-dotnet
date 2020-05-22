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

    public class ContentMsgGjh : AbstractModel
    {
        
        /// <summary>
        /// 发表消息设备IP类型，0x0代表IP地址是ipv4，0x1代表是IPv6，默认为0，即IPv4。
        /// </summary>
        [JsonProperty("CIPType")]
        public string CIPType{ get; set; }

        /// <summary>
        /// 发表消息设备IPv4地址，没有可以为空字符串；
        /// </summary>
        [JsonProperty("StrMsgIP")]
        public string StrMsgIP{ get; set; }

        /// <summary>
        /// 发表消息设备IPv6地址，没有可以为空字符串。
        /// </summary>
        [JsonProperty("StrMsgIPv6")]
        public string StrMsgIPv6{ get; set; }

        /// <summary>
        /// 消息发表时间戳。
        /// </summary>
        [JsonProperty("UiPostTime")]
        public long? UiPostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CIPType", this.CIPType);
            this.SetParamSimple(map, prefix + "StrMsgIP", this.StrMsgIP);
            this.SetParamSimple(map, prefix + "StrMsgIPv6", this.StrMsgIPv6);
            this.SetParamSimple(map, prefix + "UiPostTime", this.UiPostTime);
        }
    }
}

