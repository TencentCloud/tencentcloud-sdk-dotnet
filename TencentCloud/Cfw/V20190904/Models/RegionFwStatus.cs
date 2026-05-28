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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionFwStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>引流网络部署状态</p><ol><li>&quot;NotDeployed&quot;  防火墙集群未部署</li><li>&quot;Deployed&quot;        防火墙集群已部署，但未创建引流网络</li><li>&quot;DeployedCustomOnly&quot;  防火墙集群已部署，但内网段被全覆盖，无法自动选择引流网络，需自定义设置引流网段</li><li>&quot;Auto&quot;                防火墙集群已部署，并自动选择网段创建了引流网络</li><li>&quot;Custom&quot;            防火墙集群已部署，并根据用户自定义网段创建了引流网络</li></ol>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>引流网络的cidr，如果没有部署引流网络则为空</p>
        /// </summary>
        [JsonProperty("Cidr")]
        public string Cidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cidr", this.Cidr);
        }
    }
}

