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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DNSAttributes : AbstractModel
    {
        
        /// <summary>
        /// 记录类型 CNAME | A | TXT | MX
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("SendDomain")]
        public string SendDomain{ get; set; }

        /// <summary>
        /// 需要配置的值
        /// </summary>
        [JsonProperty("ExpectedValue")]
        public string ExpectedValue{ get; set; }

        /// <summary>
        /// 腾讯云目前检测到的值
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 检测是否通过，创建时默认为false
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SendDomain", this.SendDomain);
            this.SetParamSimple(map, prefix + "ExpectedValue", this.ExpectedValue);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

