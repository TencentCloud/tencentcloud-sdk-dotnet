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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmAccessTopologySummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 来源IP数
        /// </summary>
        [JsonProperty("SourceIpCount")]
        public long? SourceIpCount{ get; set; }

        /// <summary>
        /// 访问账号数
        /// </summary>
        [JsonProperty("AccountCount")]
        public long? AccountCount{ get; set; }

        /// <summary>
        /// 被访问的库数
        /// </summary>
        [JsonProperty("DbCount")]
        public long? DbCount{ get; set; }

        /// <summary>
        /// 被访问的表数
        /// </summary>
        [JsonProperty("TableCount")]
        public long? TableCount{ get; set; }

        /// <summary>
        /// 近7天访问次数
        /// </summary>
        [JsonProperty("AccessCountLast7Days")]
        public long? AccessCountLast7Days{ get; set; }

        /// <summary>
        /// 近30天访问次数
        /// </summary>
        [JsonProperty("AccessCountLast30Days")]
        public long? AccessCountLast30Days{ get; set; }

        /// <summary>
        /// 表级访问组合数（实例+账号+来源IP+库+schema+表 的去重组合数）
        /// </summary>
        [JsonProperty("TableCombinationCount")]
        public long? TableCombinationCount{ get; set; }

        /// <summary>
        /// 表级访问组合数是否已达上限。为 true 时表级拓扑数据不完整：达上限后新出现的访问组合会被拒绝写入（已有组合仍继续累加），因此展示的拓扑可能缺失部分对象，且保留了哪些组合取决于到达顺序。建议据此显式提示数据不完整。查询不到该标志时不返回本字段
        /// </summary>
        [JsonProperty("DataIncomplete")]
        public bool? DataIncomplete{ get; set; }

        /// <summary>
        /// 数据最后计算时间。拓扑数据由后台预聚合产生，存在链路延迟；多成员账号场景取各成员中最早的一个
        /// </summary>
        [JsonProperty("LastCalcTime")]
        public string LastCalcTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceIpCount", this.SourceIpCount);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "DbCount", this.DbCount);
            this.SetParamSimple(map, prefix + "TableCount", this.TableCount);
            this.SetParamSimple(map, prefix + "AccessCountLast7Days", this.AccessCountLast7Days);
            this.SetParamSimple(map, prefix + "AccessCountLast30Days", this.AccessCountLast30Days);
            this.SetParamSimple(map, prefix + "TableCombinationCount", this.TableCombinationCount);
            this.SetParamSimple(map, prefix + "DataIncomplete", this.DataIncomplete);
            this.SetParamSimple(map, prefix + "LastCalcTime", this.LastCalcTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

