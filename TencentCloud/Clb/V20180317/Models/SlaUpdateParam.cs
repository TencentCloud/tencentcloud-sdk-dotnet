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

    public class SlaUpdateParam : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例 ID。
        /// 可以通过 [DescribeLoadBalancers](https://cloud.tencent.com/document/product/1108/48459) 接口查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 性能容量型规格，取值范围：
        /// <li> clb.c2.medium：标准型规格 </li>
        /// <li> clb.c3.small：高阶型1规格 </li>
        /// <li> clb.c3.medium：高阶型2规格 </li>
        /// <li> clb.c4.small：超强型1规格 </li>
        /// <li> clb.c4.medium：超强型2规格 </li>
        /// <li> clb.c4.large：超强型3规格 </li>
        /// <li> clb.c4.xlarge：超强型4规格 </li>如需了解规格详情，请参见[实例规格对比](https://cloud.tencent.com/document/product/214/84689)
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
        }
    }
}

