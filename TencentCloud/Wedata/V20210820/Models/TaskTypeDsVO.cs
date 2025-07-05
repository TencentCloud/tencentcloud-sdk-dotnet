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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskTypeDsVO : AbstractModel
    {
        
        /// <summary>
        /// 任务类型id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeId")]
        public long? TypeId{ get; set; }

        /// <summary>
        /// TypeDesc描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeDesc")]
        public string TypeDesc{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 服务器类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceServerType")]
        public string SourceServerType{ get; set; }

        /// <summary>
        /// 目标服务器类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServerType")]
        public string TargetServerType{ get; set; }

        /// <summary>
        /// RunJarName名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunJarName")]
        public string RunJarName{ get; set; }

        /// <summary>
        /// Killable参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KillAble")]
        public long? KillAble{ get; set; }

        /// <summary>
        /// TypeSort类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeSort")]
        public string TypeSort{ get; set; }

        /// <summary>
        /// InCharge参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 节点对应任务类型运行上限（暂时不考虑）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerParallelism")]
        public long? BrokerParallelism{ get; set; }

        /// <summary>
        /// 每个任务运行上限（暂时不考虑
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskParallelism")]
        public long? TaskParallelism{ get; set; }

        /// <summary>
        /// 补录和重跑上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DoRedoParallelism")]
        public long? DoRedoParallelism{ get; set; }

        /// <summary>
        /// 0 为不可创建任务; >0 可创建任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DowngradePriorityTries")]
        public long? DowngradePriorityTries{ get; set; }

        /// <summary>
        /// 重试等待时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryWait")]
        public long? RetryWait{ get; set; }

        /// <summary>
        /// 重试次数（在任务属性配置中设置）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryLimit")]
        public long? RetryLimit{ get; set; }

        /// <summary>
        /// DefaultAliveWait参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultAliveWait")]
        public long? DefaultAliveWait{ get; set; }

        /// <summary>
        /// PollingSeconds秒数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PollingSeconds")]
        public long? PollingSeconds{ get; set; }

        /// <summary>
        /// 参数列表xml
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamList")]
        public string ParamList{ get; set; }

        /// <summary>
        /// TaskTypeExts参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeExtension")]
        public TaskTypeExtParamDsVO[] TaskTypeExtension{ get; set; }

        /// <summary>
        /// 对应文件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 是否选择脚本路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectFilePath")]
        public bool? SelectFilePath{ get; set; }

        /// <summary>
        /// classpath是否要排除掉common-lib，默认是0不排除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludeCommonLib")]
        public bool? ExcludeCommonLib{ get; set; }

        /// <summary>
        /// runner任务完成后需要触发的hook
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostHooks")]
        public string PostHooks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "TypeDesc", this.TypeDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SourceServerType", this.SourceServerType);
            this.SetParamSimple(map, prefix + "TargetServerType", this.TargetServerType);
            this.SetParamSimple(map, prefix + "RunJarName", this.RunJarName);
            this.SetParamSimple(map, prefix + "KillAble", this.KillAble);
            this.SetParamSimple(map, prefix + "TypeSort", this.TypeSort);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "BrokerParallelism", this.BrokerParallelism);
            this.SetParamSimple(map, prefix + "TaskParallelism", this.TaskParallelism);
            this.SetParamSimple(map, prefix + "DoRedoParallelism", this.DoRedoParallelism);
            this.SetParamSimple(map, prefix + "DowngradePriorityTries", this.DowngradePriorityTries);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "RetryLimit", this.RetryLimit);
            this.SetParamSimple(map, prefix + "DefaultAliveWait", this.DefaultAliveWait);
            this.SetParamSimple(map, prefix + "PollingSeconds", this.PollingSeconds);
            this.SetParamSimple(map, prefix + "ParamList", this.ParamList);
            this.SetParamArrayObj(map, prefix + "TaskTypeExtension.", this.TaskTypeExtension);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "SelectFilePath", this.SelectFilePath);
            this.SetParamSimple(map, prefix + "ExcludeCommonLib", this.ExcludeCommonLib);
            this.SetParamSimple(map, prefix + "PostHooks", this.PostHooks);
        }
    }
}

