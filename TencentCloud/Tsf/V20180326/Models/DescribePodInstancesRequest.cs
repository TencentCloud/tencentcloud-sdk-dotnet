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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePodInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例所属groupId
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 偏移量，取值从0开始
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页个数，默认为20， 取值应为1~50
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤字段
        /// </summary>
        [JsonProperty("PodNameList")]
        public string[] PodNameList{ get; set; }

        /// <summary>
        /// 新老版本pod批次标识
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "PodNameList.", this.PodNameList);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

