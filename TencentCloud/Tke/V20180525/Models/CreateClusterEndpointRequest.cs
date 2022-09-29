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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterEndpointRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群端口所在的子网ID  (仅在开启非外网访问时需要填，必须为集群所在VPC内的子网)
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 是否为外网访问（TRUE 外网访问 FALSE 内网访问，默认值： FALSE）
        /// </summary>
        [JsonProperty("IsExtranet")]
        public bool? IsExtranet{ get; set; }

        /// <summary>
        /// 设置域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 使用的安全组，只有外网访问需要传递（开启外网访问时必传）
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// 创建lb参数，只有外网访问需要设置
        /// </summary>
        [JsonProperty("ExtensiveParameters")]
        public string ExtensiveParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "IsExtranet", this.IsExtranet);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "ExtensiveParameters", this.ExtensiveParameters);
        }
    }
}

