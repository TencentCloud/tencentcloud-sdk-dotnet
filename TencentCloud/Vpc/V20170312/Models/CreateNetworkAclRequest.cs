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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNetworkAclRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。可通过<a href="https://cloud.tencent.com/document/product/215/15778">DescribeVpcs</a>接口返回值中的VpcId获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 网络ACL名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("NetworkAclName")]
        public string NetworkAclName{ get; set; }

        /// <summary>
        /// 网络ACL类型，三元组(TRIPLE)或五元组(QUINTUPLE)。默认值三元组(TRIPLE)。
        /// </summary>
        [JsonProperty("NetworkAclType")]
        public string NetworkAclType{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkAclName", this.NetworkAclName);
            this.SetParamSimple(map, prefix + "NetworkAclType", this.NetworkAclType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

