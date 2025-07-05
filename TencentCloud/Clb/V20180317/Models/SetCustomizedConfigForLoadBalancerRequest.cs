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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetCustomizedConfigForLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作类型。
        /// - ADD：创建
        /// - DELETE：删除
        /// - UPDATE：修改
        /// - BIND：绑定
        /// - UNBIND：解绑
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// 个性化配置ID。除了创建个性化配置外，必传此字段，如：pz-1234abcd
        /// </summary>
        [JsonProperty("UconfigId")]
        public string UconfigId{ get; set; }

        /// <summary>
        /// 个性化配置内容。创建个性化配置或修改个性化配置的内容时，必传此字段。
        /// 具体限制查看 [七层个性化配置](https://cloud.tencent.com/document/product/214/15171)
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// 个性化配置名称。创建个性化配置或修改个性化配置的名字时，必传此字段。
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 负载均衡实例ID。绑定解绑时，必传此字段。
        /// 可以通过 [DescribeLoadBalancers](https://cloud.tencent.com/document/product/1108/48459) 接口查询。
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "UconfigId", this.UconfigId);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
        }
    }
}

