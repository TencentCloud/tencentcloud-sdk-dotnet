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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SharedCNAMEInfo : AbstractModel
    {
        
        /// <summary>
        /// 共享CNAME类型：取值范围如下：
        /// <li>custom：由用户创建的自定义共享CNAME</li>
        /// <li>ip-ssl：IP SSL类型的共享CNAME</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 共享CNAME名称。
        /// </summary>
        [JsonProperty("SharedCNAME")]
        public string SharedCNAME{ get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 当type为ip-ssl时，展示该共享CNAME关联的 IP SSL 配置信息。
        /// </summary>
        [JsonProperty("IPSSLConfig")]
        public IPSSLConfig IPSSLConfig{ get; set; }

        /// <summary>
        /// 共享CNAME绑定的加速域名数量。
        /// </summary>
        [JsonProperty("BindDomainCount")]
        public long? BindDomainCount{ get; set; }

        /// <summary>
        /// 加入该共享CNAME的加速域名列表。当加入的域名数量超过100个时，只返回前100个加速域名。
        /// </summary>
        [JsonProperty("AccelerationDomains")]
        public ReferenceHolder[] AccelerationDomains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SharedCNAME", this.SharedCNAME);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "IPSSLConfig.", this.IPSSLConfig);
            this.SetParamSimple(map, prefix + "BindDomainCount", this.BindDomainCount);
            this.SetParamArrayObj(map, prefix + "AccelerationDomains.", this.AccelerationDomains);
        }
    }
}

