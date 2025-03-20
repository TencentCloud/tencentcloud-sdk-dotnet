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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GatewayCertificate : AbstractModel
    {
        
        /// <summary>
        /// 网关证书ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 网关证书名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 绑定域名
        /// </summary>
        [JsonProperty("BindDomains")]
        public string[] BindDomains{ get; set; }

        /// <summary>
        /// 证书来源
        /// </summary>
        [JsonProperty("CertSource")]
        public string CertSource{ get; set; }

        /// <summary>
        /// 当前绑定的SSL证书ID
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "BindDomains.", this.BindDomains);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
        }
    }
}

