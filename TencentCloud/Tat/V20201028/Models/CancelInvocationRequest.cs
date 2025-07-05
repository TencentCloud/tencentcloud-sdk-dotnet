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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CancelInvocationRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行活动ID。
        /// 
        /// 可通过 [DescribeInvocations(查询执行活动)](https://cloud.tencent.com/document/api/1340/52679) 接口获取。
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// 实例ID列表，上限100。
        /// 
        /// 可通过对应云产品的查询实例接口获取实例 ID。目前支持实例类型：
        /// - CVM
        /// - Lighthouse
        /// - TAT 托管实例
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
        }
    }
}

