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

    public class ResumeInstanceRefreshRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。可通过如下方式获取：
        /// <li>通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 查询伸缩组ID。</li>
        /// <li>通过调用接口 [DescribeAutoScalingGroups](https://cloud.tencent.com/document/api/377/20438) ，取返回信息中的 AutoScalingGroupId 获取伸缩组ID。</li>
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 刷新活动ID。可以通过调用接口 [DescribeRefreshActivities](https://cloud.tencent.com/document/api/377/99175) ，取返回信息中的 RefreshActivityId 获取实例刷新活动ID。
        /// </summary>
        [JsonProperty("RefreshActivityId")]
        public string RefreshActivityId{ get; set; }

        /// <summary>
        /// 当前批次刷新失败实例的恢复方式，如不存在失败实例，该参数无效。默认值为RETRY，取值范围如下：<li>RETRY: 重试当前批次刷新失败实例</li><li>CONTINUE: 跳过当前批次刷新失败实例</li>
        /// </summary>
        [JsonProperty("ResumeMode")]
        public string ResumeMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "RefreshActivityId", this.RefreshActivityId);
            this.SetParamSimple(map, prefix + "ResumeMode", this.ResumeMode);
        }
    }
}

