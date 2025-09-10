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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchCreateAclRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例Id，可通过[DescribeInstances](https://cloud.tencent.com/document/product/597/40835)接口获取
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Acl资源类型，(2:TOPIC）
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// 资源列表数组，可通过[DescribeTopic](https://cloud.tencent.com/document/product/597/40847)接口获取。
        /// </summary>
        [JsonProperty("ResourceNames")]
        public string[] ResourceNames{ get; set; }

        /// <summary>
        /// 设置的ACL规则列表，可通过[DescribeAclRule](https://cloud.tencent.com/document/product/597/89217)接口获取。
        /// </summary>
        [JsonProperty("RuleList")]
        public AclRuleInfo[] RuleList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "ResourceNames.", this.ResourceNames);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
        }
    }
}

