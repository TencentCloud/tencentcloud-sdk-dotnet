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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncTaskBindResourceResult : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 关联云资源结果
        /// </summary>
        [JsonProperty("BindResourceResult")]
        public BindResourceResult[] BindResourceResult{ get; set; }

        /// <summary>
        /// 关联云资源异步查询结果： 0表示查询中， 1表示查询成功。 2表示查询异常； 若状态为1，则查看BindResourceResult结果；若状态为2，则查看Error原因
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 关联云资源错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Error")]
        public Error Error{ get; set; }

        /// <summary>
        /// 当前结果缓存时间
        /// </summary>
        [JsonProperty("CacheTime")]
        public string CacheTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "BindResourceResult.", this.BindResourceResult);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
        }
    }
}

