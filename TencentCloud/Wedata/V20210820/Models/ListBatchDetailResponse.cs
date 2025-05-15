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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListBatchDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 批量操作ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public ulong? JobId{ get; set; }

        /// <summary>
        /// 运行类型：
        /// ASYNC-异步
        /// SYNC-同步
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// 成功列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessResource")]
        public AsyncResourceVO[] SuccessResource{ get; set; }

        /// <summary>
        /// 失败列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailResource")]
        public AsyncResourceVO[] FailResource{ get; set; }

        /// <summary>
        /// job类型
        /// BATCH_DELETE --批量删除：1、任务名称：ResourceName
        /// BATCH_CREATE_VERSION --批量提交：1、任务名称：ResourceId 2、资源组：GroupId
        /// BATCH_MODIFY_DATASOURCE --批量修改数据源：1、任务名称：ResourceName
        /// BATCH_MODIFY_INCHARGE --批量修改责任人：1、任务名称：ResourceName
        /// BATCH_MODIFY_PARAMETER --批量修改参数：1、任务名称：ResourceName
        /// BATCH_MODIFY_SCHEDULE --批量修改调度计划：1、任务名称：ResourceName
        /// BATCH_MODIFY_GROUPID --批量修改资源组：1、任务名称：ResourceName
        /// BATCH_MODIFY_CONFIG --批量修改高级配置：1、任务名称：ResourceName
        /// BATCH_MODIFY_SCHEDULE_PARAMETER --批量修改调度参数：1、任务名称：ResourceName
        /// FORM_CREATE_VERSION--模版提交
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// CREATING("CREATING", "创建中"),
        /// INIT("INIT", "已被创建"),
        /// RUNNING("RUNNING", "运行中"),
        /// SUCCESS("SUCCESS", "成功"),
        /// FAIL("FAIL", "失败"),
        /// PART_SUCCESS("PART_SUCCESS", "部分成功"),
        /// PART_SUCCESS_WITH_ALARM("PART_SUCCESS_WITH_ALARM", "部分成功有告警"),
        /// SUCCESS_WITH_ALARM("SUCCESS_WITH_ALARM", "成功有告警"),
        /// UNKNOWN("UNKNOWN", "未知状态");
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobStatus")]
        public string JobStatus{ get; set; }

        /// <summary>
        /// 资源总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalResource")]
        public ulong? TotalResource{ get; set; }

        /// <summary>
        /// 批量提交是是否需要审批，其他的批量操作默认为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NeedApprove")]
        public bool? NeedApprove{ get; set; }

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
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamArrayObj(map, prefix + "SuccessResource.", this.SuccessResource);
            this.SetParamArrayObj(map, prefix + "FailResource.", this.FailResource);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamSimple(map, prefix + "TotalResource", this.TotalResource);
            this.SetParamSimple(map, prefix + "NeedApprove", this.NeedApprove);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

