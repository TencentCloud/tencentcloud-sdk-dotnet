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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDomainAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例 ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡监听器 ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 域名（必须是已经创建的转发规则下的域名）
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 要修改的新域名
        /// </summary>
        [JsonProperty("NewDomain")]
        public string NewDomain{ get; set; }

        /// <summary>
        /// 域名相关的证书信息，注意，仅对启用SNI的监听器适用。
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// 是否开启Http2，注意，只有HTTPS域名才能开启Http2。
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// 是否设为默认域名，注意，一个监听器下只能设置一个默认域名。
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "NewDomain", this.NewDomain);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
        }
    }
}

