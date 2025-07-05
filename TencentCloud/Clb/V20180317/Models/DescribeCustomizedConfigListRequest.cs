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

    public class DescribeCustomizedConfigListRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置类型:CLB 负载均衡维度。 SERVER 域名维度。 LOCATION 规则维度。
        /// </summary>
        [JsonProperty("ConfigType")]
        public string ConfigType{ get; set; }

        /// <summary>
        /// 拉取页偏移，默认值0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 拉取数目，默认值20。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 拉取指定配置名字，模糊匹配。
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置ID，可以通过 [DescribeCustomizedConfigList](https://cloud.tencent.com/document/api/214/60009) 接口查询。
        /// </summary>
        [JsonProperty("UconfigIds")]
        public string[] UconfigIds{ get; set; }

        /// <summary>
        /// 过滤条件如下：
        /// - loadbalancer-id
        /// 按照【负载均衡 ID】进行过滤。实例计费模式例如：lb-9vxezxza。
        /// 类型：String
        /// 必选：否
        /// 获取方式：[DescribeLoadBalancers](https://cloud.tencent.com/document/product/1108/48459)
        /// - vip
        /// 按照【负载均衡VIP】进行过滤。网络计费模式例如："1.1.1.1","2204::22:3"。
        /// 类型：String
        /// 必选：否
        /// 获取方式：[DescribeLoadBalancers](https://cloud.tencent.com/document/product/1108/48459)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamArraySimple(map, prefix + "UconfigIds.", this.UconfigIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

