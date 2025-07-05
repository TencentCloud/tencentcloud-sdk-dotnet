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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListSendTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量，整型，从0开始，0代表跳过0行
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目，整型,不超过100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 任务状态 1 待开始 5 发送中 6 今日暂停发送  7 发信异常 10 发送完成。查询所有状态，则不传这个字段
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 收件人列表ID
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// 任务类型 1即时 2定时 3周期，查询所有类型则不传这个字段
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}

