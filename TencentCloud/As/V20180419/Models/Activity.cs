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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Activity : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 伸缩活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// 伸缩活动类型。取值如下：
        /// <li>SCALE_OUT：扩容活动</li>
        /// <li>SCALE_IN：缩容活动</li>
        /// <li>ATTACH_INSTANCES：添加实例</li>
        /// <li>REMOVE_INSTANCES：销毁实例</li>
        /// <li>DETACH_INSTANCES：移出实例</li>
        /// <li>TERMINATE_INSTANCES_UNEXPECTEDLY：实例在CVM控制台被销毁</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE：替换不健康实例</li>
        /// <li>START_INSTANCES：开启实例</li>
        /// <li>STOP_INSTANCES：关闭实例</li>
        /// <li>INVOKE_COMMAND：执行命令</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 伸缩活动状态。取值如下
        /// <li>INIT：初始化中</li>
        /// <li>RUNNING：运行中</li>
        /// <li>SUCCESSFUL：活动成功</li>
        /// <li>PARTIALLY_SUCCESSFUL：活动部分成功</li>
        /// <li>FAILED：活动失败</li>
        /// <li>CANCELLED：活动取消</li>
        /// </summary>
        [JsonProperty("StatusCode")]
        public string StatusCode{ get; set; }

        /// <summary>
        /// 伸缩活动状态描述。
        /// </summary>
        [JsonProperty("StatusMessage")]
        public string StatusMessage{ get; set; }

        /// <summary>
        /// 伸缩活动起因。
        /// </summary>
        [JsonProperty("Cause")]
        public string Cause{ get; set; }

        /// <summary>
        /// 伸缩活动描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 伸缩活动开始时间，为 `UTC` 标准时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 伸缩活动结束时间，为 `UTC` 标准时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 伸缩活动创建时间，为 `UTC` 标准时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 该参数已废弃，请勿使用。
        /// </summary>
        [JsonProperty("ActivityRelatedInstanceSet")]
        [System.Obsolete]
        public ActivtyRelatedInstance[] ActivityRelatedInstanceSet{ get; set; }

        /// <summary>
        /// 伸缩活动状态简要描述。
        /// </summary>
        [JsonProperty("StatusMessageSimplified")]
        public string StatusMessageSimplified{ get; set; }

        /// <summary>
        /// 伸缩活动中生命周期挂钩的执行结果。
        /// </summary>
        [JsonProperty("LifecycleActionResultSet")]
        public LifecycleActionResultInfo[] LifecycleActionResultSet{ get; set; }

        /// <summary>
        /// 伸缩活动状态详细描述。
        /// </summary>
        [JsonProperty("DetailedStatusMessageSet")]
        public DetailedStatusMessage[] DetailedStatusMessageSet{ get; set; }

        /// <summary>
        /// 执行命令结果。
        /// </summary>
        [JsonProperty("InvocationResultSet")]
        public InvocationResult[] InvocationResultSet{ get; set; }

        /// <summary>
        /// 伸缩活动相关实例信息集合。
        /// </summary>
        [JsonProperty("RelatedInstanceSet")]
        public RelatedInstance[] RelatedInstanceSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "StatusMessage", this.StatusMessage);
            this.SetParamSimple(map, prefix + "Cause", this.Cause);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "ActivityRelatedInstanceSet.", this.ActivityRelatedInstanceSet);
            this.SetParamSimple(map, prefix + "StatusMessageSimplified", this.StatusMessageSimplified);
            this.SetParamArrayObj(map, prefix + "LifecycleActionResultSet.", this.LifecycleActionResultSet);
            this.SetParamArrayObj(map, prefix + "DetailedStatusMessageSet.", this.DetailedStatusMessageSet);
            this.SetParamArrayObj(map, prefix + "InvocationResultSet.", this.InvocationResultSet);
            this.SetParamArrayObj(map, prefix + "RelatedInstanceSet.", this.RelatedInstanceSet);
        }
    }
}

