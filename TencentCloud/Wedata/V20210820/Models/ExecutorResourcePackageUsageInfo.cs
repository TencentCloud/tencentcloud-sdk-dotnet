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

    public class ExecutorResourcePackageUsageInfo : AbstractModel
    {
        
        /// <summary>
        /// CPU占用百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuUsagePercent")]
        public float? CpuUsagePercent{ get; set; }

        /// <summary>
        /// 内存占用百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemUsagePercent")]
        public float? MemUsagePercent{ get; set; }

        /// <summary>
        /// 资源包状态, /**
        ///      * 初始化中
        ///      */
        ///     INIT(0),
        ///     /**
        ///      * 运行中
        ///      */
        ///     RUNNING(1),
        ///     /**
        ///      * 运行异常
        ///      */
        ///     RUNNING_FAILED(2),
        ///     /**
        ///      * 释放中
        ///      */
        ///     DELETEING(3),
        ///     /**
        ///      * 已释放
        ///      */
        ///     DELETED(4),
        ///     /**
        ///      * 创建中
        ///      */
        ///     CREATING(5),
        ///     /**
        ///      * 创建失败
        ///      */
        ///     CREATE_FAILED(6),
        ///     /**
        ///      * 更新中
        ///      */
        ///     UPDATING(7),
        ///     /**
        ///      * 更新失败
        ///      */
        ///     UPDATE_FAILED(8),
        ///     /**
        ///      * 已到期
        ///      */
        ///     EXPIRED(9);
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public float? Status{ get; set; }

        /// <summary>
        /// /**
        ///      * 初始化中
        ///      */
        ///     INIT(0),
        ///     /**
        ///      * 运行中
        ///      */
        ///     RUNNING(1),
        ///     /**
        ///      * 运行异常
        ///      */
        ///     RUNNING_FAILED(2),
        ///     /**
        ///      * 释放中
        ///      */
        ///     DELETEING(3),
        ///     /**
        ///      * 已释放
        ///      */
        ///     DELETED(4),
        ///     /**
        ///      * 创建中
        ///      */
        ///     CREATING(5),
        ///     /**
        ///      * 创建失败
        ///      */
        ///     CREATE_FAILED(6),
        ///     /**
        ///      * 更新中
        ///      */
        ///     UPDATING(7),
        ///     /**
        ///      * 更新失败
        ///      */
        ///     UPDATE_FAILED(8),
        ///     /**
        ///      * 已到期
        ///      */
        /// 运行中的任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningTaskNum")]
        public long? RunningTaskNum{ get; set; }

        /// <summary>
        /// 等待中的任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitingTaskNum")]
        public long? WaitingTaskNum{ get; set; }

        /// <summary>
        /// 资源使用趋势: 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsageTrendStartTime")]
        public string UsageTrendStartTime{ get; set; }

        /// <summary>
        /// 资源使用趋势: 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsageTrendEndTime")]
        public string UsageTrendEndTime{ get; set; }

        /// <summary>
        /// 资源使用趋势列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsageTrendList")]
        public ExecutorUsageTrendInfo[] UsageTrendList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CpuUsagePercent", this.CpuUsagePercent);
            this.SetParamSimple(map, prefix + "MemUsagePercent", this.MemUsagePercent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RunningTaskNum", this.RunningTaskNum);
            this.SetParamSimple(map, prefix + "WaitingTaskNum", this.WaitingTaskNum);
            this.SetParamSimple(map, prefix + "UsageTrendStartTime", this.UsageTrendStartTime);
            this.SetParamSimple(map, prefix + "UsageTrendEndTime", this.UsageTrendEndTime);
            this.SetParamArrayObj(map, prefix + "UsageTrendList.", this.UsageTrendList);
        }
    }
}

