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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDomainOwnerBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 要过户的域名。
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 转入账户的uin。
        /// </summary>
        [JsonProperty("NewOwnerUin")]
        public string NewOwnerUin{ get; set; }

        /// <summary>
        /// 是否同时转移对应的 DNS 解析域名，默认false
        /// </summary>
        [JsonProperty("TransferDns")]
        public bool? TransferDns{ get; set; }

        /// <summary>
        /// 转入账户的appid。
        /// </summary>
        [JsonProperty("NewOwnerAppId")]
        public string NewOwnerAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "NewOwnerUin", this.NewOwnerUin);
            this.SetParamSimple(map, prefix + "TransferDns", this.TransferDns);
            this.SetParamSimple(map, prefix + "NewOwnerAppId", this.NewOwnerAppId);
        }
    }
}

