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

namespace TencentCloud.Dtf.V20200506.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Transaction : AbstractModel
    {
        
        /// <summary>
        /// 主事务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionId")]
        public long? TransactionId{ get; set; }

        /// <summary>
        /// 主事务开始时间戳，UTC，精确到毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionBegin")]
        public long? TransactionBegin{ get; set; }

        /// <summary>
        /// 主事务结束时间戳，UTC，精确到毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionEnd")]
        public long? TransactionEnd{ get; set; }

        /// <summary>
        /// 主事务提交时间戳，UTC，精确到毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionCommit")]
        public long? TransactionCommit{ get; set; }

        /// <summary>
        /// 主事务回滚时间戳，UTC，精确到毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionRollback")]
        public long? TransactionRollback{ get; set; }

        /// <summary>
        /// 主事务异常停止时间戳，UTC，精确到毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionError")]
        public long? TransactionError{ get; set; }

        /// <summary>
        /// 主事务超时时长，单位毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 主事务状态：0:Trying, 1:Confirming, 2: Confirmed, 3:Canceling, 4: Canceled
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 主事务结束标识：0:运行中, 1: 已结束
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndFlag")]
        public long? EndFlag{ get; set; }

        /// <summary>
        /// 主事务超时标识：0:运行中, 1: 已超时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutFlag")]
        public long? TimeoutFlag{ get; set; }

        /// <summary>
        /// 异常信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 事务分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 主事务来源服务标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 分支事务数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BranchQuantity")]
        public long? BranchQuantity{ get; set; }

        /// <summary>
        /// 重试标识：true：可以重试；false：不可重试
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryFlag")]
        public bool? RetryFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "TransactionBegin", this.TransactionBegin);
            this.SetParamSimple(map, prefix + "TransactionEnd", this.TransactionEnd);
            this.SetParamSimple(map, prefix + "TransactionCommit", this.TransactionCommit);
            this.SetParamSimple(map, prefix + "TransactionRollback", this.TransactionRollback);
            this.SetParamSimple(map, prefix + "TransactionError", this.TransactionError);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EndFlag", this.EndFlag);
            this.SetParamSimple(map, prefix + "TimeoutFlag", this.TimeoutFlag);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "BranchQuantity", this.BranchQuantity);
            this.SetParamSimple(map, prefix + "RetryFlag", this.RetryFlag);
        }
    }
}

