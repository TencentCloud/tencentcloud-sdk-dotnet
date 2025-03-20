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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskMonitorInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务ID列表，上限50个
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 引擎名称
        /// </summary>
        [JsonProperty("HouseName")]
        public string HouseName{ get; set; }

        /// <summary>
        /// 任务创建时间的起始时间
        /// </summary>
        [JsonProperty("CreateTimeStart")]
        public string CreateTimeStart{ get; set; }

        /// <summary>
        /// 任务创建时间的结束时间
        /// </summary>
        [JsonProperty("CreateTimeEnd")]
        public string CreateTimeEnd{ get; set; }

        /// <summary>
        /// 每一页条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamSimple(map, prefix + "HouseName", this.HouseName);
            this.SetParamSimple(map, prefix + "CreateTimeStart", this.CreateTimeStart);
            this.SetParamSimple(map, prefix + "CreateTimeEnd", this.CreateTimeEnd);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

