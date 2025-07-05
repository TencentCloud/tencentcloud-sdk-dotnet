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

    public class DescribeAutoScalingActivitiesRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个伸缩活动ID查询。伸缩活动ID形如：`asa-5l2ejpfo`。每次请求的上限为100。参数不支持同时指定`ActivityIds`和`Filters`。
        /// </summary>
        [JsonProperty("ActivityIds")]
        public string[] ActivityIds{ get; set; }

        /// <summary>
        /// 过滤条件。过滤字段取值范围如下：
        /// <ul>
        /// <li><strong>auto-scaling-group-id</strong><ul><li>按照【<strong>伸缩组ID</strong>】进行过滤。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 或调用接口 [DescribeAutoScalingGroups](https://cloud.tencent.com/document/api/377/20438) ，取返回信息中的 AutoScalingGroupId 获取伸缩组ID。</li><li>类型：String</li><li>必选：否</li><li>示例值: asg-kiju7yt5</li></ul></li><li><strong>activity-status-code</strong><ul><li>按照【<strong>伸缩活动状态</strong>】进行过滤</li><li>类型：String</li><li>必选：否</li><li>可选项: </li><ul><li>INIT：初始化中</li><li>RUNNING：运行中</li><li>SUCCESSFUL：活动成功</li><li>PARTIALLY_SUCCESSFUL：活动部分成功</li><li>FAILED：活动失败</li><li>CANCELLED：活动取消</li></ul></ul></li><li><strong>activity-type</strong><ul><li>按照【<strong>伸缩活动类型</strong>】进行过滤</li><li>类型：String</li><li>必选：否</li><li>可选项: </li><ul><li>SCALE_OUT：扩容活动</li><li>SCALE_IN：缩容活动</li><li>ATTACH_INSTANCES：添加实例</li><li>REMOVE_INSTANCES：销毁实例</li><li>DETACH_INSTANCES：移出实例</li><li>TERMINATE_INSTANCES_UNEXPECTEDLY：实例在CVM控制台被销毁</li><li>REPLACE_UNHEALTHY_INSTANCE：替换不健康实例</li><li>START_INSTANCES：开启实例</li><li>STOP_INSTANCES：关闭实例</li><li>INVOKE_COMMAND：执行命令</li></ul></ul></li><li><strong>activity-id</strong><ul><li>按照【<strong>伸缩活动ID</strong>】进行过滤。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 获取伸缩活动ID。</li><li>类型：String</li><li>必选：否</li><li>示例值: asa-hy6tr4ed</li></ul></li></ul>
        /// 每次请求的`Filters`的上限为10，`Filter.Values`的上限为5。参数不支持同时指定`ActivityIds`和`Filters`。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 伸缩活动最早的开始时间，如果指定了ActivityIds，此参数将被忽略。取值为`UTC`时间，按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 伸缩活动最晚的结束时间，如果指定了ActivityIds，此参数将被忽略。取值为`UTC`时间，按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ActivityIds.", this.ActivityIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

