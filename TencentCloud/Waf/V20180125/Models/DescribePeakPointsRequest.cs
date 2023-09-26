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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePeakPointsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间
        /// </summary>
        [JsonProperty("FromTime")]
        public string FromTime{ get; set; }

        /// <summary>
        /// 查询终止时间
        /// </summary>
        [JsonProperty("ToTime")]
        public string ToTime{ get; set; }

        /// <summary>
        /// 查询的域名，如果查询所有域名数据，该参数不填写
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 只有两个值有效，sparta-waf，clb-waf，不传则不过滤
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// WAF实例ID，不传则不过滤
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 十一个值可选：
        /// access-峰值qps趋势图
        /// botAccess- bot峰值qps趋势图
        /// down-下行峰值带宽趋势图
        /// up-上行峰值带宽趋势图
        /// attack-Web攻击总数趋势图
        /// cc-CC攻击总数趋势图
        /// bw-黑IP攻击总数趋势图
        /// tamper-防篡改攻击总数趋势图
        /// leak-防泄露攻击总数趋势图
        /// acl-访问控制攻击总数趋势图
        /// http_status-状态码各次数趋势图
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromTime", this.FromTime);
            this.SetParamSimple(map, prefix + "ToTime", this.ToTime);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
        }
    }
}

