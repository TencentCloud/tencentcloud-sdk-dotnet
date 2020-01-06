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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserCmdTask : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务状态ID，取值: -1(进行中) 0(结束)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 脚本名称
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 脚本ID
        /// </summary>
        [JsonProperty("CmdId")]
        public string CmdId{ get; set; }

        /// <summary>
        /// 运行实例数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 运行成功数量
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// 运行失败数量
        /// </summary>
        [JsonProperty("FailureCount")]
        public ulong? FailureCount{ get; set; }

        /// <summary>
        /// 执行开始时间
        /// </summary>
        [JsonProperty("RunBeginTime")]
        public string RunBeginTime{ get; set; }

        /// <summary>
        /// 执行结束时间
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "CmdId", this.CmdId);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailureCount", this.FailureCount);
            this.SetParamSimple(map, prefix + "RunBeginTime", this.RunBeginTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
        }
    }
}

