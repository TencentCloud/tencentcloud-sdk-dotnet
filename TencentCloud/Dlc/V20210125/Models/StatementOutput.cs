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

    public class StatementOutput : AbstractModel
    {
        
        /// <summary>
        /// 执行总数
        /// </summary>
        [JsonProperty("ExecutionCount")]
        public long? ExecutionCount{ get; set; }

        /// <summary>
        /// Statement数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Data")]
        public KVPair[] Data{ get; set; }

        /// <summary>
        /// Statement状态:ok,error
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 错误名称
        /// </summary>
        [JsonProperty("ErrorName")]
        public string ErrorName{ get; set; }

        /// <summary>
        /// 错误类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorValue")]
        public string ErrorValue{ get; set; }

        /// <summary>
        /// 错误堆栈信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string[] ErrorMessage{ get; set; }

        /// <summary>
        /// SQL类型任务结果返回
        /// </summary>
        [JsonProperty("SQLResult")]
        public string SQLResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutionCount", this.ExecutionCount);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorName", this.ErrorName);
            this.SetParamSimple(map, prefix + "ErrorValue", this.ErrorValue);
            this.SetParamArraySimple(map, prefix + "ErrorMessage.", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "SQLResult", this.SQLResult);
        }
    }
}

