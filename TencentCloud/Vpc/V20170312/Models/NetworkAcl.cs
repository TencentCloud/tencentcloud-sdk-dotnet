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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkAcl : AbstractModel
    {
        
        /// <summary>
        /// `VPC`实例`ID`。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 网络ACL实例`ID`。
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// 网络ACL名称，最大长度为60。
        /// </summary>
        [JsonProperty("NetworkAclName")]
        public string NetworkAclName{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 网络ACL关联的子网数组。
        /// </summary>
        [JsonProperty("SubnetSet")]
        public Subnet[] SubnetSet{ get; set; }

        /// <summary>
        /// 该参数仅对三元组ACL有效，网络ACl入站规则。
        /// </summary>
        [JsonProperty("IngressEntries")]
        public NetworkAclEntry[] IngressEntries{ get; set; }

        /// <summary>
        /// 该参数仅对三元组ACL有效，网络ACL出站规则。
        /// </summary>
        [JsonProperty("EgressEntries")]
        public NetworkAclEntry[] EgressEntries{ get; set; }

        /// <summary>
        /// 网络ACL类型。三元组：'TRIPLE'   五元组：'QUINTUPLE'
        /// </summary>
        [JsonProperty("NetworkAclType")]
        public string NetworkAclType{ get; set; }

        /// <summary>
        /// 标签键值对
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamSimple(map, prefix + "NetworkAclName", this.NetworkAclName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "SubnetSet.", this.SubnetSet);
            this.SetParamArrayObj(map, prefix + "IngressEntries.", this.IngressEntries);
            this.SetParamArrayObj(map, prefix + "EgressEntries.", this.EgressEntries);
            this.SetParamSimple(map, prefix + "NetworkAclType", this.NetworkAclType);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

