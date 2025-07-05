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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCorporationOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CorpName")]
        public string CorpName{ get; set; }

        /// <summary>
        /// 所有者ID
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 溯源码额度
        /// </summary>
        [JsonProperty("CodeQuota")]
        public ulong? CodeQuota{ get; set; }

        /// <summary>
        /// 额度过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("ContactPerson")]
        public string ContactPerson{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("ContactNumber")]
        public string ContactNumber{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CorpName", this.CorpName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "CodeQuota", this.CodeQuota);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "ContactPerson", this.ContactPerson);
            this.SetParamSimple(map, prefix + "ContactNumber", this.ContactNumber);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

