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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MuskPromptInfo : AbstractModel
    {
        
        /// <summary>
        /// workflow id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// workgroup id
        /// </summary>
        [JsonProperty("WorkgroupId")]
        public string WorkgroupId{ get; set; }

        /// <summary>
        /// prompt id
        /// </summary>
        [JsonProperty("PromptId")]
        public string PromptId{ get; set; }

        /// <summary>
        /// 生成的内容
        /// </summary>
        [JsonProperty("OutputResource")]
        public string[] OutputResource{ get; set; }

        /// <summary>
        /// prompt status 
        /// 0: 执行中
        /// 1: 执行成功
        /// 2: 执行失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 任务执行耗时，单位毫秒
        /// </summary>
        [JsonProperty("Cost")]
        public ulong? Cost{ get; set; }

        /// <summary>
        /// 任务执行失败错误信息
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkgroupId", this.WorkgroupId);
            this.SetParamSimple(map, prefix + "PromptId", this.PromptId);
            this.SetParamArraySimple(map, prefix + "OutputResource.", this.OutputResource);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
        }
    }
}

