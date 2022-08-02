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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNormalLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 压测项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 测试场景ID
        /// </summary>
        [JsonProperty("ScenarioId")]
        public string ScenarioId{ get; set; }

        /// <summary>
        /// 压测任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 日志上下文，加载更多日志时使用，透传上次返回的Context值，获取后续的日志内容。过期时间1小时
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 日志开始时间
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 日志结束时间
        /// </summary>
        [JsonProperty("To")]
        public string To{ get; set; }

        /// <summary>
        /// 日志级别，可取debug/info/error
        /// </summary>
        [JsonProperty("SeverityText")]
        public string SeverityText{ get; set; }

        /// <summary>
        /// 施压节点IP
        /// </summary>
        [JsonProperty("Instance")]
        public string Instance{ get; set; }

        /// <summary>
        /// 施压节点所在地域
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// 日志类型， console代表用户输出，engine代表引擎输出
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 返回日志条数限制，最大100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "SeverityText", this.SeverityText);
            this.SetParamSimple(map, prefix + "Instance", this.Instance);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

