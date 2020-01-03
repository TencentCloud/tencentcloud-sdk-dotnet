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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopClientIpSumInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间点，格式为yyyy-mm-dd HH:MM:SS。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间点，格式为yyyy-mm-dd HH:MM:SS
        /// 时间跨度在[0,4小时]，支持最近1天数据查询。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 播放域名，默认为不填，表示求总体数据。
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// 页号，范围是[1,1000]，默认值是1。
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 每页个数，范围是[1,1000]，默认值是20。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 排序指标，可选值包括TotalRequest（默认值），FailedRequest,TotalFlux。
        /// </summary>
        [JsonProperty("OrderParam")]
        public string OrderParam{ get; set; }

        /// <summary>
        /// 地域，可选值：Mainland，Oversea，China，Foreign，Global（默认值）；如果为空，查询总的数据；如果为“Mainland”，查询中国大陆的数据；如果为“Oversea”，则查询中国大陆以外的数据；如果为China，查询中国的数据（包括港澳台）；如果为Foreign，查询国外的数据（不包括港澳台）。
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// 输出字段使用的语言，可选值：Chinese（默认值），English；目前国家，省份和运营商支持多语言。
        /// </summary>
        [JsonProperty("OutLanguage")]
        public string OutLanguage{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "OrderParam", this.OrderParam);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "OutLanguage", this.OutLanguage);
        }
    }
}

