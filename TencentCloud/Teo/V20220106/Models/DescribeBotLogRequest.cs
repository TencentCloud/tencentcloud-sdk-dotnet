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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBotLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 分页拉取的最大返回结果数。最大值：1000。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 分页拉取的起始页号。最小值：1。
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 站点集合，不填默认查询所有站点。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// 域名集合，不填默认查询所有子域名。
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 筛选条件，取值有：
        /// <li>action ：执行动作（处置方式）；</li>
        /// <li>sipCountryCode ：ip所在国家 ；</li>
        /// <li>attackIp ：攻击ip ；</li>
        /// <li>ruleId ：规则id ；</li>
        /// <li>eventId ：事件id ；</li>
        /// <li>ua ：用户代理 ；</li>
        /// <li>requestMethod ：请求方法 ；</li>
        /// <li>uri ：统一资源标识符 。</li>
        /// </summary>
        [JsonProperty("QueryCondition")]
        public QueryCondition[] QueryCondition{ get; set; }

        /// <summary>
        /// 数据归属地区，取值有：
        /// <li>overseas ：全球（除中国大陆地区）数据 ；</li>
        /// <li>mainland ：中国大陆地区数据 。</li>不填默认查询overseas。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArrayObj(map, prefix + "QueryCondition.", this.QueryCondition);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

