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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPublicNetworkAccessPointRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群名字
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("PublicNetworkAccessPointStatus")]
        public bool? PublicNetworkAccessPointStatus{ get; set; }

        /// <summary>
        /// 必填，公网控制台的开关/Vpc控制台的开关，示例值，Public/Vpc
        /// </summary>
        [JsonProperty("SwitchOwner")]
        public string SwitchOwner{ get; set; }

        /// <summary>
        /// Vpc
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网下面指定ip作为vpc接入点
        /// </summary>
        [JsonProperty("SelectIp")]
        public string SelectIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "PublicNetworkAccessPointStatus", this.PublicNetworkAccessPointStatus);
            this.SetParamSimple(map, prefix + "SwitchOwner", this.SwitchOwner);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SelectIp", this.SelectIp);
        }
    }
}

