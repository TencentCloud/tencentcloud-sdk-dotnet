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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentClientElem : AbstractModel
    {
        
        /// <summary>
        /// 代理商账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 代客账号ID
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 代客申请时间戳
        /// </summary>
        [JsonProperty("ApplyTime")]
        public ulong? ApplyTime{ get; set; }

        /// <summary>
        /// 代客类型，可能值为a/b/c
        /// </summary>
        [JsonProperty("ClientFlag")]
        public string ClientFlag{ get; set; }

        /// <summary>
        /// 代客邮箱，打码显示
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// 代客手机，打码显示
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 0表示不欠费，1表示欠费
        /// </summary>
        [JsonProperty("HasOverdueBill")]
        public ulong? HasOverdueBill{ get; set; }

        /// <summary>
        /// 1:待代理商审核;2:待腾讯云审核
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ClientFlag", this.ClientFlag);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "HasOverdueBill", this.HasOverdueBill);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

