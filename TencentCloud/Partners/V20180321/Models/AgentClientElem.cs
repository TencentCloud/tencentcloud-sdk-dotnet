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
        /// 代客类型，可能值为a/b/c/other
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
        /// 1:待代理商审核;2:待腾讯云审核4:待腾讯云渠道审批
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 业务员ID
        /// </summary>
        [JsonProperty("SalesUin")]
        public string SalesUin{ get; set; }

        /// <summary>
        /// 业务员姓名
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 客户名称，此字段和控制台返回一致。
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// 增量目标金额(分)
        /// </summary>
        [JsonProperty("IncreaseGoal")]
        public string IncreaseGoal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ClientFlag", this.ClientFlag);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "HasOverdueBill", this.HasOverdueBill);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SalesUin", this.SalesUin);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamSimple(map, prefix + "IncreaseGoal", this.IncreaseGoal);
        }
    }
}

