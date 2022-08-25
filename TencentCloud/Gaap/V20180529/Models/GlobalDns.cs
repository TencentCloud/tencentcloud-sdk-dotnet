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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GlobalDns : AbstractModel
    {
        
        /// <summary>
        /// 解析记录ID
        /// </summary>
        [JsonProperty("DnsRecordId")]
        public ulong? DnsRecordId{ get; set; }

        /// <summary>
        /// 域名就近接入地域信息列表
        /// </summary>
        [JsonProperty("CountryAreaList")]
        public CountryAreaMap[] CountryAreaList{ get; set; }

        /// <summary>
        /// 域名解析对应的通道接入点信息列表
        /// </summary>
        [JsonProperty("AccessList")]
        public ProxyAccessInfo[] AccessList{ get; set; }

        /// <summary>
        /// 解析状态：1表示运行中，2表示创建中，3表示修改中，4表示删除中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsRecordId", this.DnsRecordId);
            this.SetParamArrayObj(map, prefix + "CountryAreaList.", this.CountryAreaList);
            this.SetParamArrayObj(map, prefix + "AccessList.", this.AccessList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

