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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTableScoreTrendRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 开始时间 秒级时间戳
        /// </summary>
        [JsonProperty("StatisticsStartDate")]
        public long? StatisticsStartDate{ get; set; }

        /// <summary>
        /// 结束时间 秒级时间戳
        /// </summary>
        [JsonProperty("StatisticsEndDate")]
        public long? StatisticsEndDate{ get; set; }

        /// <summary>
        /// 表id
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 1:按全维度权重计算,2:按已配置维度权重计算,3:不按维度权重计算,默认1
        /// </summary>
        [JsonProperty("ScoreType")]
        public string ScoreType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "StatisticsStartDate", this.StatisticsStartDate);
            this.SetParamSimple(map, prefix + "StatisticsEndDate", this.StatisticsEndDate);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "ScoreType", this.ScoreType);
        }
    }
}

