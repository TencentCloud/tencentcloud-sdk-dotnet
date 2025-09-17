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

    public class UnsatisfiedReply : AbstractModel
    {
        
        /// <summary>
        /// 不满意回复ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplyBizId")]
        public string ReplyBizId{ get; set; }

        /// <summary>
        /// 消息记录ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordBizId")]
        public string RecordBizId{ get; set; }

        /// <summary>
        /// 用户问题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 问题回复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// 错误类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reasons")]
        public string[] Reasons{ get; set; }

        /// <summary>
        /// 处理状态，0：待处理，1：已拒答，2：已忽略，3：已纠错
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间，秒级时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间,秒级时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplyBizId", this.ReplyBizId);
            this.SetParamSimple(map, prefix + "RecordBizId", this.RecordBizId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamArraySimple(map, prefix + "Reasons.", this.Reasons);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

