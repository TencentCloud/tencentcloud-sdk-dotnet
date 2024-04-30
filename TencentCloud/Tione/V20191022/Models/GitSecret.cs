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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GitSecret : AbstractModel
    {
        
        /// <summary>
        /// 无密钥，默认选项
        /// </summary>
        [JsonProperty("NoSecret")]
        public bool? NoSecret{ get; set; }

        /// <summary>
        /// Git用户名密码base64编码后的字符串
        /// 编码前的内容应为Json字符串，如
        /// {"UserName": "用户名", "Password":"密码"}
        /// </summary>
        [JsonProperty("Secret")]
        public string Secret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoSecret", this.NoSecret);
            this.SetParamSimple(map, prefix + "Secret", this.Secret);
        }
    }
}

