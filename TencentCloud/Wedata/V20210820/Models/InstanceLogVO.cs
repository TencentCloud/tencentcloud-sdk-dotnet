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

    public class InstanceLogVO : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// 项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **实例状态**
        /// 
        /// - [0] 表示 等待事件
        /// - [12] 表示 等待上游
        /// - [6, 7, 9, 10, 18] 表示 等待运行
        /// - [1, 19, 22] 表示 运行中
        /// - [21] 表示 跳过运行
        /// - [3] 表示 失败重试
        /// - [8, 4, 5, 13] 表示 失败
        /// - [2] 表示 成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceState")]
        public ulong? InstanceState{ get; set; }

        /// <summary>
        /// **实例运行触发类型**
        /// 
        /// - RERUN 表示重跑
        /// - ADDITION 表示补录
        /// - PERIODIC 表示周期
        /// - APERIODIC 表示非周期
        /// - RERUN_SKIP_RUN 表示重跑 - 空跑
        /// - ADDITION_SKIP_RUN 表示补录 - 空跑
        /// - PERIODIC_SKIP_RUN 表示周期 - 空跑
        /// - APERIODIC_SKIP_RUN 表示非周期 - 空跑
        /// - MANUAL_TRIGGER 表示手动触发
        /// - RERUN_MANUAL_TRIGGER 表示手动触发 - 重跑
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// 开始运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 运行完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// **运行代码内容**
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeInfo")]
        public string CodeInfo{ get; set; }

        /// <summary>
        /// **运行代码文件大小**
        /// 单位KB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeFileSize")]
        public string CodeFileSize{ get; set; }

        /// <summary>
        /// 日志所在节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// **日志内容**
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogInfo")]
        public string LogInfo{ get; set; }

        /// <summary>
        /// **日志文件大小**
        /// 单位KB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogFileSize")]
        public string LogFileSize{ get; set; }

        /// <summary>
        /// **本次查询返回的日志行数**
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LineCount")]
        public ulong? LineCount{ get; set; }

        /// <summary>
        /// **分页查询日志时使用，无具体业务含义**
        /// 
        /// 第一次查询时值为null 
        /// 第二次及以后查询时使用上一次查询返回信息中的ExtInfo字段值即可
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// 日志分页查询，是否最后一页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEnd")]
        public bool? IsEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CodeInfo", this.CodeInfo);
            this.SetParamSimple(map, prefix + "CodeFileSize", this.CodeFileSize);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "LogInfo", this.LogInfo);
            this.SetParamSimple(map, prefix + "LogFileSize", this.LogFileSize);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
        }
    }
}

