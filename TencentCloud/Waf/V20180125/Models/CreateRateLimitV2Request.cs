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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRateLimitV2Request : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规则优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 规则开关，0关闭，1开启
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 限流窗口
        /// </summary>
        [JsonProperty("LimitWindow")]
        public LimitWindow LimitWindow{ get; set; }

        /// <summary>
        /// 支持API或Domain，如果是基于API，则LimitPaths不能为空，否则LimitPaths为空
        /// </summary>
        [JsonProperty("LimitObject")]
        public string LimitObject{ get; set; }

        /// <summary>
        /// 限流策略，0:观察,1:拦截，2:人机
        /// </summary>
        [JsonProperty("LimitStrategy")]
        public long? LimitStrategy{ get; set; }

        /// <summary>
        /// 限流方法
        /// </summary>
        [JsonProperty("LimitMethod")]
        public LimitMethod LimitMethod{ get; set; }

        /// <summary>
        /// 限流路径列表
        /// </summary>
        [JsonProperty("LimitPaths")]
        public LimitPath LimitPaths{ get; set; }

        /// <summary>
        /// 限流Headers
        /// </summary>
        [JsonProperty("LimitHeaders")]
        public LimitHeader[] LimitHeaders{ get; set; }

        /// <summary>
        /// 基于Header参数名限流
        /// </summary>
        [JsonProperty("LimitHeaderName")]
        public LimitHeaderName LimitHeaderName{ get; set; }

        /// <summary>
        /// 基于Get参数名限流
        /// </summary>
        [JsonProperty("GetParamsName")]
        public MatchOption GetParamsName{ get; set; }

        /// <summary>
        /// 基于Get参数值限流
        /// </summary>
        [JsonProperty("GetParamsValue")]
        public MatchOption GetParamsValue{ get; set; }

        /// <summary>
        /// 基于Post参数名限流
        /// </summary>
        [JsonProperty("PostParamsName")]
        public MatchOption PostParamsName{ get; set; }

        /// <summary>
        /// 基于Post参数值限流
        /// </summary>
        [JsonProperty("PostParamsValue")]
        public MatchOption PostParamsValue{ get; set; }

        /// <summary>
        /// 基于IP归属地限流
        /// </summary>
        [JsonProperty("IpLocation")]
        public MatchOption IpLocation{ get; set; }

        /// <summary>
        /// 重定向信息,当LimitStrategy为重定向时，此字段必填
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public RedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// 拦截页面,0表示429，否则填写blockPageID
        /// </summary>
        [JsonProperty("BlockPage")]
        public long? BlockPage{ get; set; }

        /// <summary>
        /// 限流对象来源，0：手动填写，1：API资产
        /// </summary>
        [JsonProperty("ObjectSrc")]
        public long? ObjectSrc{ get; set; }

        /// <summary>
        /// 是否共享配额，只有当对象为URL时有效，false表示URL独享配额，true表示所有URL共享配额
        /// </summary>
        [JsonProperty("QuotaShare")]
        public bool? QuotaShare{ get; set; }

        /// <summary>
        /// 路径选项,可配置每个路径的请求方法
        /// </summary>
        [JsonProperty("PathsOption")]
        public PathItem[] PathsOption{ get; set; }

        /// <summary>
        /// 限流执行顺序，0：默认情况，限流优先，1：安全防护优先
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "LimitWindow.", this.LimitWindow);
            this.SetParamSimple(map, prefix + "LimitObject", this.LimitObject);
            this.SetParamSimple(map, prefix + "LimitStrategy", this.LimitStrategy);
            this.SetParamObj(map, prefix + "LimitMethod.", this.LimitMethod);
            this.SetParamObj(map, prefix + "LimitPaths.", this.LimitPaths);
            this.SetParamArrayObj(map, prefix + "LimitHeaders.", this.LimitHeaders);
            this.SetParamObj(map, prefix + "LimitHeaderName.", this.LimitHeaderName);
            this.SetParamObj(map, prefix + "GetParamsName.", this.GetParamsName);
            this.SetParamObj(map, prefix + "GetParamsValue.", this.GetParamsValue);
            this.SetParamObj(map, prefix + "PostParamsName.", this.PostParamsName);
            this.SetParamObj(map, prefix + "PostParamsValue.", this.PostParamsValue);
            this.SetParamObj(map, prefix + "IpLocation.", this.IpLocation);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamSimple(map, prefix + "BlockPage", this.BlockPage);
            this.SetParamSimple(map, prefix + "ObjectSrc", this.ObjectSrc);
            this.SetParamSimple(map, prefix + "QuotaShare", this.QuotaShare);
            this.SetParamArrayObj(map, prefix + "PathsOption.", this.PathsOption);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

