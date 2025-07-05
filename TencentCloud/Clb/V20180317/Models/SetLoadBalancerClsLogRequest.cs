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

    public class SetLoadBalancerClsLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例 ID，可以通过 [DescribeLoadBalancers](https://cloud.tencent.com/document/product/1108/48459) 接口查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 日志服务(CLS)的日志集 ID。
        /// <li>增加和更新日志主题时可调用 [DescribeLogsets](https://cloud.tencent.com/document/product/614/58624) 接口获取日志集 ID。</li>
        /// <li>删除日志主题时，此参数填写为**空字符串**即可。</li>
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// 日志服务(CLS)的日志主题 ID。
        /// <li>增加和更新日志主题时可调用 [DescribeTopics](https://cloud.tencent.com/document/product/614/56454) 接口获取日志主题 ID。</li>
        /// <li>删除日志主题时，此参数填写为**空字符串**即可。</li>
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }

        /// <summary>
        /// 日志类型：
        /// <li>ACCESS：访问日志</li>
        /// <li>HEALTH：健康检查日志</li>
        /// 默认为ACCESS。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "LogTopicId", this.LogTopicId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
        }
    }
}

