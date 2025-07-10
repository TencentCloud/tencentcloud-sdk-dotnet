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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyReservedInstanceScopeRequest : AbstractModel
    {
        
        /// <summary>
        /// 预留券实例ID。可通过 [DescribeReservedInstances](https://cloud.tencent.com/document/product/457/99162) 接口返回值中的ReservedInstanceId获取。
        /// </summary>
        [JsonProperty("ReservedInstanceIds")]
        public string[] ReservedInstanceIds{ get; set; }

        /// <summary>
        /// 预留券抵扣范围信息
        /// </summary>
        [JsonProperty("ReservedInstanceScope")]
        public ReservedInstanceScope ReservedInstanceScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ReservedInstanceIds.", this.ReservedInstanceIds);
            this.SetParamObj(map, prefix + "ReservedInstanceScope.", this.ReservedInstanceScope);
        }
    }
}

