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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTraceDataListRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 批次ID
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 任务ID 用于外部溯源
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 溯源码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 溯源阶段 0:商品 1:通用 2:内部溯源 3:外部溯源
        /// </summary>
        [JsonProperty("Phase")]
        public ulong? Phase{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

