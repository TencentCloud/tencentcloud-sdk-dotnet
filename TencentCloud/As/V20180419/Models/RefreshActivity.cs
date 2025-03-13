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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefreshActivity : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组 ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 刷新活动 ID。
        /// </summary>
        [JsonProperty("RefreshActivityId")]
        public string RefreshActivityId{ get; set; }

        /// <summary>
        /// 原始刷新活动ID，仅在回滚刷新活动中存在。
        /// </summary>
        [JsonProperty("OriginRefreshActivityId")]
        public string OriginRefreshActivityId{ get; set; }

        /// <summary>
        /// 刷新批次信息列表。
        /// </summary>
        [JsonProperty("RefreshBatchSet")]
        public RefreshBatch[] RefreshBatchSet{ get; set; }

        /// <summary>
        /// 刷新模式。
        /// </summary>
        [JsonProperty("RefreshMode")]
        public string RefreshMode{ get; set; }

        /// <summary>
        /// 实例更新设置参数。
        /// </summary>
        [JsonProperty("RefreshSettings")]
        public RefreshSettings RefreshSettings{ get; set; }

        /// <summary>
        /// 刷新活动类型。取值如下：
        /// <li>NORMAL：正常刷新活动</li>
        /// <li>ROLLBACK：回滚刷新活动</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 刷新活动状态。取值如下：
        /// <li>INIT：初始化中</li>
        /// <li>RUNNING：运行中</li>
        /// <li>SUCCESSFUL：活动成功</li>
        /// <li>FAILED_PAUSE：因刷新批次失败暂停</li>
        /// <li>AUTO_PAUSE：因暂停策略自动暂停</li>
        /// <li>MANUAL_PAUSE：手动暂停</li>
        /// <li>CANCELLED：活动取消</li>
        /// <li>FAILED：活动失败</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前刷新批次序号。例如，2 表示当前活动正在刷新第二批次的实例。
        /// </summary>
        [JsonProperty("CurrentRefreshBatchNum")]
        public ulong? CurrentRefreshBatchNum{ get; set; }

        /// <summary>
        /// 刷新活动开始时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 刷新活动结束时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 刷新活动创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "RefreshActivityId", this.RefreshActivityId);
            this.SetParamSimple(map, prefix + "OriginRefreshActivityId", this.OriginRefreshActivityId);
            this.SetParamArrayObj(map, prefix + "RefreshBatchSet.", this.RefreshBatchSet);
            this.SetParamSimple(map, prefix + "RefreshMode", this.RefreshMode);
            this.SetParamObj(map, prefix + "RefreshSettings.", this.RefreshSettings);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CurrentRefreshBatchNum", this.CurrentRefreshBatchNum);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

