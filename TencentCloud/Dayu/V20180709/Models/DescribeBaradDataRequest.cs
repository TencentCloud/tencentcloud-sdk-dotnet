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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBaradDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgpip表示高防IP；net表示高防IP专业版；shield表示棋牌盾）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 资源实例ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 指标名，取值：
        /// connum表示TCP活跃连接数；
        /// new_conn表示新建TCP连接数；
        /// inactive_conn表示非活跃连接数;
        /// intraffic表示入流量；
        /// outtraffic表示出流量；
        /// alltraffic表示出流量和入流量之和；
        /// inpkg表示入包速率；
        /// outpkg表示出包速率；
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 统计时间粒度，单位秒（300表示5分钟；3600表示小时；86400表示天）
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 统计开始时间，秒部分保持为0，分钟部分为5的倍数
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 统计结束时间，秒部分保持为0，分钟部分为5的倍数
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 统计方式，取值：
        /// max表示最大值；
        /// min表示最小值；
        /// avg表示均值；
        /// </summary>
        [JsonProperty("Statistics")]
        public string Statistics{ get; set; }

        /// <summary>
        /// 协议端口数组
        /// </summary>
        [JsonProperty("ProtocolPort")]
        public ProtocolPort[] ProtocolPort{ get; set; }

        /// <summary>
        /// 资源实例下的IP，只有当Business=net(高防IP专业版)时才必须填写资源的一个IP（因为高防IP专业版资源实例有多个IP，才需要指定）；
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Statistics", this.Statistics);
            this.SetParamArrayObj(map, prefix + "ProtocolPort.", this.ProtocolPort);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
        }
    }
}

