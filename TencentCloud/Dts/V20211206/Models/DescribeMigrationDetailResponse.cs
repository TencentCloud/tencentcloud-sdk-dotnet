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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMigrationDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据迁移任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 数据迁移任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 任务创建(提交)时间，格式为 yyyy-mm-dd hh:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务更新时间，格式为 yyyy-mm-dd hh:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 任务开始执行时间，格式为 yyyy-mm-dd hh:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务执行结束时间，格式为 yyyy-mm-dd hh:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 迁移任务简要错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BriefMsg")]
        public string BriefMsg{ get; set; }

        /// <summary>
        /// 任务状态，取值为：created(创建完成)、checking(校验中)、checkPass(校验通过)、checkNotPass(校验不通过)、readyRun(准备运行)、running(任务运行中)、readyComplete(准备完成)、success(任务成功)、failed(任务失败)、stopping(中止中)、completing(完成中)、
        /// pausing(暂停中)、
        /// manualPaused(已暂停)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务操作信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public MigrateAction Action{ get; set; }

        /// <summary>
        /// 迁移执行过程信息，在校验阶段显示校验过程步骤信息，在迁移阶段会显示迁移步骤信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StepInfo")]
        public MigrateDetailInfo StepInfo{ get; set; }

        /// <summary>
        /// 源实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcInfo")]
        public DBEndpointInfo SrcInfo{ get; set; }

        /// <summary>
        /// 目标端信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstInfo")]
        public DBEndpointInfo DstInfo{ get; set; }

        /// <summary>
        /// 数据一致性校验结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareTask")]
        public CompareTaskInfo CompareTask{ get; set; }

        /// <summary>
        /// 标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagItem[] Tags{ get; set; }

        /// <summary>
        /// 运行模式，取值如：immediate(表示立即运行)、timed(表示定时运行)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// 期待启动时间，当RunMode取值为timed时，此值必填，形如："2006-01-02 15:04:05"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpectRunTime")]
        public string ExpectRunTime{ get; set; }

        /// <summary>
        /// 迁移选项，描述任务如何执行迁移等一系列配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigrateOption")]
        public MigrateOption MigrateOption{ get; set; }

        /// <summary>
        /// 校验任务运行详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckStepInfo")]
        public CheckStepInfo CheckStepInfo{ get; set; }

        /// <summary>
        /// 描述计费相关的信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeInfo")]
        public TradeInfo TradeInfo{ get; set; }

        /// <summary>
        /// 任务错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public ErrorInfoItem[] ErrorInfo{ get; set; }

        /// <summary>
        /// 全量导出可重入标识：enum::"yes"/"no"。yes表示当前任务可重入、no表示当前任务处于全量导出且不可重入阶段；如果在该值为no时重启任务导出流程不支持断点续传
        /// </summary>
        [JsonProperty("DumperResumeCtrl")]
        public string DumperResumeCtrl{ get; set; }

        /// <summary>
        /// 任务的限速信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RateLimitOption")]
        public RateLimitOption RateLimitOption{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "BriefMsg", this.BriefMsg);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamObj(map, prefix + "StepInfo.", this.StepInfo);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamObj(map, prefix + "CompareTask.", this.CompareTask);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ExpectRunTime", this.ExpectRunTime);
            this.SetParamObj(map, prefix + "MigrateOption.", this.MigrateOption);
            this.SetParamObj(map, prefix + "CheckStepInfo.", this.CheckStepInfo);
            this.SetParamObj(map, prefix + "TradeInfo.", this.TradeInfo);
            this.SetParamArrayObj(map, prefix + "ErrorInfo.", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "DumperResumeCtrl", this.DumperResumeCtrl);
            this.SetParamObj(map, prefix + "RateLimitOption.", this.RateLimitOption);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

