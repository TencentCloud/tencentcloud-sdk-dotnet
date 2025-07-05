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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TokenStat : AbstractModel
    {
        
        /// <summary>
        /// 会话 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 请求 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 对应哪条会话, 会话 ID, 用于回答的消息存储使用, 可提前生成, 保存消息时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// token 已使用数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedCount")]
        public ulong? UsedCount{ get; set; }

        /// <summary>
        /// 免费 token 数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FreeCount")]
        public ulong? FreeCount{ get; set; }

        /// <summary>
        /// 订单总 token 数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderCount")]
        public ulong? OrderCount{ get; set; }

        /// <summary>
        /// 当前执行状态汇总, 常量: 使用中: processing, 成功: success, 失败: failed
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusSummary")]
        public string StatusSummary{ get; set; }

        /// <summary>
        /// 当前执行状态汇总后中文展示
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusSummaryTitle")]
        public string StatusSummaryTitle{ get; set; }

        /// <summary>
        /// 当前请求执行时间, 单位 ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Elapsed")]
        public ulong? Elapsed{ get; set; }

        /// <summary>
        /// 当前请求消耗 token 数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenCount")]
        public ulong? TokenCount{ get; set; }

        /// <summary>
        /// 执行过程信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Procedures")]
        public Procedure[] Procedures{ get; set; }

        /// <summary>
        /// 执行过程信息TraceId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "UsedCount", this.UsedCount);
            this.SetParamSimple(map, prefix + "FreeCount", this.FreeCount);
            this.SetParamSimple(map, prefix + "OrderCount", this.OrderCount);
            this.SetParamSimple(map, prefix + "StatusSummary", this.StatusSummary);
            this.SetParamSimple(map, prefix + "StatusSummaryTitle", this.StatusSummaryTitle);
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "TokenCount", this.TokenCount);
            this.SetParamArrayObj(map, prefix + "Procedures.", this.Procedures);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
        }
    }
}

