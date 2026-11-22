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

    public class LogDiagnosisRules : AbstractModel
    {
        
        /// <summary>
        /// <p>id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>errorCode</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// <p>createTime</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>lastUpdate</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdate")]
        public string LastUpdate{ get; set; }

        /// <summary>
        /// <p>owner</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// <p>异常概要</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorTitle")]
        public string ErrorTitle{ get; set; }

        /// <summary>
        /// <p>异常关键字</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>异常原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorReason")]
        public string ErrorReason{ get; set; }

        /// <summary>
        /// <p>解决办法</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorSolution")]
        public string ErrorSolution{ get; set; }

        /// <summary>
        /// <p>展示顺序</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorOrder")]
        public string ErrorOrder{ get; set; }

        /// <summary>
        /// <p>例子</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorExample")]
        public string ErrorExample{ get; set; }

        /// <summary>
        /// <p>扩展说明</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtToolsUrl")]
        public string ExtToolsUrl{ get; set; }

        /// <summary>
        /// <p>异常级别</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorLevel")]
        public string ErrorLevel{ get; set; }

        /// <summary>
        /// <p>异常类型：用户/系统</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorTypeAggregation")]
        public string ErrorTypeAggregation{ get; set; }

        /// <summary>
        /// <p>异常系统类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorSystem")]
        public string ErrorSystem{ get; set; }

        /// <summary>
        /// <p>异常日志来源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorLogSystem")]
        public string ErrorLogSystem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdate", this.LastUpdate);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "ErrorTitle", this.ErrorTitle);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "ErrorReason", this.ErrorReason);
            this.SetParamSimple(map, prefix + "ErrorSolution", this.ErrorSolution);
            this.SetParamSimple(map, prefix + "ErrorOrder", this.ErrorOrder);
            this.SetParamSimple(map, prefix + "ErrorExample", this.ErrorExample);
            this.SetParamSimple(map, prefix + "ExtToolsUrl", this.ExtToolsUrl);
            this.SetParamSimple(map, prefix + "ErrorLevel", this.ErrorLevel);
            this.SetParamSimple(map, prefix + "ErrorTypeAggregation", this.ErrorTypeAggregation);
            this.SetParamSimple(map, prefix + "ErrorSystem", this.ErrorSystem);
            this.SetParamSimple(map, prefix + "ErrorLogSystem", this.ErrorLogSystem);
        }
    }
}

