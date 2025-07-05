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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCorpRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业全称
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName{ get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullName", this.FullName);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
        }
    }
}

