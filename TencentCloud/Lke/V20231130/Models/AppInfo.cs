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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppInfo : AbstractModel
    {
        
        /// <summary>
        /// 应用类型；knowledge_qa-知识问答管理；summary-知识摘要；classifys-知识标签提取
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 应用类型描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppTypeDesc")]
        public string AppTypeDesc{ get; set; }

        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// 应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 应用头像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// 应用描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 应用状态，1：未上线，2：运行中，3：停用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppStatus")]
        public ulong? AppStatus{ get; set; }

        /// <summary>
        /// 状态说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppStatusDesc")]
        public string AppStatusDesc{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最后修改人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 模型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 生成模型别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAliasName")]
        public string ModelAliasName{ get; set; }

        /// <summary>
        /// 应用模式 standard:标准模式, agent: agent模式，single_workflow：单工作流模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// 思考模型别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThoughtModelAliasName")]
        public string ThoughtModelAliasName{ get; set; }

        /// <summary>
        /// 权限位信息
        /// </summary>
        [JsonProperty("PermissionIds")]
        public string[] PermissionIds{ get; set; }

        /// <summary>
        /// 创建人昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "AppTypeDesc", this.AppTypeDesc);
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "AppStatus", this.AppStatus);
            this.SetParamSimple(map, prefix + "AppStatusDesc", this.AppStatusDesc);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelAliasName", this.ModelAliasName);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "ThoughtModelAliasName", this.ThoughtModelAliasName);
            this.SetParamArraySimple(map, prefix + "PermissionIds.", this.PermissionIds);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
        }
    }
}

