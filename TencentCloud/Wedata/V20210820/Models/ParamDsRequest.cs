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

    public class ParamDsRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数key
        /// </summary>
        [JsonProperty("ParamKey")]
        public string ParamKey{ get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// 参数周期运行值
        /// </summary>
        [JsonProperty("ParamDefine")]
        public string ParamDefine{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 操作者名
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// sql内容
        /// </summary>
        [JsonProperty("SqlContent")]
        public string SqlContent{ get; set; }

        /// <summary>
        /// 数据时间
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("KeyWords")]
        public string KeyWords{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("MyVersion")]
        public long? MyVersion{ get; set; }

        /// <summary>
        /// 上游
        /// </summary>
        [JsonProperty("Upstream")]
        public bool? Upstream{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("ParamDescription")]
        public string ParamDescription{ get; set; }

        /// <summary>
        /// 参数调试运行值
        /// </summary>
        [JsonProperty("ParamDefineTest")]
        public string ParamDefineTest{ get; set; }

        /// <summary>
        /// 是否为更新，true表示更新，false表示新建
        /// </summary>
        [JsonProperty("UpdateFlag")]
        public bool? UpdateFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamKey", this.ParamKey);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "ParamDefine", this.ParamDefine);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "SqlContent", this.SqlContent);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "KeyWords", this.KeyWords);
            this.SetParamSimple(map, prefix + "MyVersion", this.MyVersion);
            this.SetParamSimple(map, prefix + "Upstream", this.Upstream);
            this.SetParamSimple(map, prefix + "ParamDescription", this.ParamDescription);
            this.SetParamSimple(map, prefix + "ParamDefineTest", this.ParamDefineTest);
            this.SetParamSimple(map, prefix + "UpdateFlag", this.UpdateFlag);
        }
    }
}

