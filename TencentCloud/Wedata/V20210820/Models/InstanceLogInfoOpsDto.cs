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

    public class InstanceLogInfoOpsDto : AbstractModel
    {
        
        /// <summary>
        /// <p>实例运行日志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogInfo")]
        public string LogInfo{ get; set; }

        /// <summary>
        /// <p>实例运行提交的yarn日志地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnLogInfo")]
        public string[] YarnLogInfo{ get; set; }

        /// <summary>
        /// <p>实例运行产生的datax日志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataLogInfo")]
        public string DataLogInfo{ get; set; }

        /// <summary>
        /// <p>第三方任务运行日志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThirdTaskRunLogInfo")]
        public string ThirdTaskRunLogInfo{ get; set; }

        /// <summary>
        /// <p>第三方任务日志链接描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThirdTaskLogUrlDesc")]
        public string ThirdTaskLogUrlDesc{ get; set; }

        /// <summary>
        /// <p>日志行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LineCount")]
        public long? LineCount{ get; set; }

        /// <summary>
        /// <p>统一执行平台日志分页查询参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// <p>日志分页查询，是否最后一页</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEnd")]
        public bool? IsEnd{ get; set; }

        /// <summary>
        /// <p>文件大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// <p>日志匹配节点信息</p>
        /// </summary>
        [JsonProperty("MatchedBrokerIp")]
        public string MatchedBrokerIp{ get; set; }

        /// <summary>
        /// <p>执行平台通用协议</p>
        /// </summary>
        [JsonProperty("ExecutionExtendedProps")]
        public PairDto[] ExecutionExtendedProps{ get; set; }

        /// <summary>
        /// <p>日志诊断规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogDiagnosisRules")]
        [System.Obsolete]
        public LogDiagnosisRules LogDiagnosisRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogInfo", this.LogInfo);
            this.SetParamArraySimple(map, prefix + "YarnLogInfo.", this.YarnLogInfo);
            this.SetParamSimple(map, prefix + "DataLogInfo", this.DataLogInfo);
            this.SetParamSimple(map, prefix + "ThirdTaskRunLogInfo", this.ThirdTaskRunLogInfo);
            this.SetParamSimple(map, prefix + "ThirdTaskLogUrlDesc", this.ThirdTaskLogUrlDesc);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "MatchedBrokerIp", this.MatchedBrokerIp);
            this.SetParamArrayObj(map, prefix + "ExecutionExtendedProps.", this.ExecutionExtendedProps);
            this.SetParamObj(map, prefix + "LogDiagnosisRules.", this.LogDiagnosisRules);
        }
    }
}

