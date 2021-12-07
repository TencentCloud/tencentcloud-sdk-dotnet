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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalProcessEventInfo : AbstractModel
    {
        
        /// <summary>
        /// 进程目录
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 事件类型，MALICE_PROCESS_START:恶意进程启动
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 命中规则
        /// </summary>
        [JsonProperty("MatchRuleName")]
        public string MatchRuleName{ get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// 容器名
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 镜像名
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 动作执行结果，    BEHAVIOR_NONE: 无
        ///     BEHAVIOR_ALERT: 告警
        ///     BEHAVIOR_RELEASE：放行
        ///     BEHAVIOR_HOLDUP_FAILED:拦截失败
        ///     BEHAVIOR_HOLDUP_SUCCESSED：拦截失败
        /// </summary>
        [JsonProperty("Behavior")]
        public string Behavior{ get; set; }

        /// <summary>
        /// 状态，EVENT_UNDEAL:事件未处理
        ///     EVENT_DEALED:事件已经处理
        ///     EVENT_INGNORE：事件已经忽略
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 事件记录的唯一id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 镜像id，用于跳转
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 容器id，用于跳转
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// 事件解决方案
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// 事件详细描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 命中策略id
        /// </summary>
        [JsonProperty("MatchRuleId")]
        public string MatchRuleId{ get; set; }

        /// <summary>
        /// 命中规则行为：
        /// RULE_MODE_RELEASE 放行
        /// RULE_MODE_ALERT  告警
        /// RULE_MODE_HOLDUP 拦截
        /// </summary>
        [JsonProperty("MatchAction")]
        public string MatchAction{ get; set; }

        /// <summary>
        /// 命中规则进程信息
        /// </summary>
        [JsonProperty("MatchProcessPath")]
        public string MatchProcessPath{ get; set; }

        /// <summary>
        /// 规则是否存在
        /// </summary>
        [JsonProperty("RuleExist")]
        public bool? RuleExist{ get; set; }

        /// <summary>
        /// 事件数量
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// 最近生成时间
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// 规则组Id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "MatchRuleName", this.MatchRuleName);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Behavior", this.Behavior);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MatchRuleId", this.MatchRuleId);
            this.SetParamSimple(map, prefix + "MatchAction", this.MatchAction);
            this.SetParamSimple(map, prefix + "MatchProcessPath", this.MatchProcessPath);
            this.SetParamSimple(map, prefix + "RuleExist", this.RuleExist);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

