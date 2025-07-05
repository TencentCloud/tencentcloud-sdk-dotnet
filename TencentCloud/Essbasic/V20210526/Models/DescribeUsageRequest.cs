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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 查询日期范围的开始时间, 查询会包含此日期的数据 , 格式为yyyy-mm-dd (例如：2021-03-21)
        /// 
        /// 注: `查询日期范围区间长度大于90天`。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 查询日期范围的结束时间, 查询会包含此日期的数据 , 格式为yyyy-mm-dd (例如：2021-04-21)
        /// 
        /// 注: `查询日期范围区间长度大于90天`。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 是否汇总数据，默认不汇总。
        /// <ul><li> **true** :  汇总数据,  即每个企业一条数据, 对日志范围内的数据相加</li>
        /// <li> **false** :  不会总数据,  返回企业每日明细,   按日期返回每个企业的数据(如果企业对应天数没有操作则无此企业此日期的数据)</li></ul>
        /// </summary>
        [JsonProperty("NeedAggregate")]
        public bool? NeedAggregate{ get; set; }

        /// <summary>
        /// 指定每页返回的数据条数，和Offset参数配合使用。
        /// 
        /// 注: `默认值为1000，单页做大值为1000`
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 查询结果分页返回，指定从第几页返回数据，和Limit参数配合使用。
        /// 
        /// 注：`offset从0开始，即第一页为0。`
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "NeedAggregate", this.NeedAggregate);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

