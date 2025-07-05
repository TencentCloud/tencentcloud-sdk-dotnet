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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotebookSessionStatementBatchInformation : AbstractModel
    {
        
        /// <summary>
        /// 任务详情列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotebookSessionStatementBatch")]
        public NotebookSessionStatementInfo[] NotebookSessionStatementBatch{ get; set; }

        /// <summary>
        /// 当前批任务是否运行完成
        /// </summary>
        [JsonProperty("IsAvailable")]
        public bool? IsAvailable{ get; set; }

        /// <summary>
        /// Session唯一标识
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Batch唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NotebookSessionStatementBatch.", this.NotebookSessionStatementBatch);
            this.SetParamSimple(map, prefix + "IsAvailable", this.IsAvailable);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
        }
    }
}

