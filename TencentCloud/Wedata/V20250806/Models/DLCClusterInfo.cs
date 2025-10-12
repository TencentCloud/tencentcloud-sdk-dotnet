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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DLCClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// dlc资源名称（需要添加角色Uin到dlc中，否则可能获取不到资源）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComputeResources")]
        public string[] ComputeResources{ get; set; }

        /// <summary>
        /// dlc地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 指定DLC集群的默认数据库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultDatabase")]
        public string DefaultDatabase{ get; set; }

        /// <summary>
        /// 集群配置标记（ 仅对标准模式的项目生效并且标准模式必填），枚举值：
        /// - Prod  (生产环境)
        /// - Dev  (开发环境)
        /// </summary>
        [JsonProperty("StandardModeEnvTag")]
        public string StandardModeEnvTag{ get; set; }

        /// <summary>
        /// 访问账号（ 仅对标准模式的项目生效并且标准模式必填），用于提交dlc任务的账号
        /// 建议使用指定子账号，给子账号设置对应库表的权限；任务负责人模式在负责人离职后容易造成任务失败；主账号模式在多个项目权限不同的情况下不易做权限控制。
        /// 
        /// 枚举值：
        /// - TASK_RUNNER （任务负责人）
        /// - OWNER （主账号模式）
        /// - SUB （子账号模式）
        /// </summary>
        [JsonProperty("AccessAccount")]
        public string AccessAccount{ get; set; }

        /// <summary>
        /// 子账号id（ 仅对标准模式的项目生效），AccessAccount为子账号模式时，需要指定子账号的id信息，其他模式不需要指定
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ComputeResources.", this.ComputeResources);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DefaultDatabase", this.DefaultDatabase);
            this.SetParamSimple(map, prefix + "StandardModeEnvTag", this.StandardModeEnvTag);
            this.SetParamSimple(map, prefix + "AccessAccount", this.AccessAccount);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
        }
    }
}

