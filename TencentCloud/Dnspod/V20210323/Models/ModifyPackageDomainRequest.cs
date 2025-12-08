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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPackageDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作类型：change: 套餐换域名；unbind: 解绑套餐域名；bind: 套餐绑定域名。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 域名ID。Operation为change时必传，代表更换前的域名。
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// 域名ID。Operation为change或bind时必传，代表更换后或要绑定的域名。
        /// </summary>
        [JsonProperty("NewDomainId")]
        public ulong? NewDomainId{ get; set; }

        /// <summary>
        /// 套餐资源ID。Operation为bind或unbind时必传，代表将要操作的套餐资源。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "NewDomainId", this.NewDomainId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

