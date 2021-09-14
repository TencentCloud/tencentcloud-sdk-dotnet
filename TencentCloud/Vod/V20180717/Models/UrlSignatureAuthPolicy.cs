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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UrlSignatureAuthPolicy : AbstractModel
    {
        
        /// <summary>
        /// [Key 防盗链](https://cloud.tencent.com/document/product/266/14047)设置状态，可选值：
        /// <li>Enabled: 启用。</li>
        /// <li>Disabled: 禁用。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// [Key 防盗链](https://cloud.tencent.com/document/product/266/14047)中用于生成签名的密钥。
        /// EncryptedKey 字符串的长度为8~40个字节，不能包含不可见字符。
        /// </summary>
        [JsonProperty("EncryptedKey")]
        public string EncryptedKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EncryptedKey", this.EncryptedKey);
        }
    }
}

