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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAnchorRequest : AbstractModel
    {
        
        /// <summary>
        /// 主播业务ID，唯一
        /// </summary>
        [JsonProperty("AnchorUid")]
        public string AnchorUid{ get; set; }

        /// <summary>
        /// 主播姓名
        /// </summary>
        [JsonProperty("AnchorName")]
        public string AnchorName{ get; set; }

        /// <summary>
        /// 主播电话
        /// _敏感信息_ 使用 __AES128-CBC-PKCS#7__ 加密
        /// </summary>
        [JsonProperty("AnchorPhone")]
        public string AnchorPhone{ get; set; }

        /// <summary>
        /// 主播邮箱
        /// _敏感信息_ 使用 __AES128-CBC-PKCS#7__ 加密
        /// </summary>
        [JsonProperty("AnchorEmail")]
        public string AnchorEmail{ get; set; }

        /// <summary>
        /// 主播地址
        /// _敏感信息_ 使用 __AES128-CBC-PKCS#7__ 加密
        /// </summary>
        [JsonProperty("AnchorAddress")]
        public string AnchorAddress{ get; set; }

        /// <summary>
        /// 主播身份证号
        /// _敏感信息_ 使用 __AES128-CBC-PKCS#7__ 加密
        /// </summary>
        [JsonProperty("AnchorIdNo")]
        public string AnchorIdNo{ get; set; }

        /// <summary>
        /// 主播类型
        /// __KMusic__:全民K歌
        /// __QMusic__:QQ音乐
        /// __WeChat__:微信视频号
        /// </summary>
        [JsonProperty("AnchorType")]
        public string AnchorType{ get; set; }

        /// <summary>
        /// 主播扩展信息
        /// </summary>
        [JsonProperty("AnchorExtendInfo")]
        public AnchorExtendInfo[] AnchorExtendInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnchorUid", this.AnchorUid);
            this.SetParamSimple(map, prefix + "AnchorName", this.AnchorName);
            this.SetParamSimple(map, prefix + "AnchorPhone", this.AnchorPhone);
            this.SetParamSimple(map, prefix + "AnchorEmail", this.AnchorEmail);
            this.SetParamSimple(map, prefix + "AnchorAddress", this.AnchorAddress);
            this.SetParamSimple(map, prefix + "AnchorIdNo", this.AnchorIdNo);
            this.SetParamSimple(map, prefix + "AnchorType", this.AnchorType);
            this.SetParamArrayObj(map, prefix + "AnchorExtendInfo.", this.AnchorExtendInfo);
        }
    }
}

