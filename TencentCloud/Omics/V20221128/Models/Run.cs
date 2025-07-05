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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Run : AbstractModel
    {
        
        /// <summary>
        /// 任务UUID。
        /// </summary>
        [JsonProperty("RunUuid")]
        public string RunUuid{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 任务批次ID。
        /// </summary>
        [JsonProperty("RunGroupId")]
        public string RunGroupId{ get; set; }

        /// <summary>
        /// 环境ID。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 用户定义ID，单例运行为空。
        /// </summary>
        [JsonProperty("UserDefinedId")]
        public string UserDefinedId{ get; set; }

        /// <summary>
        /// 表格ID，单例运行为空。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 表格行UUID，单例运行为空。
        /// </summary>
        [JsonProperty("TableRowUuid")]
        public string TableRowUuid{ get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务输入。
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 运行选项。
        /// </summary>
        [JsonProperty("Option")]
        [System.Obsolete]
        public RunOption Option{ get; set; }

        /// <summary>
        /// 执行时间。
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public ExecutionTime ExecutionTime{ get; set; }

        /// <summary>
        /// 缓存信息。
        /// </summary>
        [JsonProperty("Cache")]
        public CacheInfo Cache{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunUuid", this.RunUuid);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "RunGroupId", this.RunGroupId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "UserDefinedId", this.UserDefinedId);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableRowUuid", this.TableRowUuid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamObj(map, prefix + "Option.", this.Option);
            this.SetParamObj(map, prefix + "ExecutionTime.", this.ExecutionTime);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

